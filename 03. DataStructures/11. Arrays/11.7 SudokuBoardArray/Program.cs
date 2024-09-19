// Define the 9x9 Sudoku board with a 2D array
int[,] sudokuBoard = new int[9, 9];

// Initialize the board (this is just an example, not a real puzzle)
sudokuBoard[0, 0] = 5; // Top-left corner
sudokuBoard[0, 1] = 3;
sudokuBoard[1, 0] = 6;
sudokuBoard[4, 4] = 8; // Center of the board
sudokuBoard[8, 8] = 9; // Bottom-right corner

// Print the Sudoku board to the console
for (int row = 0; row < 9; row++) 
{
    for (int col = 0; col < 9; col++) 
    {
        Console.Write(sudokuBoard[row, col] + " ");
    }
    Console.WriteLine(); // Move to the next line after each row
}
