﻿for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); // 1*2*3 = 6
}






double Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}