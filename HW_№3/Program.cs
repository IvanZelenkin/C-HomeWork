System.Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine(n + " четное");
}
else
{
    Console.WriteLine(n + " нечетное");
}