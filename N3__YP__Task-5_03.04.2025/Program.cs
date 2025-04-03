namespace N3__YP__Task_5_03._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            int s = 1, t = 1, d = -1;
            for (int i = 2; i <= n; i++)
            {
                s = 2 * s + i;
                t += s;
                d = s > 100 ? i : d;
            }
            Console.WriteLine($"T({n}) = {t}");
            Console.WriteLine(d > 0 ? $"S > 100 на {d}-й день" : "S <= 100 всегда");
        }
    }
}
