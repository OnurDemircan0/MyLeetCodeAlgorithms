/* INSTRUCTIONS

Implement pow(x, n), which calculates x raised to the power n (i.e., x^n).
*/

/* Constraints:

-100.0 < x < 100.0
-2^31 <= n <= 2^31-1
n is an integer.
Either x is not zero or n > 0.
-10^4 <= x^n <= 10^4
*/

double x = 2.0;
int n = 10;

double MyPow(double x, int n)
{
    double result = 1;

    //If n is negative, make n positive and make x fractional.
    if(n < 0)
    {
        n = -n;
        x = 1 / x;
    }

    //Do until n is 0.
    while(n != 0)
    {
        //This is a bitwise operation. (n & 1) means that return 1 if the last bit of n in binary system is 1.
        //If the last bit is 1 that means it is an odd number.
        //If n is odd, multiply result by x.
        if((n & 1) == 1)
        {
            result *= x;
        }

        //Every loop we multiply x by x. For example it is like x^1, x^2, x^4, x^8, x^16 and so on.
        x *= x;

        //This is a bitwise operation. n >> 1 means that shift the bits of n to the right side.
        //For example, 00101101 --> 00010110
        //Turn n to unsigned integer value for shifting because signed bit of an integer can cause unexpected outputs.
        //Even though in the beginning of this function we make n positive if it is negative, we must use uint because if n is the minimum value of int -2,147,483,648, we can't make it positive because the maximum value of int is 2,147,483,647. So when we use uint it can be 2,147,483,648 because the maximum number of uint is 4,294,967,295.
        //By this operation, we divide n by 2 and if there was a remaining we discard it.
        n = (int)((uint)n >> 1);
    }

    return result;
}

Console.WriteLine(MyPow(x, n));