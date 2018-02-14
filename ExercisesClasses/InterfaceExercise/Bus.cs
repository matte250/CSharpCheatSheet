using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Bus : IDrivable
    {
        public void Break()
        {
            Console.WriteLine("Bus is braking.");
        }

        public void Gas()
        {
            Console.WriteLine("Bus is gasing.");
        }

        public void StartEngine()
        {
            Console.WriteLine("Bus is starting engine.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bus is stoping engine.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Bus is turning left.");
        }

        public void TurnRight()
        {
            Console.WriteLine("Bus is turning right.");
        }
    }
}