using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectura_tren
{
    class GetLevelsHours
    {
        public int TravelHours { get; set; }
        public int LectureHours { get; set; }
        public int[] lightLevels = new int[100];
        
        public void WriteTravelHours()
        {
            int yes;
            do
            {
                Console.Write("\nIngrese la cantidad de horas del viaje: ");
                TravelHours = int.Parse(Console.ReadLine());
                if (TravelHours >= 1 && TravelHours <= 1000) {
                    yes = 1;
                } else {
                    Console.WriteLine("\nERROR: Las horas ingresadas deben ser mayor o igual a 1 y menor o igual a 1000");
                    yes = 0;
                }
            } while (yes == 0);
        }
        public void WriteLectureHours()
        {
            int yes;
            do
            {
                Console.Write("\nIngrese la cantidad de horas que leera: ");
                LectureHours = int.Parse(Console.ReadLine());
                if (LectureHours >= 1 && LectureHours <= TravelHours){
                    yes = 1;
                }else{
                    Console.WriteLine("\nERROR: Las horas ingresadas deben ser mayor o igual a 1 y menor o igual las horas de viaje");
                    yes = 0;
                }
            } while (yes == 0);
        }
        public void FullfillLightLevels()
        {
            int yes;
            Console.WriteLine("\n\tNivel de luz por cada hora\n");
            for (int i = 0; i < TravelHours; i++){
                do {
                    Console.Write("Hora {0}: ", i + 1);
                    lightLevels[i] = int.Parse(Console.ReadLine());
                    if (lightLevels[i] < 0 || lightLevels[i] > 100){
                        Console.WriteLine("\nERROR: El nivel de luz solo puede ser de 0 a 100\n");
                        yes = 1;
                    }else{
                        yes = 0;
                    }
                } while (yes==1);
                
            }
        }
         
    }
}
