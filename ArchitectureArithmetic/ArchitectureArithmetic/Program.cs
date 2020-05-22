using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("What monument would you like to work with?\n" +
                "- Pantheon\n" +
                "- Taj Mahal\n" +
                "- Great Mosque of Mecca\n" +
                "> ");
            CalculateCostOf(Console.ReadLine());
        }


        static void CalculateCostOf(string monumnet)
        {
            double total_area;
            double cost_of_material = 180;

            switch(monumnet.ToLower())
            {
                case "pantheon":
                    total_area = CalcPantheon();
                    break;
                case "taj mahal":
                    total_area = CalcTajMahal();
                    break;
                case "great mosque of mecca":
                    total_area = CalcMosque();
                    break;
                default:
                    total_area = 0;
                    break;
            }
            double total_cost = total_area * cost_of_material;
            Console.WriteLine($"This plan will cost: {Math.Round(total_cost, 2)} pesos");
        }

        static double CalcPantheon()
        {
            double tri_area = Triangle(500, 750);
            double rec_area = Rectangle(1500, 2500);
            double circ_area = 0.5 * Circle(375);

            return tri_area + rec_area + circ_area;
        }

        static double CalcTajMahal()
        {
            double area = Rectangle(90.5);
            double corner = 0.5 * Rectangle(24);

            return area - corner;
        }

        static double CalcMosque()
        {
            double area = Rectangle(264, 284 + 106);
            double corners = 2 * Rectangle(106, (264 - 180) / 2);
            double tri_area = Triangle(84, 264);

            return area - (corners + tri_area);
        }

        static double Rectangle(double l1)
        {
            return Math.Pow(l1, 2);
        }

        static double Rectangle(double l1, double l2)
        {
            return l1 * l2;
        }

        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }
    }
}
