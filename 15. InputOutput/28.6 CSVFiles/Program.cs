using System;
using System.IO;

namespace MatrixApp
{
    public class Matrix
    {
        // Attribute: 2D array for storing matrix data
        public double[][] data;

        // Constructor 1: Takes a filename and loads data from it
        public Matrix(string filename)
        {
            LoadDataFromFile(filename);
        }

        // Constructor 2: Takes rows and columns, initializes data with zeroes
        public Matrix(int rows, int columns)
        {
            data = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                data[i] = new double[columns];
                for (int j = 0; j < columns; j++)
                {
                    data[i][j] = 0.0; // Initialize all cells with 0
                }
            }
        }

        // Method to load data from a file into the 'data' attribute
        private void LoadDataFromFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            data = new double[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                data[i] = new double[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    data[i][j] = double.Parse(values[j]);
                }
            }
        }

        // Method to save the current state of 'data' to a file
        public void Save(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 0; i < data.Length; i++)
                {
                    writer.WriteLine(string.Join(",", data[i]));
                }
            }
        }

        // Getter for a specific cell in the matrix
        public double GetValue(int row, int column)
        {
            return data[row][column];
        }

        // Setter for a specific cell in the matrix
        public void SetValue(int row, int column, double value)
        {
            data[row][column] = value;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Specify the directory path
            string directoryPath = @"C:\Users\andre\Desktop\OOPE\oop-exercises\15. InputOutput\28.6 CSVFiles\";

            // Step 1: Create a 4x6 matrix with zero values
            Matrix matrix = new Matrix(4, 6);

            // Save this 4x6 zero matrix to a file in the specified directory
            string initialFile = Path.Combine(directoryPath, "matrix.csv");
            matrix.Save(initialFile);
            Console.WriteLine($"Saved initial 4x6 matrix with zeroes to {initialFile}");

            // Step 2: Load the saved matrix, set diagonal cells to 1, and save to a new file
            Matrix diagonalMatrix = new Matrix(initialFile);
            for (int i = 0; i < diagonalMatrix.data.Length && i < diagonalMatrix.data[i].Length; i++)
            {
                diagonalMatrix.SetValue(i, i, 1.0); // Set diagonal to 1
            }

            string diagonalFile = Path.Combine(directoryPath, "diagonal_matrix.csv");
            diagonalMatrix.Save(diagonalFile);
            Console.WriteLine($"Saved diagonal matrix to {diagonalFile}");
        }
    }
}
