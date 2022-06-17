

Console.WriteLine("This program takes a command-line argument N and prints a table of the powers of 2 that are less than or equal to 2 ^ N.");



int n = Convert.ToInt16(Console.ReadLine());
int i = 0;                // count from 0 to N
int powerOfTwo = 1;       // the ith power of two

// repeat until i equals n
while (i <= n)
{
    Console.WriteLine("2 ^ " + i + " = " + powerOfTwo);   // print out the power of two
    powerOfTwo = 2 * powerOfTwo;                // double to get the next one
    i = i + 1;
}



