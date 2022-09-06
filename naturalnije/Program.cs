Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2, которое больше числа 1");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int c = 0;
int n = 0;
if(a < b)
{
    while(c < b)
    {
        c = a + n;
        Console.Write(c + " ");
        n++;
    }
}
else
{
Console.WriteLine("Ошибка! Введите другие числа ");
}
