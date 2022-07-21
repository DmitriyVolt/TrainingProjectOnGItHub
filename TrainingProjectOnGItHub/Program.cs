using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProjectOnGItHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float health = 0f, maxHelth = 20f;
            string userInput;

            while (true)
            {
                DrawBar(health, maxHelth);

                Console.SetCursorPosition(0,4);
                Console.Write("На сколько процентов увеличить здоровье: ");
                userInput = (Console.ReadLine());
                health += maxHelth / 100 * Convert.ToSingle(userInput);

                Console.ReadKey();
                Console.Clear();
            }
            
        }

        static void DrawBar(float value, float maxValue)
        {
            char healthSymbol = '#', maxHealthSymbol = '_';
            string healthBar = "";

            for (float i = 0; i < value; i++)
            {
                healthBar += healthSymbol;
            }

            Console.Write('[');

            for (float i = value; i < maxValue; i++)
            {
                healthBar += maxHealthSymbol;
            }

            Console.Write(healthBar + ']');
        }
    }
}