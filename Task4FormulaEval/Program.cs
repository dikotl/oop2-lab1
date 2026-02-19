class Program
{
    static void Main()
    {
        Func<int, double>[] formulas = [
            x => Math.Sqrt(Math.Abs(x)),
            x => x*x*x,
            x => x + 3.5,
        ];

        Hello();

        while (true)
        {
            // Parse the input first.
            int n, x;
            Prompt();
            try
            {
                var input = Console
                    .ReadLine()!
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                n = input[0];
                x = input[1];
            }
            catch (Exception ex)
            {
                Exit($"Неправильний формат введених даних ({ex.Message})");
                return;
            }

            // Compute the formula.
            try
            {
                Console.WriteLine(formulas[n](x));
            }
            catch (IndexOutOfRangeException)
            {
                Exit($"Невідома формула під індексом {n}");
                return;
            }
            catch (Exception ex)
            {
                Exit($"Сталася помилка ({ex.Message})");
                return;
            }
        }

        static void Hello()
        {
            ConsoleColor reset = Console.ForegroundColor;

            Console.Write("Введіть запит в форматі ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("N x");
            Console.ForegroundColor = reset;
            Console.Write(", де ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("N");
            Console.ForegroundColor = reset;
            Console.Write(" - індекс формули; ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("x");
            Console.ForegroundColor = reset;
            Console.WriteLine("""
             - аргумент:

                0 -> sqrt(abs(x))
                1 -> x^3
                2 -> x + 3.5

            """
            );
        }

        static void Prompt()
        {
            ConsoleColor reset = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("> ");
            Console.ForegroundColor = reset;
        }

        static void Exit(string error)
        {
            Console.WriteLine($"{error}\nА я попереджував... (натисніть будь-яку клавішу для остаточного виходу з програми)");
            Console.ReadKey();
        }
    }
}
