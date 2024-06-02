using EjemploClases.LOGIC;
using EjemploClases.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EjemploClases
{
    internal class Program
    {
 
        static void Main(string[] args)
        {
            //calcular
            //Menu para ver personas

            Persona persona = new Persona();
            List<Persona> lista = new List<Persona>();

            for (int i = 0; i < 10; i++)
            {
                lista.Add(persona);
            }
            Console.WriteLine(lista.Count);//25
            //lista[persona['nombre','edad'],persona['nombre','edad']] lista[1,3,4,5]

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Objeto: {lista[i]} posicion: {i} VALOR: {lista[i].Nombre}");
            }
            Console.WriteLine("FOR");//25
            Console.ReadLine();

            foreach (Persona per in lista) {
                Console.WriteLine(per.Apellido);
            }
            Console.WriteLine("FOREACH");
            Console.ReadLine();

        }

    }
}
