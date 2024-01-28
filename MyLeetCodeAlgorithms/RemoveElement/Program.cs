
int[] nums = { 3, 2, 2, 3, 4 };
int val = 3;

int RemoveElement(int[] nums, int val)
{
    Array.Sort(nums);

    int k = nums.Length;

    for(int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == val)
        {
            k--;
            nums[i] = nums[k];
        }
    }

    return k;
}

RemoveElement(nums, val);