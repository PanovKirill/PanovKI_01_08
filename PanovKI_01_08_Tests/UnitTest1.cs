using Microsoft.VisualStudio.TestTools.UnitTesting;
using PanovKI_01_08.Classes;

namespace PanovKI_01_08_Tests
{
    [TestClass]
    public class UnitTest1
    {
        //����� ������������ ������ Car
        [TestMethod]
        public void TestConstructorClassCar () // ��������� ����������� ������ Car ����� 1
        {   //Arrage
            double distance = 100;
            double consumPK = 5;
            //Act
            Car car = new Car(distance, consumPK);
            //Assert
            Assert.AreEqual(distance, car.Distance);
            Assert.AreEqual(consumPK, car.ConsumPK);
        }
        [TestMethod]
        public void TestConstructorClassCar2 () // ��������� ����������� ������ Car ����� 2
        {   //Arrage
            double distance = 200;
            double consumPK = 5;
            //Act
            Car car = new Car(distance, consumPK);
            //Assert
            Assert.AreEqual(distance, car.Distance);
            Assert.AreEqual(consumPK, car.ConsumPK);
        }
        [TestMethod]
        public void TestConstructorClassCar3 () // ��������� ����������� ������ Car ����� 3
        {   //Arrage
            double distance = 10;
            double consumPK = 1;
            //Act
            Car car = new Car(distance, consumPK);
            //Assert
            Assert.AreEqual(distance, car.Distance);
            Assert.AreEqual(consumPK, car.ConsumPK);
        }
        [TestMethod]
        public void TestConstructorClassCar4 () // ��������� ����������� ������ Car ����� 4
        {   //Arrage
            double distance = 87;
            double consumPK = 50;
            //Act
            Car car = new Car(distance, consumPK);
            //Assert
            Assert.AreEqual(distance, car.Distance);
            Assert.AreEqual(consumPK, car.ConsumPK);
        }

        //����� ������ ������� � ������ Car
        [TestMethod]
        public void TestCalcQ () // ��������� ������� � ������ CalcQ � ������ Car ����� 1
        {   
            //Assert
            double distance = 100;
            double consumPK = 5;
            Car car = new Car(distance,consumPK);
            //Act
            var Q = car.CalcQ(distance, consumPK);
            //Assert
            Assert.AreEqual(20, Q);
        }
        [TestMethod]
        public void TestCalcQ2 () // ��������� ������� � ������ CalcQ � ������ Car ����� 2
        {
            //Assert
            double distance = 200;
            double consumPK = 5;
            Car car = new Car(distance, consumPK);
            //Act
            var Q = car.CalcQ(distance, consumPK);
            //Assert
            Assert.AreEqual(40, Q);
        }
        [TestMethod]
        public void TestCalcQ3 () // ��������� ������� � ������ CalcQ � ������ Car ����� 3
        {
            //Assert
            double distance = 10;
            double consumPK = 1;
            Car car = new Car(distance, consumPK);
            //Act
            var Q = car.CalcQ(distance, consumPK);
            //Assert
            Assert.AreEqual(10, Q);
        }
        [TestMethod]
        public void TestCalcQ4 () // ��������� ������� � ������ CalcQ � ������ Car ����� 4
        {
            //Assert
            double distance = 87;
            double consumPK = 50;
            Car car = new Car(distance, consumPK);
            //Act
            var Q = car.CalcQ(distance, consumPK);
            //Assert
            Assert.AreEqual(1.74, Q);
        }
        //����� ������������ ������ ChildClassCar
        [TestMethod]
        public void TestConstructorChildClassCar () // ��������� ����������� ������ ChildClassCar ����� 1
        {
            //Arrage
            double distance = 100;
            double consumPK = 5;
            double yearOfIssue = 2004;
            //Act
            ChildClassCar childClassCar = new ChildClassCar(distance,consumPK,yearOfIssue);
            //Assert
            Assert.AreEqual(distance, childClassCar.Distance);
            Assert.AreEqual(consumPK, childClassCar.ConsumPK);
            Assert.AreEqual(yearOfIssue, childClassCar.YearOfIssue);
        }
        [TestMethod]
        public void TestConstructorChildClassCar2 () // ��������� ����������� ������ ChildClassCar ����� 2
        {
            //Arrage
            double distance = 500;
            double consumPK = 10;
            double yearOfIssue = 2007;
            //Act
            ChildClassCar childClassCar = new ChildClassCar(distance, consumPK, yearOfIssue);
            //Assert
            Assert.AreEqual(distance, childClassCar.Distance);
            Assert.AreEqual(consumPK, childClassCar.ConsumPK);
            Assert.AreEqual(yearOfIssue, childClassCar.YearOfIssue);
        }
        [TestMethod]
        public void TestConstructorChildClassCar3 () // ��������� ����������� ������ ChildClassCar ����� 3
        {
            //Arrage
            double distance = 150;
            double consumPK = 2;
            double yearOfIssue = 2004;
            //Act
            ChildClassCar childClassCar = new ChildClassCar(distance, consumPK, yearOfIssue);
            //Assert
            Assert.AreEqual(distance, childClassCar.Distance);
            Assert.AreEqual(consumPK, childClassCar.ConsumPK);
            Assert.AreEqual(yearOfIssue, childClassCar.YearOfIssue);
        }
        [TestMethod]
        public void TestConstructorChildClassCar4 () // ��������� ����������� ������ ChildClassCar ����� 4
        {
            //Arrage
            double distance = 500;
            double consumPK = 10;
            double yearOfIssue = 2012;
            //Act
            ChildClassCar childClassCar = new ChildClassCar(distance, consumPK, yearOfIssue);
            //Assert
            Assert.AreEqual(distance, childClassCar.Distance);
            Assert.AreEqual(consumPK, childClassCar.ConsumPK);
            Assert.AreEqual(yearOfIssue, childClassCar.YearOfIssue);
        }




        //����� ������ ������� � ������ �hildClassCar
        [TestMethod]
        public void TestCalcQChildClassCar () // ��������� ������� � ������ CalQ � ������ ������� ChildClassCar ����� 1
        {
            //Assert
            double distance = 100;
            double consumPK = 5;
            double yearOfIssue = 2004;
            ChildClassCar childClassCar = new ChildClassCar(distance, consumPK, yearOfIssue);
            //Act
            var Q = childClassCar.CalcQ(distance,consumPK);
            //Assert
            Assert.AreEqual(46092, Q);

        }
        [TestMethod]
        public void TestCalcQChildClassCar2 () // ��������� ������� � ������ CalQ � ������ ������� ChildClassCar ����� 2
        {
            //Assert
            double distance = 350;
            double consumPK = 20;
            double yearOfIssue = 2008;
            ChildClassCar childClassCar = new ChildClassCar(distance, consumPK, yearOfIssue);
            //Act
            var Q = childClassCar.CalcQ(distance, consumPK);
            //Assert
            Assert.AreEqual(40411, Q);

        }
        [TestMethod]
        public void TestCalcQChildClassCar3 () // ��������� ������� � ������ CalQ � ������ ������� ChildClassCar ����� 3
        {
            //Assert
            double distance = 150;
            double consumPK = 2;
            double yearOfIssue = 2007;
            ChildClassCar childClassCar = new ChildClassCar(distance, consumPK, yearOfIssue);
            //Act
            var Q = childClassCar.CalcQ(distance, consumPK);
            //Assert
            Assert.AreEqual(173103.75, Q);

        }
        [TestMethod]
        public void TestCalcQChildClassCar4 () // ��������� ������� � ������ CalQ � ������ ������� ChildClassCar ����� 4
        {
            //Assert
            double distance = 120;
            double consumPK = 10;
            double yearOfIssue = 2012;
            ChildClassCar childClassCar = new ChildClassCar(distance, consumPK, yearOfIssue);
            //Act
            var Q = childClassCar.CalcQ(distance, consumPK);
            //Assert
            Assert.AreEqual(27765.6, Q);

        }
    }
}
