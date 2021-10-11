using System;

namespace Consol
{
    class Converter
    {
        public double usd;
        public double eur;

        public Converter(double usd, double eur)
        {
            this.usd = usd;
            this.eur = eur;
        }

        public double FromHrToEur(double hr)
        {
            return hr / eur;
        }

        public double FromHrToUsd(double hr)
        {
            return hr / usd;
        }

        public double FromEurToHr(double hr)
        {
            return eur * hr;
        }

        public double FromUsdToHr(double hr)
        {
            return usd * hr;
        }
        public double FromUsdToEur(double hr)
        {
            return (hr * usd) / eur;
        }
        public double FromEurToUsd(double hr)
        {
            return (hr * eur) / usd;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Converter first = new Converter(26.37, 30.52);
            Console.WriteLine("Перевести з: hrn, eur, usd.");
            string a = Console.ReadLine();
            Console.WriteLine("Конвертувати в: hrn, eur, usd.");
            string b = Console.ReadLine();
            Console.WriteLine("Сума для переводу");
            double c;
            c = double.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine(c + " " + a + " = " + c + " " + a);
            }
            if (a == "eur")
            {
                if (b == "hrn") Console.WriteLine(c + " " + a + " = " + first.FromEurToHr(c) + " " + b);
                if (b == "usd") Console.WriteLine(c + " " + a + " = " + first.FromEurToUsd(c) + " " + b);
            }

            if (a == "hrn")
            {
                if (b == "usd") Console.WriteLine(c + " " + a + " = " + first.FromHrToUsd(c) + " " + b);
                if (b == "eur") Console.WriteLine(c + " " + a + " = " + first.FromHrToEur(c) + " " + b);
            }

            if (a == "usd")
            {
                if (b == "hrn") Console.WriteLine(c + " " + a + " = " + first.FromUsdToHr(c) + " " + b);
                if (b == "eur") Console.WriteLine(c + " " + a + " = " + first.FromUsdToEur(c) + " " + b);
            }
        }
    }
}