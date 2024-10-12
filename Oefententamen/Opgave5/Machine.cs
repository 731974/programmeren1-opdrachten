using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave5
{
    public class Machine
    {

        private string _name;
        public string Name { get { return _name; } private set { _name = value; } }
        private int _numberOfWorkingHours;
        public int NumberOfWorkingHours
        {
            get
            {
                return _numberOfWorkingHours;
            }
            set
            {

                if (value < 0)
                    return;

                _numberOfWorkingHours = value;
            }
        }

        public Machine(string name, int numberOfWorkingHours)
        {

            Name = name;
            NumberOfWorkingHours = numberOfWorkingHours;

        }

        bool NeedsMaintenance
        {
            get
            {
                if(NumberOfWorkingHours >= 10000)
                {
                    return true;
                }

                return false;
            }
        }

       public void DisplayInfo()
        {
            string needsMaintenanceText;
            if (NeedsMaintenance)
            {
                needsMaintenanceText = "yes";
            }
            else
            {
                needsMaintenanceText = "no";
            }

            Console.WriteLine($"Machine name: {Name}");
            Console.WriteLine($"Number of working hours: {NumberOfWorkingHours}");
            Console.WriteLine($"Needs maintenance: {needsMaintenanceText}");

        }
    }
}
