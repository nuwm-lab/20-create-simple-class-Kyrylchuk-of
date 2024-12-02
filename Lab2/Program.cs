using Lab2.classes;

//Ключ виходу
ConsoleKeyInfo key;
do
{
    //Оголошення змінних radius, x, y, та об'єкта circle класу Circle
    int radius, x, y;
    Circle circle = new();

    //Ввід радіусу
    Console.Write("Введiть радiус кола : ");
    radius = int.Parse(Console.ReadLine()!);

    //Ввід Х
    Console.Write("Введiть X : ");
    x = int.Parse(Console.ReadLine()!);

    //Ввід Y
    Console.Write("Введiть Y : ");
    y = int.Parse(Console.ReadLine()!);

    //Сеттимо дані
    circle.setRadius(radius);
    circle.setX(x);
    circle.setY(y);

    //Вивід результату
    Console.WriteLine($"Площа кола, радiусом {radius} та з центром в точці [{x};{y}] - {circle.findArea()}");
    Console.WriteLine("Вийти - 0");
    key = Console.ReadKey();
    Console.Clear();

} while (key.Key != ConsoleKey.D0);

Console.WriteLine("До попачення!");
