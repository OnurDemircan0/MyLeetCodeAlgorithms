/* INSTRUCTIONS

You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
*/

/* Constraints:

1 <= n <= 45
*/

int n = 4;

//This works with fibonacci numbers.
int ClimbStairs(int n)
{
    int number1 = 1; //Fibonacci's first element.
    int number2 = 1; //Fibonacci's second element.

    //Finds the wanted fibonacci element.
    for (int i = 1; i < n; i++)
    {
        int previousNumber = number2;
        number2 += number1;
        number1 = previousNumber;
    }

    return number2;
}



Console.WriteLine(ClimbStairs(n));