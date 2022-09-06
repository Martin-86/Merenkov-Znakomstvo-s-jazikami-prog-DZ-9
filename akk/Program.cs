public class Test
{
    static int Akk(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Akk(m - 1, 1);
        }
        else
        {
            return Akk(m - 1, Akk(m, n - 1));
        }
    
    } 
    public static void Main()
    {
        Console.WriteLine("Введите число m");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число n");
        int n = int.Parse(Console.ReadLine());
        Console.Write(Akk(m, n));
    }
}