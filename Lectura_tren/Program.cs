using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectura_tren
{
    class Program
    {
        static void Main(string[] args)
        {
            GetLevelsHours getLH = new GetLevelsHours();
            Light_Hours light_h = new Light_Hours();
            
            Console.WriteLine("\t\tLECTURA DE TREN");
            //Pedir los datos al usuario
            getLH.WriteTravelHours();
            getLH.WriteLectureHours();
            getLH.FullfillLightLevels();
            light_h.OrderArray(getLH.lightLevels);//Ordenar los niveles de luz 
            Console.Clear();
           
            Console.WriteLine("\t\tLECTURA DE TREN");
            light_h.ShowMinimunLevel(getLH.TravelHours, getLH.LectureHours);//Mostrar el nivel minimo de luz en el viaje
            light_h.DiscartedLevelLights();//Sacar los niveles de luz en los que no se puede leer
            light_h.AvailableHours(getLH.TravelHours, getLH.lightLevels);//Mostrar las las horas en que se podra leer
            Console.WriteLine("\n");
        }
    }
}
