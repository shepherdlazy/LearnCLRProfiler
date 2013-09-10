using System;
using System.Drawing;

public class ProfilerSample2
{
    static void Main()
    {
        int start = Environment.TickCount;
        for (int i = 0; i < 100*1000; i++)
        {
            Brush b = new SolidBrush(Color.Black);    // Brush has a finalizer
            string s = new string(' ', i % 37);

            // Do something with the brush and the string.
            // For example, draw the string with this brush - omitted...
        }
        Console.WriteLine("Program ran for {0} seconds",
                          0.001*(Environment.TickCount - start));
    }
}