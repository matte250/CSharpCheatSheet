using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IDrivable
    {
        public void Break()
        {
            Console.WriteLine("Car is braking.");
        }

        public void Gas()
        {
            Console.WriteLine("Car is gasing.");
        }

        public void StartEngine()
        {
            Console.WriteLine("Car is starting engine.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car is stoping engine.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car is turning left.");
        }

        public void TurnRight()
        {
            Console.WriteLine("Car is turning right.");
        }
    }
}
