/* INSTRUCTIONS

You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
*/

/* Constraints:

nums1.length == m + n
nums2.length == n
0 <= m, n <= 200
1 <= m + n <= 200
-109 <= nums1[i], nums2[j] <= 109
*/

int[] nums1 = { 4, 5, 6, 0, 0, 0 };
int[] nums2 = { 1, 2, 3 };

void Merge(int[] nums1, int m, int[] nums2, int n)
{
    if (m == 0)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[i] = nums2[i];
        }
        return;
    }

    int currentIndex1 = m - 1;
    int currentIndex2 = n - 1;

    int changeIndex = m + n - 1;

    while (currentIndex2 >= 0)
    {
        if (currentIndex1 < 0)
        {
            nums1[changeIndex] = nums2[currentIndex2];
            currentIndex2--;
            changeIndex--;
            continue;
        }

        if (nums2[currentIndex2] >= nums1[currentIndex1])
        {
            nums1[changeIndex] = nums2[currentIndex2];

            currentIndex2--;
        }
        else
        {
            nums1[changeIndex] = nums1[currentIndex1];
            currentIndex1--;
        }

        changeIndex--;
    }
}


Merge(nums1, nums1.Length - nums2.Length, nums2, nums2.Length);