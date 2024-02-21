/* INSTRUCTIONS

You are given an m x n integer matrix matrix with the following two properties:

Each row is sorted in non-decreasing order.
The first integer of each row is greater than the last integer of the previous row.
Given an integer target, return true if target is in matrix or false otherwise.

You must write a solution in O(log(m * n)) time complexity.
*/

/* Constraints:

m == matrix.length
n == matrix[i].length
1 <= m, n <= 100
-10^4 <= matrix[i][j], target <= 10^4
*/

int[][] matrix = [[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]];
int target = 3;

bool SearchMatrix(int[][] matrix, int target)
{
    return BinarySearch2D(matrix, 0, matrix.Length - 1, 0, matrix[0].Length - 1, target);
}

//Recursive Function
//leftX to rightX is the possible indexes for the target in the first dimension of the matrix.
//leftY to rightY is the possible indexes for the target in the second dimension of the matrix.
bool BinarySearch2D(int[][] matrix, int leftX, int rightX, int leftY, int rightY, int target)
{
    //If this condition is true that means the target is not where it should be, so return false.
    if (leftX > rightX || leftY > rightY) return false;

    int halfX = (leftX + rightX) / 2; 
    int halfY = (leftY + rightY) / 2;

    if (matrix[halfX][halfY] == target) return true;


    if (matrix[halfX][halfY] > target)
    {
        //If the target should be in the current x dimension, do this.
        if (matrix[halfX][0] <= target && matrix[halfX][matrix[0].Length - 1] >= target) return BinarySearch2D(matrix, halfX, halfX, leftY, halfY - 1, target);

        //If the target shouldn't be in the current x dimension, search for x dimension.
        return BinarySearch2D(matrix, leftX, halfX - 1, leftY, rightY, target);
    }
    else
    {
        //If the target should be in the current x dimension, do this.
        if (matrix[halfX][0] <= target && matrix[halfX][matrix[0].Length - 1] >= target) return BinarySearch2D(matrix, halfX, halfX, halfY + 1, rightY, target);

        //If the target shouldn't be in the current x dimension, search for x dimension.
        return BinarySearch2D(matrix, halfX + 1, rightX, leftY, rightY, target);
    }
}

Console.WriteLine(SearchMatrix(matrix, target));