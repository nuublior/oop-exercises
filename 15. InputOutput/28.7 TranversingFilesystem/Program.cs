using System;
using System.Collections.Generic;
using System.IO;

namespace FilesystemTraversal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Define the path to start searching
            string rootPath = @"C:\Users\andre\Desktop\OOPE\oop-exercises\15. InputOutput\28.6 CSVFiles";

            // Call the method to get CSV files and print each path
            List<string> csvFiles = GetCsvFiles(rootPath);
            foreach (string file in csvFiles)
            {
                Console.WriteLine(file);
            }
        }

        /// <summary>
        /// Recursively finds all .csv files in a directory and its subdirectories.
        /// </summary>
        /// <param name="path">The starting directory path.</param>
        /// <returns>List of paths to .csv files.</returns>
        public static List<string> GetCsvFiles(string path)
        {
            List<string> csvFiles = new List<string>();

            try
            {
                // Get all .csv files in the current directory
                string[] files = Directory.GetFiles(path, "*.csv", SearchOption.AllDirectories);
                csvFiles.AddRange(files);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Access denied to {path}: {ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Directory not found: {ex.Message}");
            }

            return csvFiles;
        }
    }
}