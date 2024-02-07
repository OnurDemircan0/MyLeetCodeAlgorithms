/* INSTRUCTIONS

You are given a 0-indexed array of integers nums of length n. You are initially positioned at nums[0].

Each element nums[i] represents the maximum length of a forward jump from index i. In other words, if you are at nums[i], you can jump to any nums[i + j] where:

0 <= j <= nums[i] and
i + j < n
Return the minimum number of jumps to reach nums[n - 1]. The test cases are generated such that you can reach nums[n - 1].
*/

/* Constraints:

1 <= nums.length <= 10^4
0 <= nums[i] <= 1000
It's guaranteed that you can reach nums[n - 1].
*/

int[] nums = { 2, 3, 0, 1, 4 };

int Jump(int[] nums)
{
    int jumpCounts = 0;
    int confirmedJump = nums[0]; //Confirmed jump is the jump point that we can jump.
    int unConfirmedJump = nums[0]; //Unconfirmed jump is for checking the biggest jump.

    for (int i = 1; i < nums.Length; i++)
    {
        confirmedJump--;
        unConfirmedJump--;

        //If nums[i] bigger than unconfirmed jump it will be the unconfirmed jump because we need the biggest.
        if (nums[i] > unConfirmedJump) 
        {
            unConfirmedJump = nums[i];
        }

        //If confirmed jump equals to 0, that means we checked all the possibilities for the biggest unconfirmed jump,
        //so the confirmed jump will be the unconfirmed jump.
        //Also, we need to do this if i equals nums.Length - 1, even if confirmed jump is not equal to 0, because at the end there will be a jump that didn't happen yet if confirmed jump is not equal to 0.
        //We're sure that there is a jump here, so we increase the jump counts.
        if(confirmedJump == 0 || i == nums.Length - 1)
        {
            confirmedJump = unConfirmedJump;
            jumpCounts++;
        }
    }

    return jumpCounts;
}

Console.WriteLine(Jump(nums));