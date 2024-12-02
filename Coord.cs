using System;
namespace Lab2.classes;
    public class Coord
    {
        //Змінні X та Y
        private int X;
        private int Y;
        //Перезавантажений конструктор
        public Coord(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        //Дефолтний конструктор
        public Coord() { }
        //Сеттери та Ґеттери
        public void setX(int x)
        {
            this.X = x;
        }
        public void setY(int y)
        {
            this.Y = y;
        }
        public int getX()
        {
            return this.X;
        }
        public int getY()
        {
            return this.Y;
        }
    }
