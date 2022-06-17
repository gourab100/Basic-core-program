
 Console.WriteLine("Prints the Nth harmonic number: 1/1 + 1/2 + ... + 1/N");

int i, n;
double s = 0.0;

Console.Write("\n\n");
Console.Write("Calculate the harmonic series and their sum:\n");
Console.Write("----------------------------------------------");
Console.Write("\n\n");

Console.Write("Input the number of terms : ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("\n\n");
if (n != 0)
{
    for (i = 1; i <= n; i++)
    {
        Console.Write("1/{0} + ", i);

    }

}