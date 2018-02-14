using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IDrivable
    {
        // Exercise - Interfaces:
        // Create the interface IDriveable with the abstract methods void StartEngine(), void
        // StopEngine(), void Gas(), void Break(), void TurnLeft() and void TurnRight(). Then create 3 classes
        // Car, Motorbike and Bus.Implement the interface IDriveable to all three classes.Then create a
        // method that takes an IDriveable object as input parameter that will call the methods in following
        // sequence: StartEngine() -> Gas() -> TurnLeft() -> TurnRight() -> TurnRight() -> Break() and lastly
        // StopEngine(). Try calling the method with all three interfaces. You do not have to create any real
        // logic inside the methods, just print a distinct message like “Turned left (Motorbike)” and “Started
        // the engine (Car)”s

        void StartEngine();
        void StopEngine();
        void Gas();
        void Break();
        void TurnLeft();
        void TurnRight();

    }
}
