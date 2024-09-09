using System;

namespace ShapesExample
{
    // Clase abstracta Shape
    public abstract class Shape
    {
        // Campos protegidos para que las clases derivadas puedan acceder a ellos.
        protected double Width { get; set; }
        protected double Height { get; set; }

        // Constructor que inicializa el ancho y el alto.
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Método abstracto que calculará la superficie (se implementa en las clases derivadas).
        public abstract double CalculateSurface();
    }

    // Clase Rectangle que hereda de Shape
    public class Rectangle : Shape
    {
        // Constructor que llama al constructor de la clase base (Shape).
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        // Implementación del método para calcular el área del rectángulo.
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }

    // Clase Triangle que hereda de Shape
    public class Triangle : Shape
    {
        // Constructor que llama al constructor de la clase base (Shape).
        public Triangle(double width, double height) : base(width, height)
        {
        }

        // Implementación del método para calcular el área del triángulo.
        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }
    }

    // Clase Circle que hereda de Shape
    public class Circle : Shape
    {
        // Constructor que toma un valor para el radio (que será tanto el ancho como el alto).
        public Circle(double radius) : base(radius, radius)
        {
        }

        // Implementación del método para calcular el área del círculo.
        public override double CalculateSurface()
        {
            double radius = this.Width;  // El radio es igual al ancho o alto.
            return Math.PI * Math.Pow(radius, 2);  // Área del círculo: π * radio^2.
        }
    }

    // Clase Program donde se ejecuta el código principal
    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear una matriz de formas (Shape).
            Shape[] shapes = new Shape[]
            {
                new Rectangle(10, 5),
                new Triangle(6, 8),
                new Circle(3)
            };

            // Crear otra matriz para almacenar las áreas calculadas.
            double[] areas = new double[shapes.Length];

            // Calcular el área de cada forma y almacenarla en la matriz de áreas.
            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
                Console.WriteLine($"Área de la forma {i + 1}: {areas[i]}");
            }
        }
    }
}
