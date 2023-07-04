using System;

public class Program
{
    public static void Main()
    {
        
        double generatriz, radio, altura;

        try
        {
            Console.WriteLine("Ejercicio de simulación");

            Console.Write("Ingrese valor de generatriz: ");
            generatriz = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese valor de radio: ");
            radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor de altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("La superficie del cono es: " + Area(radio, generatriz));

            Console.WriteLine("El volumen del cono es: " + Volumen(radio, altura));

        }    
        catch (Exception ex) 
        {
            Console.WriteLine("El valor ingresado no es válido");
        }
    }

    // Función para calcular el volumen de un cono
    public static double Volumen(double radio, double altura)
    {
        double resultado = (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        return resultado;
    }

    // Función para calcular el área de un cono
    public static double Area(double radio, double generatriz)
    {
        double resultado = Math.PI * radio * (radio + generatriz);
        return resultado;
    }
}
