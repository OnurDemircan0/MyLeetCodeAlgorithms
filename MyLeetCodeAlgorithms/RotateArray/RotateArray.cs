/* INSTRUCTIONS

Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
*/

/* Constraints:

1 <= nums.length <= 10^5
-2^31 <= nums[i] <= 2^31 - 1
0 <= k <= 10^5
*/

int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

void Rotate(int[] nums, int k)
{
    if (k % nums.Length == 0) return;

    int currentInitialIndex = 0;
    int currentIndex = k % nums.Length;
    int carriedElement = nums[0];

    for (int i = 0; i < nums.Length; i++)
    {
        if(currentIndex != currentInitialIndex)
        {
            int nextCarriedElement = nums[currentIndex];
            nums[currentIndex] = carriedElement;
            carriedElement = nextCarriedElement;
        }
        else
        {
            nums[currentIndex] = carriedElement;

            currentInitialIndex++;
            currentIndex = currentInitialIndex;
            carriedElement = nums[currentInitialIndex];
        }

        currentIndex = (currentIndex + k) % nums.Length;
    }
}


Rotate(nums, 3);