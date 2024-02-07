/* INSTRUCTIONS

Given an array of integers citations where citations[i] is the number of citations a researcher received for their ith paper, return the researcher's h-index.

According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.
*/

/* Constraints:

n == citations.length
1 <= n <= 5000
0 <= citations[i] <= 1000
*/

int[] citations = { 3, 0, 6, 1, 5 };

int HIndex(int[] citations)
{
    List<int> remainedCitations = new List<int>(citations); //Turn citations array to a list.

    int h = 0; //h index, result.
    int count = 0; //h index paper count

    int i = 0;

    while(i < remainedCitations.Count)
    {
        //If there are more citations on ith paper than h index, increase count.
        if (remainedCitations[i] > h)
        {
            count++;
            i++;

            //If count is equal to h + 1, that means h index is more than the current value, so increase it.
            //Reset count and i variables, and do the same process again.
            if (count == h + 1)
            {
                h++;
                count = 0;
                i = 0;
            }
        }
        else //If there are less citations on ith paper than h index, we don't need to look at it, so remove it for the performance.
        {
            remainedCitations.RemoveAt(i);
        }
    }

    return h;
}

Console.WriteLine(HIndex(citations));