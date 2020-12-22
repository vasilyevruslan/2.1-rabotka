using System;

namespace ConsoleApp86
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Время разговора от 0 до 24 часов: ");
            int t = Convert.ToInt32(Console.ReadLine());

            // определение времени начала разговора
            DateTime dateStart = new DateTime(2020, 1, 1, t == 24 ? 0 : t, 0, 0);

            Console.Write("Продолжительность разговора в минутах: ");
            int dt = Convert.ToInt32(Console.ReadLine());

            // определение времени конца разговора
            DateTime dateEnd = dateStart.AddHours(Math.Ceiling(Convert.ToDouble(dt / 60.0)));

            Console.Write("Стоимость минуты разговора: ");
            double s = Convert.ToDouble(Console.ReadLine());

            Console.Write("День недели от 1 до 7: ");
            int d = Convert.ToInt32(Console.ReadLine());

            // стоимость всего разговора
            double sc = 0;

            if ((dateEnd.Hour >= 0 && dateEnd.Hour < 8) || (dateEnd.Hour >= 22 && dateEnd.Hour <= 23))
            {
                sc = s * dt * 0.9;

                if (d == 6 || d == 7)
                {
                    sc = s * dt * 0.85;
                }
            }
            else
            {
                sc = s * dt;
            }
            Console.WriteLine("Стоимость разговора (с учетом скидки) - {0}р.", sc);
        }
    }
}