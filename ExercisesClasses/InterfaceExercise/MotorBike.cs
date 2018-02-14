using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class MotorBike : IDrivable
    {
        public void Break()
        {
            Console.WriteLine("Motorbike is braking.");
        }

        public void Gas()
        {
            Console.WriteLine("Motorbike is gasing.");
        }

        public void StartEngine()
        {
            Console.WriteLine("Motorbike is starting engine.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Motorbike is stoping engine.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Motorbike is turning left.");
        }

        public void TurnRight()
        {
            Console.WriteLine("Motorbike is turning right.");
        }
    }
}