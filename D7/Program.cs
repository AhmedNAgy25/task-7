using System;
namespace D7
{
    #region problem 1
    class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }

        public Car()
        {
            Id = 0;
            Brand = "Unknown";
            Price = 0.0;
        }

        public Car(int id)
        {
            Id = id;
            Brand = "Unknown";
            Price = 0.0;
        }

        public Car(int id, string brand)
        {
            Id = id;
            Brand = brand;
            Price = 0.0;
        }

        public Car(int id, string brand, double price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }
    }
    //because it find already one so it needn't to create one default

    #endregion

    #region problem 2
    class Calculator
    {
        public int Sum(int a, int b) { return a + b; }
        public int Sum(int a, int b, int c) { return a + b + c; }
        public double Sum(double a, double b) { return a + b; }
    }
    //it decrease names of function that used by make more than one function at same name with various arguments

    #endregion

    #region  problem 3

    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }
    //to call parent class before child which will increase child implementation 
    #endregion

    //problem 4 ....

    #region  problem 5

    class ParentWithToString
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ParentWithToString(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() { return $"({X}, {Y})"; }
    }

    class ChildWithToString : ParentWithToString
    {
        public int Z { get; set; }

        public ChildWithToString(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString() { return $"({X}, {Y}, {Z})"; }
    }
    //give us better string representaion for this object 
    #endregion

    #region problem 6

    interface IShape
    {
        double Area { get; }
        void Draw();
    }

    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;
        public void Draw() => Console.WriteLine("draw rectangle");
    }
    //because it havn't any implementaiton 
    #endregion

    #region problem 7

    interface IShapeWithDetails
    {
        double Area { get; }
        void Draw();
        void PrintDetails() => Console.WriteLine($"Area: {Area}");
    }

    class Circle : IShapeWithDetails
    {
        public double Radius { get; set; }

        public double Area => Math.PI * Radius * Radius;

        public void Draw() => Console.WriteLine("draw circle");
    }
    //no answer... 
    #endregion

    #region problem 8
    interface IMovable
    {
        void Move();
    }

    class CarWithMove : IMovable
    {
        public void Move() => Console.WriteLine("car is moving");
    }
    //enable us to change between implementation 
    #endregion

    #region problem 9
    interface IReadable
    {
        void Read();
    }

    interface IWritable
    {
        void Write();
    }

    class File : IReadable, IWritable
    {
        public void Read() => Console.WriteLine("reading file");
        public void Write() => Console.WriteLine("writing to file");
    }
    //? 
    #endregion

    //problem 10 ....

    internal class Program
    {
        static void Main()
        {
            var car1 = new Car();
            var car2 = new Car(1);
            var car3 = new Car(2, "toyota");
            var car4 = new Car(3, "honda", 25000);

            var calculator = new Calculator();
            int sum1 = calculator.Sum(3, 5);
            int sum2 = calculator.Sum(1, 2, 3);
            double sum3 = calculator.Sum(2.5, 3.5);

            var child = new Child(1, 2, 3);

            var parentToString = new ParentWithToString(1, 2);
            var childToString = new ChildWithToString(1, 2, 3);

            var rectangle = new Rectangle { Width = 5, Height = 10 };
            rectangle.Draw();
            Console.WriteLine($"area: {rectangle.Area}");

            var circle = new Circle { Radius = 5 };
            circle.Draw();

            IMovable movable = new CarWithMove();
            movable.Move();

            var file = new File();
            file.Read();
            file.Write();
        }
    }
}
