using System;
namespace Lab2.classes;
    public class Circle
    {
        //Змінні радіус та координати кола
        private int Radius;
        private Coord Coord;
        //Перезавантажений конструктор
        public Circle(int radius, int x, int y)
        {
            this.Radius = radius;
            this.Coord = new Coord(x, y);
        }
        //Дефолтний конструктор
        public Circle()
        {
            this.Radius = 0;
            this.Coord = new Coord(0, 0);
        }
        //Метод для знаходження площі круга
        public double findArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
        //Сеттери та Ґеттери
        public void setRadius(int radius)
        {
            this.Radius = radius;
        }
        public void setX(int x)
        {
            this.Coord.setX(x);
        }
        public void setY(int y)
        {
            this.Coord.setY(y);
        }
        public int getRadius()
        {
            return this.Radius;
        }
        public int getX()
        {
            return this.Coord.getX();
        }
        public int getY()
        {
            return this.Coord.getY();
        }
    }
