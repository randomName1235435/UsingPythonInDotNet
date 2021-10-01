using IronPython.Hosting;
using System;

namespace UsingPythonInDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic pyhthon = Python.CreateRuntime().UseFile("./multiplier.py");
            var multiplier = pyhthon.multiplier;

            int result = multiplier.calculate(10,10);

            Console.WriteLine($"result {result}");
        }
    }
}
