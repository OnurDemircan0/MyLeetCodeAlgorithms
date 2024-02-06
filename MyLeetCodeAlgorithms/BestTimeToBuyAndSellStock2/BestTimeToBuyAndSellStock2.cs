﻿/* INSTRUCTIONS

You are given an integer array prices where prices[i] is the price of a given stock on the ith day.

On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.

Find and return the maximum profit you can achieve.
*/

/* Constraints:

1 <= prices.length <= 3 * 10^4
0 <= prices[i] <= 10^4
*/

int[] prices = { 7, 1, 5, 3, 6, 4 };

int MaxProfit(int[] prices)
{
    int maxProfit = 0;

    for (int i = 1; i < prices.Length; i++)
    {
        if (prices[i] > prices[i - 1]) maxProfit += prices[i] - prices[i - 1];
    }

    return maxProfit;
}

Console.WriteLine(MaxProfit(prices));