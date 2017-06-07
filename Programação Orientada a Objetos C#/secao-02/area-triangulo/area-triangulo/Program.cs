using System;
using System.Globalization;

namespace area_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //AreaTrianguloSemOO();
            AreaTrianguloComOO();

            Console.ReadKey();
        }

        static void AreaTrianguloSemOO()
        {
            double aX, bX, cX, aY, bY, cY, areaX, areaY, pX, pY;

            aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            pX = (aX + bX + cX) / 2;
            areaX = Math.Sqrt(pX * (pX - aX) * (pX - bX) * (pX - cX));

            pY = (aY + bY + cY) / 2;
            areaY = Math.Sqrt(pY * (pY - aX) * (pY - bX) * (pY - cX));

            Console.WriteLine("Area do triangulo X: {0}", areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do triangulo Y: {0}", areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX > areaY)
                Console.WriteLine("Triangulo de maior area: X");
            else if (areaY > areaX)
                Console.WriteLine("Triangulo de maior area: Y");
            else
                Console.WriteLine("Areas iguais");
        }

        static void AreaTrianguloComOO()
        {
            Triangulo X, Y;
            X = new Triangulo();
            Y = new Triangulo();

            double areaX, areaY, pX, pY;

            X.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = X.CalcularArea();
            areaY = Y.CalcularArea();

            Console.WriteLine("Area do triangulo X: {0}", areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area do triangulo Y: {0}", areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX > areaY)
                Console.WriteLine("Triangulo de maior area: X");
            else if (areaY > areaX)
                Console.WriteLine("Triangulo de maior area: Y");
            else
                Console.WriteLine("Areas iguais");
        }
    }
}