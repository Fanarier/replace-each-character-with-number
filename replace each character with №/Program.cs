//22-ИСП-3/2 Плотников Кирилл
//В заданной строке заменить каждый символ «№» строкой «номер по порядку».
//Я заменил все "#" вместо "№" потому что так визуально удобнее.

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();
        string output = ReplaceNumberInString(input);
        Console.WriteLine(output);
    }

    static string ReplaceNumberInString(string input)
    {
        int counter = 0;
        string output = "";

        Thread thread = new Thread(() =>
        {
            foreach (char c in input)
            {
                if (c == '#')
                {
                    counter++;
                    output += counter.ToString();
                }
                else
                {
                    output += c;
                }
            }
        });

        thread.Start(); 
        thread.Join();  

        return output;
    }
}