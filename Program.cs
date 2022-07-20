// declare integer variable starting at zero
//int num = 0;

// for loop with variable that starts at zero and increments by 1 every iteration until 100
// if statement that prints each num but prints FIZZ is num is divisible by 3, Buzz is num is divisible by 5 and FIZZBUZZ if num divisible by both
for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

