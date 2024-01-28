
int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 1) return 1;

    int k = nums.Length;
    int currentNumber = nums[0];

    for(int i = 1; i < nums.Length; i++)
    {
        if (nums[i] == currentNumber)
        {
            nums[i] = int.MaxValue;
            k--;
        }
        else currentNumber = nums[i];
    }

    Array.Sort(nums);

    return k;
}

RemoveDuplicates(nums);