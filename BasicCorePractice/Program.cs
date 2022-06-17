
 Console.WriteLine("Program to Swap Two Numbers");

int a = Convert.ToInt16(Console.ReadLine());
int b = Convert.ToInt16(Console.ReadLine()); ;
Console.WriteLine("Before swap a= " + a + " b= " + b);
a = a + b;
b = a - b;
a = a - b;
Console.Write("After swap a= " + a + " b= " + b);
