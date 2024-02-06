/* INSTRUCTIONS

You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

Return true if you can reach the last index, or false otherwise.
*/

/* Constraints:

1 <= nums.length <= 10^4
0 <= nums[i] <= 10^5
*/

int[] nums = { 5, 4, 0, 2, 0, 1, 0, 1, 0 };

bool CanJump(int[] nums)
{
    if(nums.Length == 1) return true;

    int jumpNeeded = 0;
    bool zeroEncountered = false;

    for (int i = nums.Length - 2; i >= 0; i--) //Since we have to reach the last index we don't have to check the last index, so we begin with the index before the last index.
    {
        if (zeroEncountered)
        {
            if (nums[i] >= jumpNeeded) zeroEncountered = false;
            else jumpNeeded++;
        }
        else if (!zeroEncountered && nums[i] == 0) //If we couldn't jump over the zero we encountered first, we don't look the other zeros. 
        {
            jumpNeeded = 2;
            zeroEncountered = true;
        }
    }
    //zeroEncountered = true means we couldn't jump over a zero, and can't reach the last index because of that.
    if(zeroEncountered) return false;
    else return true;
}

Console.WriteLine(CanJump(nums));