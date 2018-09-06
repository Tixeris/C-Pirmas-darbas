using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle kvadratas1 = new Rectangle(5, 10, 0, 0);
            Console.WriteLine("Plotas: " + kvadratas1.GetPlotas());
            Console.WriteLine("Perimetras: " + kvadratas1.GetPerimeter());
            Console.WriteLine("Istrizaine: " + kvadratas1.GetLine());
            Console.WriteLine("Istrizaines vidurio taskas: " + "(" + kvadratas1.GetCoordinates() + ";" + kvadratas1.GetCoordinates1() + ")");
            Console.ReadLine();
        }
    }

}

