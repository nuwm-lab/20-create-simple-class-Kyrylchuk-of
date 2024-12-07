using System;

namespace Lab2
{
    /// <summary>
    /// Клас для опису круга.
    /// </summary>
    public class Circle
    {
        private (double x, double y) center; // Координати центру круга
        private double radius; // Радіус круга

        /// <summary>
        /// Властивість для доступу до центру круга.
        /// </summary>
        public (double x, double y) Center
        {
            get => center;
            set => center = value;
        }

        /// <summary>
        /// Властивість для доступу до радіуса круга.
        /// </summary>
        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Радіус повинен бути більшим за 0");
                radius = value;
            }
        }

        /// <summary>
        /// Конструктор із параметрами.
        /// </summary>
        /// <param name="center">Координати центру круга.</param>
        /// <param name="radius">Радіус круга.</param>
        public Circle((double x, double y) center, double radius)
        {
            Center = center;
            Radius = radius;
        }

        /// <summary>
        /// Конструктор за замовчуванням.
        /// </summary>
        public Circle() { }

        /// <summary>
        /// Метод для введення даних про круг.
        /// </summary>
        public void InputData()
        {
            Console.WriteLine("Введіть координати центру круга:");
            Center = InputPoint();

            while (true)
            {
                try
                {
                    Console.Write("Введіть радіус: ");
                    Radius = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}. Спробуйте ще раз.");
                }
            }
        }

        /// <summary>
        /// Метод для введення координат точки.
        /// </summary>
        /// <returns>Координати точки.</returns>
        private (double x, double y) InputPoint()
        {
            while (true)
            {
                try
                {
                    Console.Write("x: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("y: ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    return (x, y);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}. Спробуйте ще раз.");
                }
            }
        }

        /// <summary>
        /// Метод для обчислення площі круга.
        /// </summary>
        /// <returns>Площа круга.</returns>
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }

    /// <summary>
    /// Головний клас програми.
    /// </summary>
    class Program
    {
        static void Main()
        {
            try
            {
                Circle circle = new Circle();
                circle.InputData();

                double area = circle.GetArea();
                Console.WriteLine($"Площа круга: {area:F2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
