/* INSTRUCTIONS

You are given an array prices where prices[i] is the price of a given stock on the ith day.

You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
*/

/* Constraints:

1 <= prices.length <= 10^5
0 <= prices[i] <= 10^4
*/

int[] prices = { 7, 1, 5, 3, 6, 4 };

int MaxProfit(int[] prices)
{
    int maxProfit = 0;
    int buy = prices[0];

    for(int i = 1; i < prices.Length; i++)
    {
        if (prices[i] < buy) buy = prices[i];
        else if (prices[i] - buy > maxProfit) maxProfit = prices[i] - buy;
    }

    return maxProfit;
}

Console.WriteLine(MaxProfit(prices));