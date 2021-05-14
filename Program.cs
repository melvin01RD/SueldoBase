using System;
namespace SueldoBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas =8 ;
            int costoHora = 200;
            int sueldo =horasTrabajadas*costoHora;
            int impuestoISR=5;
            int impuestoAFP=10;
            int impuestoTech=15;
            int descuentos= impuestoAFP+impuestoISR+impuestoTech;
            int resultado=sueldo-descuentos;

            Console.Write("inserte horas trabajadas : ");
           


            Console.ReadLine();

            //operacion de sueldo y descuentos

            sueldo = horasTrabajadas * costoHora;
           
            Console.WriteLine(sueldo-descuentos);
           

            var consoleKeyInfo = Console.ReadKey();





        }
    }
}