
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