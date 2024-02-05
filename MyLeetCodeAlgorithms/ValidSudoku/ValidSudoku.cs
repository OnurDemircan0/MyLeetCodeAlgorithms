/* INSTRUCTIONS

Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
*/

/* Constraints:

board.length == 9
board[i].length == 9
board[i][j] is a digit 1-9 or '.'.
*/

char[][] board = { ['8', '3', '.', '.', '7', '.', '.', '.', '.'],
                   ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
                   ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
                   ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
                   ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
                   ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
                   ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
                   ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
                   ['.', '.', '.', '.', '8', '.', '.', '7', '9'] };

char[][] board2 = { ['5', '3', '.', '.', '7', '.', '.', '.', '.'],
                    ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
                    ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
                    ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
                    ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
                    ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
                    ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
                    ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
                    ['.', '.', '.', '.', '8', '.', '.', '7', '9'] };

bool IsValidSudoku(char[][] board)
{
    HashSet<char> hashSet = new HashSet<char>();
    HashSet<char> hashSet2 = new HashSet<char>();
    HashSet<char> hashSet3 = new HashSet<char>();

    for(int i = 0; i < 9; i++)
    {
        for(int j = 0; j < 9; j++)
        {
            if (board[i][j] != '.' && !hashSet.Add(board[i][j])) return false;

            if (board[j][i] != '.' && !hashSet2.Add(board[j][i])) return false;

            //This part is for the little square parts in sudoku.
            //Formula: board[(i / 3) * 3 + (j / 3)][(j % 3) + (i % 3 * 3)]
            //Here "(i / 3) * 3" division and multiplication don't cancel each other out. 
            //For example, if i is 1, 1 / 3 = 0 and 0 * 3 = 0, but without division it would be i * 3 = 1 * 3 = 3.
            if (board[(i / 3) * 3 + (j / 3)][(j % 3) + (i % 3 * 3)] != '.' && !hashSet3.Add(board[(i / 3) * 3 + (j / 3)][(j % 3) + (i % 3 * 3)])) return false; 
        }
        hashSet.Clear();
        hashSet2.Clear();
        hashSet3.Clear();
    }

    return true;
}

Console.WriteLine(IsValidSudoku(board));
Console.WriteLine(IsValidSudoku(board2));