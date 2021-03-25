using System;

namespace GrausFC
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double GrauF;
			double GrauC;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Conversão de °F em °C");
			Console.WriteLine();
			Console.ResetColor();
			
			Console.Write("Insira o valor em °F: ");
			GrauF = Convert.ToDouble(Console.ReadLine());
			
			GrauC = (GrauF - 32) / 1.8;
			Console.WriteLine(GrauF + "°F equivalem a " + GrauC + "°C");
        }
    }
}