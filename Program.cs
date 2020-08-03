using System;


namespace Exercicio_3___Celsius_e_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Informe a quantidade de Graus Celsius que deseja converter");

                var celsius = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de Graus Fahrenheit que deseja converter");

                var fahrenheit = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(celsius + " graus Celsius em Fahrenheit é " + CelsiusToFahrenheit(celsius));

                Console.WriteLine(fahrenheit + " graus Fahrenheit em Celsius é " + FahrenheitToCelsius(fahrenheit));

                Console.ReadKey();
            }

             static double FahrenheitToCelsius(double valor)
            {
                //FORMULA RETIRADA DA CALCULADORA DO GOOGLE
                var resultado = (valor - 32) * (5.0 / 9.0);

                return resultado;
            }

            static double CelsiusToFahrenheit(double valor)
            {
                //FORMULA RETIRADA DA CALCULADORA DO GOOGLE
                var resultado = (valor * (9.0 / 5.0)) + 32;

                return resultado;
            }
        }
    }
    }

