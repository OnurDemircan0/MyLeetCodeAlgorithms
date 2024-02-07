//*****THIS CODE DOESN'T WORK HERE. IT'S FOR COPY PASTE TO THE "Insert Delete GetRandom O(1)" ALGORITHM IN LEETCODE WEBSITE*****

/* INSTRUCTIONS

Implement the RandomizedSet class:

RandomizedSet() Initializes the RandomizedSet object.
bool insert(int val) Inserts an item val into the set if not present. Returns true if the item was not present, false otherwise.
bool remove(int val) Removes an item val from the set if present. Returns true if the item was present, false otherwise.
int getRandom() Returns a random element from the current set of elements (it's guaranteed that at least one element exists when this method is called). Each element must have the same probability of being returned.
You must implement the functions of the class such that each function works in average O(1) time complexity.
*/

/* Constraints:

-2^31 <= val <= 2^31 - 1
At most 2 * 10^5 calls will be made to insert, remove, and getRandom.
There will be at least one element in the data structure when getRandom is called.
*/

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */

//*****THIS CODE DOESN'T WORK HERE. IT'S FOR COPY PASTE TO THE "Insert Delete GetRandom O(1)" ALGORITHM IN LEETCODE WEBSITE*****
public class RandomizedSet
{
    List<int> nums = new List<int>();
    Random random = new Random(); //Declare Random here instead of inside of the function because it increases the performance.

    public RandomizedSet()
    {

    }

    public bool Insert(int val)
    {
        if (!nums.Contains(val))
        {
            nums.Add(val);
            return true;
        }
        else return false;
    }

    public bool Remove(int val)
    {
        return nums.Remove(val);
    }

    public int GetRandom()
    {
        int randomNumber = random.Next(0, nums.Count);

        return nums[randomNumber];
    }
}

