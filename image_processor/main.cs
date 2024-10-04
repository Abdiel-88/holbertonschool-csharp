using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] filenames;

        // Check if filenames were passed as arguments
        if (args.Length > 0)
            filenames = args;
        else
            // Get all JPEG files in the 'images/' folder
            filenames = Directory.GetFiles("images/", "*.jpg");

        // Call the Inverse method to process the images
        ImageProcessor.Inverse(filenames);
    }
}
