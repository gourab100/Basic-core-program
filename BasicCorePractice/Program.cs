
Console.WriteLine("Flip Coin and print percentage of Heads and Tails");

int n, h_cnt = 0, t_cnt = 0;
double heads, tails;
// INPUT DATA
Console.WriteLine("enter no. of times you want to flip the coin: ");
n = Convert.ToInt16(Console.ReadLine());

// COMPUTATION
for (int j = 0; j < n; j++)
{
    Random r = new Random();
    double random = r.Next(2);
    if (random < 0.5)
        t_cnt++;
    else
        h_cnt++;
}

heads = h_cnt / (double)n * 100;
tails = t_cnt / (double)n * 100;

Console.WriteLine("Percentage of heads: " + heads + "%");
Console.WriteLine("Percentage of tails: " + tails + "%");

