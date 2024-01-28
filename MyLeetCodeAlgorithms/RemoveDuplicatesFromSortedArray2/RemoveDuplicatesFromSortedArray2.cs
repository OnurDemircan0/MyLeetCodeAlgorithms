/* INSTRUCTIONS

Given an integer array nums sorted in non-decreasing order, remove some duplicates in-place such that each unique element appears at most twice. The relative order of the elements should be kept the same.

Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.

Return k after placing the final result in the first k slots of nums.

Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.
*/

/* Constraints:

1 <= nums.length <= 3 * 104
-104 <= nums[i] <= 104
nums is sorted in non-decreasing order.
*/

int[] nums = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 1) return 1;

    int k = nums.Length;
    int currentNumber = nums[0];
    int encounter = 1;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == currentNumber)
        {
            encounter++;

            if (encounter > 2)
            {
                nums[i] = int.MaxValue;
                k--;
            }
        }
        else
        {
            currentNumber = nums[i];
            encounter = 1;
        }
    }

    Array.Sort(nums);

    return k;
}


RemoveDuplicates(nums);