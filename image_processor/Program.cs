using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] filenames;

        if (args.Length > 1)
        {
            filenames = args;
        }
        else
        {
            filenames = Directory.GetFiles("images/", "*.jpg");
        }

        // Test Inverse Method
        ImageProcessor.Inverse(filenames);

        // Test Grayscale Method
        ImageProcessor.Grayscale(filenames);

        // Test Black and White Method with a threshold of 128 (adjust as needed)
        ImageProcessor.BlackWhite(filenames, 128);

        // Test Thumbnail Method with height of 100 pixels (adjust as needed)
        ImageProcessor.Thumbnail(filenames, 100);
    }
}
