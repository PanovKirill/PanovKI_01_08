using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanovKI_01_08.Classes
{
    public class Car
    {
        public double Distance { get; set; } //Дистанция
        public double ConsumPK { get; set; } //Расход на км
        public Car (double Distance, double ConsumPK) // Конструктор класса
        {
            this.Distance = Distance;
            this.ConsumPK = ConsumPK;
        }
        public virtual double CalcQ(double Distance, double ConsumPK) // Q = Расчет дистанции / расход на км
        {
            var Q = Distance / ConsumPK;
            return Q;
        }
        public void PrintInfoAboutCar (double Distance, double ConsumPK) // Метод для вывода информации
        {
            Console.WriteLine("Информация об автомобиле");
            Console.WriteLine("Пробег автомобиля: " + Distance);
            Console.WriteLine("Расход на км: " + ConsumPK);
            Console.WriteLine("Q: " + CalcQ(Distance,ConsumPK));
        }

    }
}
