using System;
using System.Drawing;
using System.IO;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (string file in filenames)
        {
            // Load the image
            using (Bitmap bitmap = new Bitmap(file))
            {
                // Invert the image
                for (int y = 0; y < bitmap.Height; y++)
                {
                    for (int x = 0; x < bitmap.Width; x++)
                    {
                        Color originalColor = bitmap.GetPixel(x, y);
                        Color invertedColor = Color.FromArgb(
                            originalColor.A,          // Preserve the alpha channel
                            255 - originalColor.R,    // Invert Red
                            255 - originalColor.G,    // Invert Green
                            255 - originalColor.B     // Invert Blue
                        );
                        bitmap.SetPixel(x, y, invertedColor);
                    }
                }

                // Save the inverted image
                string directory = Path.GetDirectoryName(file);
                string filename = Path.GetFileNameWithoutExtension(file);
                string extension = Path.GetExtension(file);
                string outputFile = Path.Combine(directory, $"{filename}_inverse{extension}");
                
                bitmap.Save(outputFile);
            }
        }
    }
}
