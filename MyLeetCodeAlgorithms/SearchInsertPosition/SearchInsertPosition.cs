/* INSTRUCTIONS

Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.
*/

/* Constraints:

1 <= nums.length <= 10^4
-10^4 <= nums[i] <= 10^4
nums contains distinct values sorted in ascending order.
-10^4 <= target <= 10^4
*/

int[] nums = { 1, 3, 5, 6 };
int target = 7;

int SearchInsert(int[] nums, int target)
{
    return BinarySearch(nums, 0, nums.Length - 1, target);
}

//Possible target indexes are left to right in nums.
int BinarySearch(int[] nums, int left, int right, int target)
{
    if (left > right) return left; //if left greater than right that means the target doesn't exist but if it existed, the index of it would be the left value.

    int half = (right + left) / 2; //Half of the left and right indexes.

    if (nums[half] == target) return half;
    if (nums[half] > target) return BinarySearch(nums, left, half - 1, target); //If target is less than nums[half], we must look at the left side. So forget the right half, and the right value is half - 1 now.
    return BinarySearch(nums, half + 1, right, target); //If target is greater than nums[half], we must look at the right side. So forget the left half, and the left value is half + 1 now.
}

Console.WriteLine(SearchInsert(nums, target));