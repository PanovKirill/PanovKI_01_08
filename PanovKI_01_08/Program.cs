using PanovKI_01_08.Classes;
using System;

namespace PanovKI_01_08
{
    class Program
    {
        static void Main (string[] args)
        {
            Car car = new Car(100, 5);
            car.PrintInfoAboutCar(100,5);
            ChildClassCar childClassCar = new ChildClassCar(100, 5, 2004);
            childClassCar.PrintInfoAboutChildClassCar(2004,100,5);
        }
    }
}
