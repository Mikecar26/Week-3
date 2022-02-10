
namespace Week_3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Input the car's make, model, then speed(mph)");
                cars[i] = new Car(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), 40);

            }
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i].DisplayInfo();
            }

        }
    }
    class Car
    {
        string _make;
        string _model;
        int _speed;
        int _demerits;
        int _speedLimit;


        public Car(string make, string model, int speed, int speedlimit)
        {
            this._make = make;
            this._model = model;
            this._speed = speed;
            this._speedLimit = speedlimit;
        }


        string speedLimit()
        {
            if (_speed <= _speedLimit)
            {
                return "OK";
            }
            else
            {
                return calculateDemerits();
            }
        }
        string calculateDemerits()
        {
            _demerits = (_speed - _speedLimit) / 5;
            if (_demerits >= 10)
                return _demerits.ToString() + " denerits <LICENSE SUSPENDED>";
            else
                return _demerits.ToString() + " denerits";

        }
        public void DisplayInfo()
        {
            Console.WriteLine(_make + " " + _model + " " + _speed + " mph " + this.speedLimit());
            Console.ReadKey();
        }

    }
}
