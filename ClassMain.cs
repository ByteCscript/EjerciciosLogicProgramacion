using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLogicProgramacion
{
    class ClassMain
    {
         public static void Main(string[] args)
        {
            //llamar una clase en una variable
            ClassMetodosExer m = new ClassMetodosExer();
            //m.exer2(); //llamar un metodo de una clase
            Console.WriteLine("En este programa de introduccion vamos, a usar la programación " +
                "Con los ejercicios básicos.");
            Console.WriteLine("\n Opciones: " +
                "\n 1. Sumatoria de variables" +
                "\n 2. Ingreso de Nombre y Ciudad" +
                "\n 3. Ingreso de Nombre y Edad" +
                "\n 4. Que numero es Mayor" +
                "\n 5. Saber que día es fin de semana" +
                "\n 6. Contador hasta numero 100 con ciclo for" +
                "\n 7. Metodo para ahorrar dinero en una cuenta " +
                "\n 8. Bucle Do While y While hasta el numero 100" +
                "\n 9. Bucle For al numero 100 con solo los numeros pares " +
                "\n 10. Bucle for al numero 100 con solo numeros divisibles entre 3 o pares");

            Console.WriteLine(" -->" +
                "\n Ingrese una Opción: ");
            int t;
            t = int.Parse(Console.ReadLine());
            
            switch (t)
            {
                case 1:
                    Console.WriteLine("Hola Ejercicio 1 \n");
                    m.exer1();
                    break;

                case 2:
                    Console.WriteLine("Hola Ejercicio 2 \n");
                    m.exer2();
                    break;

                case 3:
                    Console.WriteLine("Hola Ejercicio 3 \n");
                    m.exer3();
                    break;

                case 4:
                    Console.WriteLine("Hola Ejercicio 4 \n");
                    m.exer4();
                    break;

                case 5:
                    Console.WriteLine("Hola Ejercicio 5 \n");
                    m.exer5();
                    break;

                case 6:
                    Console.WriteLine("Hola Ejercicio 6 \n");
                    m.exer6();
                    break;

                case 7:
                    Console.WriteLine("Hola Ejercicio 7 \n");
                    m.exer7();
                    break;

                case 8:
                    Console.WriteLine("Hola Ejercicio 8 \n");
                    m.exer8();
                    break;

                case 9:
                    Console.WriteLine("Hola Ejercicio 9 \n");
                    m.exer9();
                    break;

                case 10:
                    Console.WriteLine("Hola Ejercicio 10 \n");
                    m.exer10();
                    break;
            }

        }
    }
}
