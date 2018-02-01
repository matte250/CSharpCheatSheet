using System;
using System.Speech.Synthesis;
using System.Threading;

public class Example
{
    const int MAX_X = 120;
    const int MAX_Y = 30;
    static SpeechSynthesizer ss;

    public static void Main()
    {
        Random rnd = new Random();
        int x, y, color;
        Console.CursorVisible = false;
        ss = new SpeechSynthesizer();

        do
        {
            Thread.Sleep(150);
            x = rnd.Next(0, MAX_X);
            y = rnd.Next(0, MAX_Y);
            color = rnd.Next(0, 14);

            RenderScreen(x, y, color);

        } while (!Console.KeyAvailable);

    }
    static void RenderScreen(int iX, int iY, int color)
    {
        string str = "Ernes is gay";
        ss.Speak(str);
        Console.ForegroundColor = (System.ConsoleColor)color;
        Console.SetCursorPosition(Math.Min(iX, MAX_X - str.Length), iY);
        Console.Write(str);

    }
}
