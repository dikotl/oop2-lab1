using Stopwatch = System.Diagnostics.Stopwatch;

namespace Task1;

class Timer
{
    public Timer(TimeSpan delay, Action callback)
    {
        var t = new Thread(() =>
        {
            while (true)
            {
                callback();
                Thread.Sleep(delay);
            }
        });
        t.IsBackground = true;
        t.Start();
    }
}

class Program
{
    static void Main()
    {
        int n = 0;
        _ = new Timer(TimeSpan.FromMilliseconds(100), () => { Console.WriteLine(++n); });

        Thread.Sleep(TimeSpan.FromSeconds(5));
    }
}
