// Step 1: Define the Sudoku board as a 2D array (puzzle)
int[][] puzzle = new int[][]
{
    new int[] {7, 3, 6, 4, 5, 2, 9, 8, 1},
    new int[] {9, 8, 3, 6, 7, 5, 4, 5, 2},
    new int[] {4, 2, 5, 1, 9, 8, 3, 6, 7},
    new int[] {3, 6, 4, 5, 2, 8, 1, 7, 9},
    new int[] {9, 5, 2, 7, 1, 4, 6, 3, 8},
    new int[] {8, 1, 7, 3, 9, 2, 4, 5, 5},
    new int[] {2, 8, 9, 1, 7, 5, 3, 4, 7},
    new int[] {6, 7, 5, 3, 4, 1, 9, 6, 9},
    new int[] {5, 4, 1, 8, 6, 9, 7, 2, 3}
};

// Step 2: Create a method that prints the Sudoku board
void PrintSudoku(int[][] board)
{
    // Loop through each row of the board
    for (int row = 0; row < board.Length; row++)
    {
        // Loop through each column in the row
        for (int col = 0; col < board[row].Length; col++)
        {
            // Print each element in the current row
            // We use Console.Write instead of Console.WriteLine to avoid breaking the line
            Console.Write(board[row][col] + " ");
        }
        // Move to the next line after printing a full row
        Console.WriteLine();
    }
}

// Step 3: Main method calls the PrintSudoku method to print the board
PrintSudoku(puzzle);  // This will print the Sudoku board to the console
