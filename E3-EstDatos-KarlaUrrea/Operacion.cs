using System;
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos_KarlaUrrea
{
    public class Operacion
    {
   
        
            Stack Lista = new Stack();
            Queue Cola = new Queue();

        

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()

            Stack pila = new Stack();
            pila.Push(5);
            pila.Push(3);
            pila.Pop();
            pila.Push(2);
            pila.Push(8);
            pila.Pop();
            pila.Pop();
            pila.Push(9);
            pila.Push(1);
            pila.Pop();
            pila.Push(7);
            pila.Push(6);
            pila.Pop();
            pila.Pop();
            pila.Push(4);
            pila.Pop();
            pila.Pop();

            Console.WriteLine("Valores en la pila:");
            foreach (Object obj in pila)
            {
                Console.Write("    {0}", obj);
            }
            Console.WriteLine();
            Console.ReadKey();

        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal

           
            LinkedList<string> PalabrasReservadas = new LinkedList<string>();
            LinkedList<string> Literales = new LinkedList<string>();

            string respuesta, palabra;

            do
            {
                Console.WriteLine("¿Quisiera agregar palabra?");
                respuesta = Console.ReadLine();
                Console.WriteLine("Palabra a ingresar");
                palabra = Console.ReadLine();

                if (isValidIdentifier(palabra)==true)
                {
                    PalabrasReservadas.AddLast(palabra);
                }else if (esLiteral(palabra)==true)
                {
                    Literales.AddLast(palabra);
                }
                

                

            } while (respuesta == "Si"|| respuesta == "si"|| respuesta == "SI");

            Console.WriteLine("Valores en la lista de palabras reservadas:");
            foreach (Object obj in PalabrasReservadas)
            {
                Console.Write("    {0}", obj);
            }

            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("Valores en la lista de literales:");
            foreach (Object obj in Literales)
            {
                Console.Write("    {0}", obj);
            }
            Console.WriteLine();
            Console.ReadKey();

        }

        public void Ejercicio3()
        {

            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            Stopwatch Tiempo = new Stopwatch();
            Tiempo.Start();

             LinkedList<Int32> ListaNum = new LinkedList<Int32>();

           for (int i =0; i<9877; i++)
            {
                ListaNum.AddLast(i);
                
            }
            Tiempo.Stop();

            Console.WriteLine("Tiempo Lista ligada: {0}", Tiempo.Elapsed.ToString());

            Tiempo.Start();
            List<Int32> ListaNum2 = new List<Int32>();


            for (int i = 0; i < 9877; i++)
            {
                ListaNum2.Add(i);

            }
            Tiempo.Stop();

            Console.WriteLine("Tiempo Lista Normal: {0}", Tiempo.Elapsed.ToString());

        }

        public void Ejercicio4()
        {

            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            List<Clase> alumno = new List<Clase>();
            List<int> calificaciones = new List<int>();

            int max = 0; 
            int min = 100;

            Clase clase1 = new Clase();
            Console.WriteLine("Maestro: ");
            clase1.Maestro = Console.ReadLine();
            Console.WriteLine("Materia: ");
            clase1.NombreClase = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                Clase clase2 = new Clase();
                Console.WriteLine("Nombre del Alumno " + (i + 1));
                clase2.Alumno = Console.ReadLine();
                Console.WriteLine("Calificacion");
                clase2.Calificacion = int.Parse(Console.ReadLine());
                if (clase2.Calificacion > max)
                    max = clase2.Calificacion;
                if (min > clase2.Calificacion)
                    min = clase2.Calificacion;
                alumno.Add(clase2);
            }

            double suma = 0;
            double promedio = 0;

            foreach (var a in alumno)
            {
                suma += a.Calificacion;
                promedio = suma / alumno.Count;
            }
            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("Calificacion mas alta: {0}", max);
            Console.WriteLine("nCalificacion mas baja: {0}", min);

        }

        static bool isValidIdentifier(string value)

        {

            Microsoft.CSharp.CSharpCodeProvider prov =

                new Microsoft.CSharp.CSharpCodeProvider();

            return prov.IsValidIdentifier(value);

        }
      

        static bool esLiteral(string value)

        {
           if(value== "null"||value== "true"||value=="false"||value=="default"){
                return true;
            }else{
                return false;
            }

            

        }
    }
}
