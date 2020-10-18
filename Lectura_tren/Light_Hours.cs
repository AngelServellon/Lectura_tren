using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectura_tren
{
    class Light_Hours
    {
        private int index;
        private int minus;
        private int[] ordered = new int[100];
        private int[] discarted = new int[100];

        public void OrderArray(int[] lightLevels)
        {
            Array.Copy(lightLevels, ordered, lightLevels.Length);
            Array.Sort(ordered);
            Array.Reverse(ordered);
        }
        public void ShowMinimunLevel(int TravelHours, int LectureHours)
        {
            minus = TravelHours - LectureHours;
            index = TravelHours - (minus + 1);
            Console.WriteLine("\nNivel minimo de luz: {0}", ordered[index]);

        }
        public void DiscartedLevelLights()
        {
            for (int i = 0; i < minus; i++)
            {
                index++;
                discarted[i] = ordered[index];
            }
        }
        public void AvailableHours(int TravelHours, int[] lightLevels)
        {
            int yes = 0;
            Console.Write("\nHoras en las que se podra leer: ");
            for (int i = 0; i < TravelHours; i++)
            {
                for (int j = 0; j < discarted.Length; j++)
                {
                    if (lightLevels[i] == discarted[j])
                    {
                        yes = 0;
                        break;
                    }
                    else
                    {
                        yes = 1;
                    }
                }
                if (yes == 1) Console.Write("{0} ", (i + 1));
            }
        }
    }
}
