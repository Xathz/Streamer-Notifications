using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace StreamerNotifications.Utilities {

    public static class ImageUtilities {

        /// <summary>
        /// Change the opacity of an image.
        /// </summary>
        /// <param name="image">The image to change.</param>
        /// <param name="opacity">The opacity to set.</param>
        public static Image SetImageOpacity(Image image, float opacity) {
            Bitmap imageBitmap = new Bitmap(image.Width, image.Height);
            using (Graphics imageGraphics = Graphics.FromImage(imageBitmap)) {
                ColorMatrix matrix = new ColorMatrix { Matrix33 = opacity };
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                imageGraphics.DrawImage(image, new Rectangle(0, 0, imageBitmap.Width, imageBitmap.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return imageBitmap;
        }

        /// <summary>
        /// Resize an image.
        /// </summary>
        /// <param name="image">Image to resize.</param>
        /// <param name="width">The width to set.</param>
        /// <param name="height">The height to set.</param>
        /// <remarks>https://stackoverflow.com/a/33691360</remarks>
        public static Image ResizeImage(Image image, int width, int height) {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

    }

}
