using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

class ImageProcessor
{
    /// <summary> Inverse Method: produce inverse of given image </summary>
    public static void Inverse(string[] filenames)
    {
        foreach (string filename in filenames)
        {
            using (Image<Rgba32> image = Image.Load<Rgba32>(filename))
            {
                // Invert colors
                image.Mutate(x => x.Invert());
                // Create new file name
                string new_filename = Path.GetFileNameWithoutExtension(filename) + "_inverse" + Path.GetExtension(filename);
                // Save the modified image
                image.Save(new_filename);
            }
        }
    }

    /// <summary> Grayscale Method: produce grayscale image of given image </summary>
    public static void Grayscale(string[] filenames)
    {
        foreach (string filename in filenames)
        {
            using (Image<Rgba32> image = Image.Load<Rgba32>(filename))
            {
                // Convert to grayscale
                image.Mutate(x => x.Grayscale());
                // Create new file name
                string new_filename = Path.GetFileNameWithoutExtension(filename) + "_grayscale" + Path.GetExtension(filename);
                // Save the modified image
                image.Save(new_filename);
            }
        }
    }

    /// <summary> BlackWhite Method: produce a black/white image from a given image </summary>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        foreach (string filename in filenames)
        {
            using (Image<Rgba32> image = Image.Load<Rgba32>(filename))
            {
                // Apply a binary threshold to convert to black and white
                image.Mutate(x => x.BinaryThreshold((float)(threshold / 255.0)));
                // Create new file name
                string new_filename = Path.GetFileNameWithoutExtension(filename) + "_bw" + Path.GetExtension(filename);
                // Save the modified image
                image.Save(new_filename);
            }
        }
    }

    /// <summary> Thumbnail Method: produce a thumbnail image from a given image </summary>
    public static void Thumbnail(string[] filenames, int height)
    {
        foreach (string filename in filenames)
        {
            using (Image<Rgba32> image = Image.Load<Rgba32>(filename))
            {
                // Calculate aspect ratio and set the width based on the provided height
                int width = (int)((double)image.Width / image.Height * height);
                // Resize the image while maintaining the aspect ratio
                image.Mutate(x => x.Resize(width, height));
                // Create new file name
                string new_filename = Path.GetFileNameWithoutExtension(filename) + "_th" + Path.GetExtension(filename);
                // Save the modified image
                image.Save(new_filename);
            }
        }
    }
}
