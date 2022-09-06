Console.WriteLine("Введите число 1");
int a = Convert.ToInt32(Console.ReadLine());
int aa = a;

Console.WriteLine("Введите число 2, которое больше числа 1");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int c = 0;
if(a < b)
{
    while(a <= b)
    {
        c = c + a;
        a++;
    }
    Console.Write("Сумма натуральных чисел от " + aa + " до " + b + " = " + c);
}
else
{
Console.WriteLine("Ошибка! Введите другие числа ");
}
