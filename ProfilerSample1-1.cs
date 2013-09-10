using System;
using System.Text;
public class ProfilerSample1
{
    static void Main (string[] args)
    {
        int start = Environment.TickCount;
        for (int i = 0; i < 1000; i++)
        {
            StringBuilder s = new StringBuilder();
                for (int j = 0; j < 100; j++)
                {
                    s.Append("Outer index = ");
                    s.Append(i);
                    s.Append(" Inner index = ");
                    s.Append(j);
                    s.Append(" ");
                }
        }
        Console.WriteLine("Program ran for {0} seconds", 
   0.001*(Environment.TickCount - start));
    }
}