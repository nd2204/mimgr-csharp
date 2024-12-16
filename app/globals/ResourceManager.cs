using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace app.globals {

    internal class ResourceManager {
        private static readonly Lazy<ResourceManager> instance = new Lazy<ResourceManager>(() => new ResourceManager());
        public static ResourceManager Instance => instance.Value;

        private List<FileInfo> tempFiles = new List<FileInfo>();
        private static DirectoryInfo ResourcePath = new DirectoryInfo(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "resources"));
        public DirectoryInfo AppDataPath { get; }
        public DirectoryInfo TempPath { get; }
        public DirectoryInfo UploadPath { get; }
        public DirectoryInfo ExportPath { get; }
        public DirectoryInfo ProjectPath { get; }

        private readonly string APP_NAME = "mimgr";

        private ResourceManager() {

            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (string.IsNullOrEmpty(appData)) {
                appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData); // Fallback to Local AppData
            }
            AppDataPath = new DirectoryInfo(Path.Combine(appData, APP_NAME));

            ProjectPath = new DirectoryInfo(Path.Combine(AppContext.BaseDirectory, "..", "..", ".."));
            UploadPath = new DirectoryInfo(Path.Combine(ProjectPath.FullName, "..", "uploads"));
            ExportPath = new DirectoryInfo(Path.Combine(ProjectPath.FullName, "..", "exports"));
            TempPath = new DirectoryInfo(Path.Combine(Path.GetTempPath(), APP_NAME));

            CreateDirIfNotExists(AppDataPath);
            CreateDirIfNotExists(UploadPath);
            CreateDirIfNotExists(ExportPath);
            CreateDirIfNotExists(TempPath);
        }
        public Image GetUploadFromDB(string name) {
            try {
                name = name.Substring(name.LastIndexOf("/") + 1).Replace("/", "\\\\");
                return Image.FromFile(Path.Combine(UploadPath.FullName, name));
            } catch (FileNotFoundException ex) {
                Console.Error.WriteLine(ex.Message);
                return null;
            }
        }

        public Image GetUploadImage(string name) {
            try {
                return Image.FromFile(Path.Combine(UploadPath.FullName, name));
            } catch (FileNotFoundException ex) {
                Console.Error.WriteLine(ex.Message);
                return null;
            }
        }

        public Image GetIconImage(string name) {
            try {
                return Image.FromFile(Path.Combine(ResourcePath.FullName, "icons", name));
            } catch (FileNotFoundException ex) {
                Console.Error.WriteLine(ex.Message);
                return null;
            }
        }

        public static FileInfo GetResource(string path) {
            FileInfo file = new FileInfo(Path.Combine(ResourcePath.FullName,  path));
            if (file.Exists) {
                return file;
            }
            return null;
        }

        public static void CreateDirIfNotExists(DirectoryInfo directory) {
            if (!directory.Exists) {
                directory.Create();
            }
        }

        public async Task<FileInfo> DownloadTempFileAsync(string urlstring) {
            var path = await DownloadFileToPathAsync(urlstring, this.TempPath);
            tempFiles.Add(path);
            return path;
        }

        public FileInfo SaveImageToTempFile(Image image) {
            try {
                string tempFileName = Path.Combine(TempPath.FullName, $"image_{Guid.NewGuid()}.jpg");
                image.Save(tempFileName, ImageFormat.Jpeg);
                var fileInfo = new FileInfo(tempFileName);
                tempFiles.Add(fileInfo);
                return fileInfo;
            }
            catch (Exception) {
                return null;
            }
        }


        public void CleanTempFiles() {
            foreach (var file in tempFiles) {
                if (file.Exists) {
                    file.Delete();
                }
            }
            tempFiles.Clear();
        }

        public static async Task<FileInfo> DownloadFileToPathAsync(string urlstring, DirectoryInfo saveDirectory) {
            FileInfo filePath = null;

            try {
                var client = new HttpClient();
                var response = await client.GetAsync(urlstring);
                response.EnsureSuccessStatusCode();

                var filename = GetFileNameFromResponse(response);
                filePath = new FileInfo(Path.Combine(saveDirectory.FullName, filename));

                using (var stream = await response.Content.ReadAsStreamAsync()) {
                    using (var fileStream = new FileStream(filePath.FullName, FileMode.Create, FileAccess.Write)) {
                        await stream.CopyToAsync(fileStream);
                    }
                }

                Console.WriteLine($"File downloaded successfully to {filePath.FullName}");
            }
            catch (Exception e) {
                Console.Error.WriteLine(e.Message);
            }

            return filePath;
        }

        //public static boolean isImageUrl(string urlstring) {
        //    try {
        //        URI uri = new URI(urlstring);
        //        HttpClient client = HttpClient.newHttpClient();
        //        HttpRequest request = HttpRequest.newBuilder()
        //        .uri(uri)
        //        .method("HEAD", HttpRequest.BodyPublishers.noBody())
        //        .build();
        //        HttpResponse<Void> response = client.send(request, HttpResponse.BodyHandlers.discarding());
        //        string contentType = response.headers().firstValue("Content-Type").orElse("");

        //        return contentType != null && contentType.startsWith("image/");
        //    }
        //    catch (Exception e) {
        //        e.printStackTrace();
        //        return false;
        //    }
        //}

        public bool isValidImageFile(FileInfo file) {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".webp" };
            string extension = file.Extension.ToLower();

            // Check file extension
            if (Array.Exists(validExtensions, ext => ext == extension)) {
                try {
                    using (var img = Image.FromFile(file.FullName)) {
                        return true;
                    }
                }
                catch {
                    return false;
                }
            }

            return false;
        }

        public FileInfo MoveStagedFileToUploadDir(FileInfo file) {
            var destinationPath = GetUniquePath(new FileInfo(Path.Combine(this.UploadPath.FullName, file.Name)));
            file.CopyTo(destinationPath.FullName, true);
            Console.WriteLine($"Copied to: {destinationPath.FullName}");
            return destinationPath;
        }

        public FileInfo MoveStagedFileToEpxortDir(FileInfo file) {
            FileInfo destinationPath = null;
            destinationPath = GetUniquePath(new FileInfo(Path.Combine(this.ExportPath.FullName, file.Name)));
            Console.WriteLine($"Exported to: {destinationPath.FullName}");
            return destinationPath;
        }

        public string GetRelativePathFromProjectToPath(FileInfo path) {
            return Path.GetRelativePath(ProjectPath.FullName, path.FullName);
        }

        public static FileInfo GetUniquePath(FileInfo destinationPath) {
            int copyNumber = 1;
            var newPath = destinationPath;

            // Check if the destination file exists, add a suffix if it does
            while (newPath.Exists) {
                string filename = Path.GetFileNameWithoutExtension(destinationPath.Name);
                string extension = destinationPath.Extension;
                newPath = new FileInfo(Path.Combine(destinationPath.DirectoryName, $"{filename}_{copyNumber}{extension}"));
                copyNumber++;
            }

            return newPath;
        }

        private static string GetFileNameFromResponse(HttpResponseMessage response) {
            if (response.Content.Headers.ContentDisposition?.FileName != null) {
                return response.Content.Headers.ContentDisposition.FileName.Trim('"');
            }

            var uri = response.RequestMessage.RequestUri;
            return Path.GetFileName(uri.LocalPath);
        }

        //private BufferedImage toBufferedImage(Image img) {
        //    if (img instanceof BufferedImage) {
        //        return (BufferedImage)img;
        //    }

        //    // Create a buffered image with transparency
        //    BufferedImage bufferedImage = new BufferedImage(
        //      img.getWidth(null), img.getHeight(null), BufferedImage.TYPE_INT_RGB);

        //    // Draw the image onto the buffered image
        //    bufferedImage.getGraphics().drawImage(img, 0, 0, null);
        //    bufferedImage.getGraphics().dispose();

        //    return bufferedImage;
        //}

    }
}
