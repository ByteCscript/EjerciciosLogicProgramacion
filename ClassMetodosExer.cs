using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLogicProgramacion
{
    class ClassMetodosExer  
    {

        MetodosGetSet co = new MetodosGetSet();

        public void exer1()//creacion de metodo publico para otras clases
        {
            int a, b, c, suma;
            a = 1;
            b = a + 2;
            c = b + 3;
            suma = a +b + c;
            
            Console.WriteLine("Metodo 1: Crear 3 variables " +
             "numéricas con el valor que tu quieras y en otra variable " +
             "numérica guardar el valor \n de la suma de las 3 anteriores. Mostrar por consola.");
            Console.WriteLine("\n El resultado de la suma de las 3 Variables es: " + suma);
            Console.WriteLine(" Valores \n a = " + a +
                "\n b = " + b +
                "\n c = " + c);
        }

        public void exer2()
        {
            //metodo para imprimir la captura de un nombre o caracteres por teclado con metodos get y set
            Console.WriteLine("Escribe tu Nombre: ");
            //setNombre -  captura el nombre 
            co.setNombre(Console.ReadLine());
            Console.WriteLine("Escribe el nombre de la ciudad donde vives: ");
            co.setCiudad(Console.ReadLine());
            Console.WriteLine("Hola " + co.getNombre() + " Bienvenido a " + co.getCiudad());
            Console.ReadKey();
        }

        public void exer3()
        {
            //metodo que captura nombre y edad 
            Console.WriteLine("Escribe tu nombre: ");
            co.setNombre(Console.ReadLine());//almacena en string en el metodo set donde se da el nombre
            Console.WriteLine("Escribe tu Edad: ");
            co.setEdad(Console.ReadLine());
            Console.WriteLine("Te llamas " + co.getNombre() + " y tienes " + co.getEdad() + " años.");
            //imprime el string almacenado por medio del get de dar que se obtuvo del set
            Console.ReadKey();

        }

        public void exer4()//metodo del numero mayor
        {
            int o, p;
            Console.WriteLine("Cual Numero es mayor? \n");
            Console.WriteLine("Escriba el primer numero:");
            o = int.Parse(Console.ReadLine());//convierte el texto string en un numero de 32 bits
            Console.WriteLine("Escriba el segundo numero:");
            p = int.Parse(Console.ReadLine());

            if (o > p) Console.WriteLine(" El Numero : " + o + " Es mayor que " + p);//condicionales
            else Console.WriteLine(" El numero : " + p + " Es mayor que " + o);
            

        }

        public void exer5()//metodo para saber que dia es un fin de semana
        {
            String name;
            Console.WriteLine(" Escriba un día de la Semana, para verificar si es fin de semana");//imprime
            name = Console.ReadLine();//captura el caracter y lo almacena el variable (name)

            switch (name.ToLower())//switch condicionando el name
                //el tolower retorna todo el string en minuscula - (mayor facilidad de trabajo para generar el case)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("No es un fin de semana");
                    break;//cierra el case para que finalice con la tarea una vez se genere
                
                case "sabado":
                case "domingo":
                    Console.WriteLine("Si es un Fin de Semana");//imprime     
                    break;

                default://funciona como el else en if, si no ocurre nada de los anteriores casos por default 
                    //imprime o hace la accion final
                    Console.WriteLine("Ese dia no es correcto");
                    break;

            }
        }

        public void exer6()
        {
            //metodo contador por ciclo for hasta el numero 100
            int o;
            for(o = 0;o < 100; o++)
            {
                Console.WriteLine( o + 1);
            }
        }

        public void exer7()
        {
            //metodo para ahorrar en una cuenta el valor por medio de tarjeta o efectivo 
            double o;
            int p, x;
            Console.WriteLine("¿Cuanto dinero quiere ahorrar este mes en el fondo? en COP");
            o = double.Parse(Console.ReadLine());

            Console.WriteLine("Indique la opcion con la cual quiere pagar" +
                "\n 1. Tarjeta" +
                "\n 2. Efectivo");
            p = int.Parse(Console.ReadLine());  
            switch(p)
            {
                case 1:
                    Console.WriteLine("Ingrese el número de su Tarjeta: ");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ha ahorrado de manera correcta en el fondo un total de " + o + " COP \n" +
                        "desde la tarjeta con número de cuenta: " + x);
                    Console.WriteLine("Buen día!!");
                    break; 
                case 2:
                    Console.WriteLine(" Ha ahorrado de manera correcta en Efectivo por un valor de : " + o + " COP .");
                    Console.WriteLine("Buen día !!");
                    break;
            }

        }

        public void exer8()
        {
            int o = 0;
            //cuando esa accion cumpla la condicion procede a ejecutar lo que esta dentro del bucle
            /*
            while(o < 100)
            {
                o++;
                Console.WriteLine( o );
            }
            */

            //para el do while primero se da la accion y despues se coloca la condicion en el bucle (do = hacer)
            Console.WriteLine(" Ahora con el Do While");
            do
            {
                o++;
                Console.WriteLine(o);
            }while(o < 100);
        }

        public void exer9()
        {
          for(int i = 2; i <= 100; i+= 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Console.WriteLine("/// ");

            int o = 2;
            do
            {
                int p = o+= 2;
                Console.WriteLine(p);
            }while(o <=100);
        }

        public void exer10()
        {
            
            for(int o = 1; o <= 100; o++)
            {
                if(o % 2==0 || o % 3 == 0)
                {

                    Console.WriteLine(o);
                }
            }
            Console.ReadKey();
        }
    }

    
}
