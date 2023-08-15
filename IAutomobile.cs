using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mcvey_Zander
{
    internal interface IAutomobile
    {

       //Sets a get; for the variables "Speed," "Wheels," and "LicensePlate."
        public double Speed { get; }

        
        public int Wheels { get; }

        
        public string LicensePlate { get; }

        //Lets the IAutomobile class Stringify, allowing the variables to be used on other classes if you allow it.
        public void Stringify();


    }
}
