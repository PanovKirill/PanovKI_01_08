using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanovKI_01_08.Classes
{
    public class ChildClassCar: Car
    {
        public double YearOfIssue { get; set; } // Год выпуска
        public ChildClassCar (double Distance, double ConsumPK,double YearOfIssue) : base(Distance, ConsumPK) // Конструктор класса потомка ChildClassCar
        {
            this.YearOfIssue = YearOfIssue;
        }
        public override double CalcQ (double Distance, double ConsumPK) // Qp = Q * 1.15*Год выпуска
        {
            var Q = base.CalcQ(Distance, ConsumPK);
            var Qp = Q * 1.15 * YearOfIssue;
            return Qp;
        }
        public void PrintInfoAboutChildClassCar (double YearOfIssue,double Distance, double ConsumPK) // Вывод инфрмации с дополнительной информацией
        {
            Console.WriteLine("Дополнительная информаия об автомобиле");
            Console.WriteLine("Год выпуска автомобиля: " + YearOfIssue);
            Console.WriteLine("Qp : " + CalcQ(Distance,ConsumPK));
        }



    }
}
