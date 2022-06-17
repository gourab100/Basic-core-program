
Console.WriteLine("Computes the prime factorization of N using brute force.");



int n = Convert.ToInt32(Console.ReadLine());
while (n % 2 == 0)
{
    Console.Write(2 + " ");
    n /= 2;
}


for (int i = 3; i <= Math.Sqrt(n); i += 2)
{
    // While i divides n, print i and divide n
    while (n % i == 0)
    {
        Console.Write(i + " ");
        n /= i;
    }
}


if (n > 2)
{
    Console.Write(n);
}

