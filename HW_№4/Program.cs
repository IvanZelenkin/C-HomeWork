// Запрос числа N
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Четные числа от 1 до N: ");

// Цикл от 1 до N 
for (int i = 1; i <= N; i++)
{
    // Если i четное, то вывести его на экран
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}