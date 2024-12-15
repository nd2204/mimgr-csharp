using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.globals {
    internal class FontManager {
        private static Lazy<FontManager> _instance = new Lazy<FontManager>(() => new FontManager());
        public static FontManager Instance = _instance.Value;

        private readonly InstalledFontCollection installedFonts;
        private readonly Dictionary<string, FontFamily> fontCache;
        private readonly PrivateFontCollection customFontCollection;


        public Font nunito_bold_8;
        public Font nunito_bold_10;
        public Font nunito_bold_12;
        public Font nunito_bold_14;
        public Font nunito_bold_16;
        public Font nunito_bold_18;
        public Font nunito_bold_20;
        public Font nunito_bold_22;
        public Font nunito_bold_24;
        public Font nunito_bold_26;

        private FontManager() {
            installedFonts = new InstalledFontCollection();
            fontCache = new Dictionary<string, FontFamily>(StringComparer.OrdinalIgnoreCase);
            customFontCollection = new PrivateFontCollection();

            // Load system fonts into cache
            foreach (FontFamily fontFamily in installedFonts.Families) {
                Console.WriteLine($"[info] Loaded font: {fontFamily.Name}");
                fontCache[fontFamily.Name] = fontFamily;
            }

            LoadCustomFont(ResourceManager.GetResource("fonts\\Nunito-Bold.ttf").FullName);
            nunito_bold_8  = GetFont("Nunito",  8);
            nunito_bold_10 = GetFont("Nunito", 10);
            nunito_bold_12 = GetFont("Nunito", 12);
            nunito_bold_14 = GetFont("Nunito", 14);
            nunito_bold_16 = GetFont("Nunito", 16);
            nunito_bold_18 = GetFont("Nunito", 18);
            nunito_bold_20 = GetFont("Nunito", 20);
            nunito_bold_22 = GetFont("Nunito", 22);
            nunito_bold_24 = GetFont("Nunito", 24);
            nunito_bold_26 = GetFont("Nunito", 26);
        }

        /// <summary>
        /// List all available font families.
        /// </summary>
        public List<string> GetAvailableFonts() {
            var fontList = new List<string>();
            foreach (var fontName in fontCache.Keys) {
                fontList.Add(fontName);
            }
            return fontList;
        }

        /// <summary>
        /// Load a custom font from a file.
        /// </summary>
        public void LoadCustomFont(string fontFilePath) {
            if (!File.Exists(fontFilePath)) {
                throw new FileNotFoundException("Font file not found.", fontFilePath);
            }

            customFontCollection.AddFontFile(fontFilePath);
            foreach (FontFamily fontFamily in customFontCollection.Families) {
                Console.WriteLine($"[info] Loaded font: {fontFamily.Name}");
                fontCache[fontFamily.Name] = fontFamily;
            }
        }

        /// <summary>
        /// Retrieve a Font object by name and size.
        /// </summary>
        public Font GetFont(string fontName, float size, FontStyle style = FontStyle.Regular) {
            if (fontCache.TryGetValue(fontName, out FontFamily fontFamily)) {
                return new Font(fontFamily, size, style);
            }
            else {
                throw new ArgumentException($"Font '{fontName}' not found.");
            }
        }

        /// <summary>
        /// Check if a font family is available.
        /// </summary>
        public bool IsFontAvailable(string fontName) {
            return fontCache.ContainsKey(fontName);
        }

        /// <summary>
        /// Dispose of the font collections.
        /// </summary>
        public void Dispose() {
            customFontCollection.Dispose();
        }
    }
}
