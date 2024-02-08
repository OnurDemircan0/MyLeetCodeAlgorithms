/* INSTRUCTIONS

Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.
*/

/* Constraints:

2 <= nums.length <= 10^5
-30 <= nums[i] <= 30
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
*/

int[] nums = { -1, 1, 0, -3, 3 };

int[] ProductExceptSelf(int[] nums)
{
    int[] answer = new int[nums.Length];

    //left product is the product of the elements in nums, right to left.
    //right product is the product of the elements in nums, left to right.
    int leftProduct = 1, rightProduct = 1; 

    //answer[i] is the product of the left side of the element, not itself.
    for (int i = 0; i < nums.Length; i++)
    {
        answer[i] = rightProduct;
        rightProduct *= nums[i];
    }

    //answer[i] has value, the product of the left side of the element, so we multiply it by the product of the right side of the element.
    //Right side also doesn't include itself.
    for(int i = nums.Length - 1; i >= 0; i--)
    {
        answer[i] *= leftProduct;
        leftProduct *= nums[i];
    }

    return answer;
}

Console.WriteLine(ProductExceptSelf(nums));