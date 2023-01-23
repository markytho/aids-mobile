using System;

namespace ArchitectArithmetic
{
  class Program
  {
   
    public static void Main(string[] args)
    {

    }
    public static string CalculateTotalCost()
    {
        string length;
        string width;
        string radius;
        string bottom;
        string height;
        double rectArea = length * width;
        double circArea = Math.PI*(Math.Pow(radius, 2));
        double trnglArea = (.5 * bottom * height);
        double totalArea = rectArea + circArea + trnglArea;
        double cost = Math.Round((totalArea * 180), 2);

        Console.Write("Input length of the rectangular portion:");
        length = Console.ReadLine();
        length = Int32.Parse(length);
        Console.Write("Input width of the rectangular portion:");
        width = Console.ReadLine();
        width = Int32.Parse(width);
        Console.Write("Input radius of circular portion:");
        radius = Console.ReadLine();
        radius = Int32.Parse(radius);
        Console.Write("Input length of the base of the triangular portion:");
        bottom = Console.ReadLine();
        bottom = Int32.Parse(bottom);
        Console.Write("Input height of the triangular portion:");
        height = Console.ReadLine();
        height = Int32.Parse(height);

        Console.WriteLine($"The area of the rectangular space is {rectArea} meters squared.");
        Console.WriteLine($"The area of the circular portion is {circArea} meters squared.");
        Console.WriteLine($"The area of the triangular portion is {trnglArea} meters squared.");
        Console.WriteLine($"The total area of the diagram is {totalArea} meters squared.");
        Console.WriteLine($"The cost of materials is {cost} pesos mexicanos.");


    }
  }
}