// Define a 2D array representing the Sudoku board (9x9 grid)
int[][] puzzle = new int[][]
{
    // Each row in the Sudoku board
    new int[] {7, 3, 6, 4, 5, 2, 9, 8, 1},
    new int[] {1, 9, 8, 6, 3, 7, 4, 5, 2},
    new int[] {4, 2, 5, 8, 9, 1, 7, 3, 6},
    new int[] {9, 5, 7, 1, 4, 6, 8, 2, 3},
    new int[] {6, 8, 3, 5, 2, 9, 1, 4, 7},
    new int[] {2, 4, 1, 7, 8, 3, 6, 9, 5},
    new int[] {3, 6, 9, 2, 7, 8, 5, 1, 4},
    new int[] {8, 7, 2, 9, 1, 5, 3, 6, 9},
    new int[] {5, 4, 1, 8, 6, 9, 2, 7, 3}
};

// A boolean variable to track if the puzzle is correct or not
bool correct = true;

// Row Check: Loop through each row
for (int y = 0; y < 9; y++) // y represents the row index
{
    // Compare every element in the row with the rest of the elements in the same row
    for (int x = 0; x < 9; x++) // x represents the current column element
    {
        for (int x2 = x + 1; x2 < 9; x2++) // x2 is used to compare each element with the next one
        {
            // If any two numbers in the same row are the same, set "correct" to false
            if (puzzle[y][x] == puzzle[y][x2])
            {
                correct = false; // The Sudoku board is invalid because of duplicate in a row
            }
        }
    }
}

// Column Check: Loop through each column
for (int x = 0; x < 9; x++) // x represents the column index
{
    // Compare every element in the column with the rest of the elements in the same column
    for (int y = 0; y < 9; y++) // y represents the current row element
    {
        for (int y2 = y + 1; y2 < 9; y2++) // y2 is used to compare each element with the next one
        {
            // If any two numbers in the same column are the same, set "correct" to false
            if (puzzle[y][x] == puzzle[y2][x])
            {
                correct = false; // The Sudoku board is invalid because of duplicate in a column
            }
        }
    }
}

// Group (3x3 subgrid) Check: Loop through the 9 subgrids (3x3 blocks)
for (int x = 0; x < 3; x++) // Outer loop for the 3 subgrids horizontally
{
    for (int y = 0; y < 3; y++) // Inner loop for the 3 subgrids vertically
    {
        // Loop inside each 3x3 grid
        for (int i = 0; i < 9; i++) // i represents the 9 elements inside the 3x3 grid
        {
            int ix = i % 3; // ix is the column inside the 3x3 grid (0, 1, or 2)
            int iy = i / 3; // iy is the row inside the 3x3 grid (0, 1, or 2)
            for (int i2 = i + 1; i2 < 9; i2++) // i2 is used to compare elements within the grid
            {
                int ix2 = i2 % 3; // ix2 is the column of the next element in the 3x3 grid
                int iy2 = i2 / 3; // iy2 is the row of the next element in the 3x3 grid

                // If any two numbers in the same 3x3 grid are the same, set "correct" to false
                if (puzzle[y * 3 + iy][x * 3 + ix] == puzzle[y * 3 + iy2][x * 3 + ix2])
                {
                    correct = false; // The Sudoku board is invalid because of duplicate in a 3x3 grid
                }
            }
        }
    }
}

// Output whether the puzzle is valid or not
Console.WriteLine("Puzzle is " + (correct ? "correct" : "incorrect")); // Ternary operator to print "correct" or "incorrect"
