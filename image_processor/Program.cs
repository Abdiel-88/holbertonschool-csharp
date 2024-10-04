using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] filenames;

        if (args.Length > 1)
            filenames = args;
        else
            filenames = Directory.GetFiles("images/", "*.jpg"); // Adjust this to your images folder

        // Call the ImageProcessor methods
        Console.WriteLine("Processing Inverse...");
        ImageProcessor.Inverse(filenames);

        Console.WriteLine("Processing Grayscale...");
        ImageProcessor.Grayscale(filenames);

        Console.WriteLine("Processing BlackWhite...");
        ImageProcessor.BlackWhite(filenames, 128); // Example threshold

        Console.WriteLine("Processing Thumbnail...");
        ImageProcessor.Thumbnail(filenames, 100); // Example height
    }
}
