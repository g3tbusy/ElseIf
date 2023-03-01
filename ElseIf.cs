internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число A");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число C");
        double c = Convert.ToInt32(Console.ReadLine());
        double d = b * b - 4 * a * c;
        double d2 = Math.Sqrt(d);
        double x1 = 0.1;
        double x2 = 0.1;

        Console.WriteLine($"Дискриминант = {d}");

        if (d < 0)
            Console.WriteLine("Корней нет.");

        else if (d == 0)
        {
            x1 = b / -1 / (2 * a);
            Console.WriteLine($"Ответ: x = {x1}");
        }

        else if (d > 0)
        {
            x1 = (-b + d2) / (2 * a);
            x2 = (-b - d2) / (2 * a);
            Console.WriteLine($"Ответ: x1 = {x1}, x2 = {x2}");
        }

    }
}