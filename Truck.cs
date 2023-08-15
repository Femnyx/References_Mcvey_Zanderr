using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mcvey_Zander
{
    internal class Truck : IAutomobile
    {
        //Takes the get from the class, IAutomobile, and allows it in class, Truck, and privatily.
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; }

        //Puts statements on the Weight and Wheels. giving it how much the Automobile weights and how many wheels the Automobile has.
        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = licenseNum;

            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        //Stringifies the class, displaying how fast the truck is traveling on how many wheels as well as the LicensePlate of the vehicle.
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }

        //How fast it goes and how much it can slow down or stop.
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
