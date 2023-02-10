System.Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число");
int C = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (A > B)
{
    max = A;
}
else if (B > A)
{
    max = B;
}
if (max > C)
{
    System.Console.WriteLine("Максимальное число = " + max);
}
else if (C > max)
{
    max = C;
    System.Console.WriteLine("Максимальное число = " + max);
}