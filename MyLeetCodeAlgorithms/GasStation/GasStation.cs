/* INSTRUCTIONS

There are n gas stations along a circular route, where the amount of gas at the ith station is gas[i].

You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from the ith station to its next (i + 1)th station. You begin the journey with an empty tank at one of the gas stations.

Given two integer arrays gas and cost, return the starting gas station's index if you can travel around the circuit once in the clockwise direction, otherwise return -1. If there exists a solution, it is guaranteed to be unique
*/

/* Constraints:

n == gas.length == cost.length
1 <= n <= 10^5
0 <= gas[i], cost[i] <= 10^4
*/

int[] gas = { 1, 2, 3, 4, 5 };
int[] cost = { 3, 4, 5, 1, 2 };

int CanCompleteCircuit(int[] gas, int[] cost)
{
    int sum = 0;
    int maxSum = -1; //We assigned -1 as a default value because we want sum to be greater than maxSum if sum is 0.
    int startingIndex = -1; //Doesn't matter what we assign as a default value.

    //We look the arrays right to left because the circuit goes left to right.
    for (int i = gas.Length - 1; i >= 0; i--)
    {
        sum += gas[i] - cost[i];
        if (sum > maxSum) //Starting index will be the index where maxSum is.
        {
            maxSum = sum;
            startingIndex = i;
        }
    }

    //If sum is greater than 0, that means circuit can be completed, otherwise can't.
    if (sum >= 0) return startingIndex;
    else return -1;
}

Console.WriteLine(CanCompleteCircuit(gas, cost));