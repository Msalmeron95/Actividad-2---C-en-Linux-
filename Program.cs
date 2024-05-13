using System;
using System.Collections.Generic;
using System.Text;

namespace UGBCLASS
{
    class MainClass
    {
        static void Main(string[] args)
        {
            MostrarMenu();
        }

        public static void MostrarMenu()
        {
            int opcion;
            do
            {
                Console.WriteLine("Seleccione un ejercicio:");
                Console.WriteLine("1. Ejercicio Uno");
                Console.WriteLine("2. Ejercicio Dos");
                Console.WriteLine("3. Ejercicio Tres");
                Console.WriteLine("4. Ejercicio Cuatro");
                Console.WriteLine("5. Ejercicio Cinco");
                Console.WriteLine("6. Ejercicio Seis");
                Console.WriteLine("7. Ejercicio Siete");
                Console.WriteLine("8. Ejercicio Ocho");
                Console.WriteLine("9. Ejercicio Nueve");
                Console.WriteLine("10. Ejercicio Diez");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese el número de ejercicio o 0 para salir: ");
                
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            EjercicioUno();
                            break;
                        case 2:
                            EjercicioDos();
                            break;
                        case 3:
                            EjercicioTres();
                            break;
                        case 4:
                            EjercicioCuatro();
                            break;
                        case 5:
                            EjercicioCinco();
                            break;
                        case 6:
                            EjercicioSeis();
                            break;
                        case 7:
                            EjercicioSiete();
                            break;
                        case 8:
                            EjerciciOcho();
                            break;
                        case 9:
                            EjercicioNueve();
                            break;
                        case 10:
                            EjercicioDiez();
                            break;
                        case 0:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione un número válido.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, seleccione un número válido.");
                }

                Console.WriteLine();
            } while (opcion != 0);
        }

        public static void EjercicioUno()
        {
            //1. Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "David", o bien le diga "No te conozco" si teclea otro nombre.

            while(true)
            {
                string Nombre = "David";

                Console.Write("Ingrese si nombre: ");
                string aNombre = Console.ReadLine();

                if(aNombre == Nombre)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Hola {aNombre}");
                    Console.ResetColor();
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"No te conozco {aNombre}");
                    Console.ResetColor();
                }
            }
        }
    
        public static void EjercicioDos()
        {
        
            //2.Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero). 
            double Addition;
            while(true)
            {

                Console.Write("Ingresa un numero: ");
                double Num = Convert.ToDouble(Console.ReadLine());
                Addition =+ Num;

                Console.Write($"Quieres ingresar otro numero? Y/N:");
                string Answer = Console.ReadLine().ToLower();
                if(Answer == "y")
                {
                    continue;
                }
                else
                {
                    Console.Write($"El total de la suma de los numeros ingresados es: {Addition}");
                    return;
                }
                
            } 
        }
    
        public static void EjercicioTres()
        {
           //3.Crear un programa que permita cargar los nombres de 5 operarios y sus sueldos respectivos. Mostrar el sueldo mayor y el nombre del operario. 

            string[] nombres = new string[5];
            double[] sueldos = new double[5];

            // Solicitar al usuario que ingrese los nombres y sueldos de los operarios
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese el nombre del operario {i + 1}:");
                nombres[i] = Console.ReadLine();

                Console.Write($"Ingrese el sueldo de {nombres[i]}:");
                sueldos[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Encontrar el sueldo máximo y el índice correspondiente
            double sueldoMaximo = sueldos[0];
            int indiceMaximo = 0;

            for (int i = 1; i < 5; i++)
            {
                if (sueldos[i] > sueldoMaximo)
                {
                    sueldoMaximo = sueldos[i];
                    indiceMaximo = i;
                }
            }

            Console.WriteLine($"El operario con el sueldo más alto es: {nombres[indiceMaximo]}");
            Console.WriteLine($"Su sueldo es: {sueldos[indiceMaximo]}");
        }    
    
        public static void EjercicioCuatro()
        {
            //4.Mostrar los números impares entre el 0 y el 100.
            Console.WriteLine("Números impares entre 0 y 100:");

            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        
        public static void EjercicioCinco()
        {
            //5.Realizar la tabla de multiplicar de un número entre 0 y 10 de forma que se visualice de la siguiente forma: 4x1=4.

            Console.Write("Ingresa el numero de la tabla de multiplicar que deceas ingresar: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0 || numero > 10)
            {
                Console.WriteLine("El número debe estar entre 0 y 10.");
                return;
            }

            Console.WriteLine($"Tabla de multiplicar del número {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    
        public static void EjercicioSeis()
        {
            //6.Ingresar 5 números y mostrar su promedio.
            const int cantidadNumeros = 5;
            double suma = 0;

            Console.WriteLine($"Por favor, ingrese {cantidadNumeros} números:");

            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write($"Número {i + 1}: ");
                double numero;
                if (double.TryParse(Console.ReadLine(), out numero))
                {
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Inténtalo de nuevo.");
                    i--; 
                }
            }

            double promedio = suma / cantidadNumeros;
            Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
        }
    
        public static void EjercicioSiete()
        {
           //7.	Ingresar un número y mostrar el cuadrado del mismo. El número debe ser mayor que cero, en caso de error que aparezca el mensaje "ERROR. Reingresar número". 
            double numero;
            bool esValido = false;

            do
            {
                Console.WriteLine("Ingrese un número mayor que cero:");
                string input = Console.ReadLine();

                if (double.TryParse(input, out numero) && numero > 0)
                {
                    esValido = true;
                }
                else
                {
                    Console.WriteLine("ERROR. Reingresar número.");
                }
            } while (!esValido);

            double cuadrado = Math.Pow(numero, 2);
            Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
        }
    
        public static void EjerciciOcho()
        {
            //8.Ingresar un número e indicar si es positivo o negativo.
            Console.WriteLine("Ingrese un número:");
            double numero;

            if (double.TryParse(Console.ReadLine(), out numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("El número ingresado es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número ingresado es negativo.");
                }
                else
                {
                    Console.WriteLine("El número ingresado es cero.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
            }
        }

        public static void EjercicioNueve()
        {
            //9.Ingresar un número y mostrar si es par o impar.
            Console.WriteLine("Ingrese un número:");
            int numero;

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número ingresado es par.");
                }
                else
                {
                    Console.WriteLine("El número ingresado es impar.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero válido.");
            }
        }
    
        public static void EjercicioDiez()
        {
            //10.Programa para calcular la edad promedio de un grupo de 15 estudiantes.
            const int cantidadEstudiantes = 15;
            int sumaEdades = 0;

            Console.WriteLine($"Ingrese las edades de los {cantidadEstudiantes} estudiantes:");

            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.Write($"Edad del estudiante {i + 1}: ");
                int edad;
                if (int.TryParse(Console.ReadLine(), out edad) && edad >= 0)
                {
                    sumaEdades += edad;
                }
                else
                {
                    Console.WriteLine("Edad inválida. Inténtelo de nuevo.");
                    i--;
                }
            }

            double edadPromedio = (double)sumaEdades / cantidadEstudiantes;
            Console.WriteLine($"La edad promedio de los {cantidadEstudiantes} estudiantes es: {edadPromedio}");
        }     


    
    
    }
}