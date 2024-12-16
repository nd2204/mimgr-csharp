using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace app.utils;
internal class ImageUtils {
    /// <summary>
    /// Resize the given icon to the specified width and height.
    /// </summary>
    public static Image ResizeImage(Image icon, int width, int height) {
        Bitmap resizedIcon = new Bitmap(width, height);
        using (Graphics g = Graphics.FromImage(resizedIcon)) {
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.DrawImage(icon, 0, 0, width, height);
        }
        return resizedIcon;
    }

    /// <summary>
    /// Change the color of an icon while retaining transparency.
    /// </summary>
    public static Image ChangeImageColor(Image icon, Color color) {
        Bitmap coloredIcon = new Bitmap(icon.Width, icon.Height, PixelFormat.Format32bppArgb);
        using (Graphics g = Graphics.FromImage(coloredIcon)) {
            g.DrawImage(icon, 0, 0);
        }

        for (int y = 0; y < coloredIcon.Height; y++) {
            for (int x = 0; x < coloredIcon.Width; x++) {
                Color pixelColor = coloredIcon.GetPixel(x, y);
                if (pixelColor.A != 0) {
                    Color newColor = Color.FromArgb(pixelColor.A, color.R, color.G, color.B);
                    coloredIcon.SetPixel(x, y, newColor);
                }
            }
        }

        return coloredIcon;
    }

    /// <summary>
    /// Resize an icon while maintaining its aspect ratio.
    /// </summary>
    public static Image ResizeByAspectRatio(Image icon, int targetWidth = -1, int targetHeight = -1) {
        if (targetWidth <= 0 && targetHeight <= 0) {
            throw new ArgumentException("Either targetWidth or targetHeight must be specified.");
        }

        float aspectRatio = (float)icon.Width / icon.Height;

        if (targetWidth > 0 && targetHeight <= 0) {
            targetHeight = (int)(targetWidth / aspectRatio);
        }
        else if (targetHeight > 0 && targetWidth <= 0) {
            targetWidth = (int)(targetHeight * aspectRatio);
        }

        return ResizeImage(icon, targetWidth, targetHeight);
    }

}
