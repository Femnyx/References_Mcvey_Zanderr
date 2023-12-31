﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mcvey_Zander
{
    internal class Sedan : IAutomobile
    {
        //Takes the get from the class, IAutomobile, and allows it in the class, Sedan, and privatily.
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        //
        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "Dew-it";
        }

        //Stringifies the class, displaying how fast the Sedan is traveling on how many wheels as well as the LicensePlate of the vehicle.
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
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
