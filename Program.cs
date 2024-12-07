using System;

namespace Geometry
{
    /// <summary>
    /// Клас, що описує пряму виду a1 * x + a2 * y + a0 = 0
    /// </summary>
    public class Line
    {
        protected double A0, A1, A2;

        /// <summary>
        /// Метод для задання коефіцієнтів прямої.
        /// </summary>
        public void SetCoefficients(double a0, double a1, double a2)
        {
            A0 = a0;
            A1 = a1;
            A2 = a2;
        }

        /// <summary>
        /// Метод для виведення коефіцієнтів прямої.
        /// </summary>
        public void DisplayCoefficients()
        {
            Console.WriteLine($"Пряма: {A1} * x + {A2} * y + {A0} = 0");
        }

        /// <summary>
        /// Метод для перевірки, чи належить точка прямій.
        /// </summary>
        public bool IsPointOnLine(double x, double y)
        {
            return Math.Abs(A1 * x + A2 * y + A0) < 1e-9;
        }
    }

    /// <summary>
    /// Клас, що описує гіперплощину у 4-вимірному просторі виду a4*x4 + a3*x3 + a2*x2 + a1*x1 + a0 = 0
    /// </summary>
    public class Hyperplane : Line
    {
        private double A3, A4;

        /// <summary>
        /// Метод для задання коефіцієнтів гіперплощини.
        /// </summary>
        public void SetCoefficients(double a0, double a1, double a2, double a3, double a4)
        {
            base.SetCoefficients(a0, a1, a2); // Виклик методу з базового класу
            A3 = a3;
            A4 = a4;
        }

        /// <summary>
        /// Метод для виведення коефіцієнтів гіперплощини.
        /// </summary>
        public new void DisplayCoefficients()
        {
            Console.WriteLine($"Гіперплощина: {A4} * x4 + {A3} * x3 + {A2} * x2 + {A1} * x1 + {A0} = 0");
        }

        /// <summary>
        /// Метод для перевірки, чи належить точка гіперплощині.
        /// </summary>
        public bool IsPointOnHyperplane(double x1, double x2, double x3, double x4)
        {
            return Math.Abs(A4 * x4 + A3 * x3 + A2 * x2 + A1 * x1 + A0) < 1e-9;
        }
    }

    /// <summary>
    /// Головний клас програми.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єкта класу "Пряма"
            Line line = new Line();
            line.SetCoefficients(-5, 2, 3); // Задання коефіцієнтів для прямої
            line.DisplayCoefficients();

            Console.WriteLine("Введіть точку (x, y), щоб перевірити, чи належить вона прямій:");
            Console.Write("x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(line.IsPointOnLine(x, y)
                ? "Точка належить прямій."
                : "Точка не належить прямій.");

            // Створення об'єкта класу "Гіперплощина"
            Hyperplane hyperplane = new Hyperplane();
            hyperplane.SetCoefficients(1, -2, 3, 4, -5); // Задання коефіцієнтів для гіперплощини
            hyperplane.DisplayCoefficients();

            Console.WriteLine("Введіть точку (x1, x2, x3, x4), щоб перевірити, чи належить вона гіперплощині:");
            Console.Write("x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x4: ");
            double x4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(hyperplane.IsPointOnHyperplane(x1, x2, x3, x4)
                ? "Точка належить гіперплощині."
                : "Точка не належить гіперплощині.");
        }
    }
}
