using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfaceExercise;

namespace InterfaceExerciseTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CarConsoleOutput()
        {

            // Arange
            string expectedString = "Car is starting engine.\r\nCar is gasing.\r\nCar is turning left.\r\nCar is turning right.\r\nCar is turning right.\r\nCar is braking.\r\nCar is stoping engine.\r\n";
            string actuallString;

            IDrivable vehicle = new Car();

            // Act
            using(var outputCapture = new OutputCapture())
            {
                vehicle.StartEngine();
                vehicle.Gas();
                vehicle.TurnLeft();
                vehicle.TurnRight();
                vehicle.TurnRight();
                vehicle.Break();
                vehicle.StopEngine();
                actuallString = outputCapture.Captured.ToString();
            }

            // Assert
            Assert.AreEqual(actuallString, expectedString);
        }
        [TestMethod]
        public void BusConsoleOutput()
        {
            string expectedString = "Bus is starting engine.\r\nBus is gasing.\r\nBus is turning left.\r\nBus is turning right.\r\nBus is turning right.\r\nBus is braking.\r\nBus is stoping engine.\r\n";
            string actuallString;

            IDrivable vehicle = new Bus();

            // Act
            using (var outputCapture = new OutputCapture())
            {
                vehicle.StartEngine();
                vehicle.Gas();
                vehicle.TurnLeft();
                vehicle.TurnRight();
                vehicle.TurnRight();
                vehicle.Break();
                vehicle.StopEngine();
                actuallString = outputCapture.Captured.ToString();
            }

            // Assert
            Assert.AreEqual(actuallString, expectedString);
        }
        [TestMethod]
        public void MotorbikeConsoleOutput()
        {
            string expectedString = "Motorbike is starting engine.\r\nMotorbike is gasing.\r\nMotorbike is turning left.\r\nMotorbike is turning right.\r\nMotorbike is turning right.\r\nMotorbike is braking.\r\nMotorbike is stoping engine.\r\n";
            string actuallString;

            IDrivable vehicle = new MotorBike();

            // Act
            using (var outputCapture = new OutputCapture())
            {
                vehicle.StartEngine();
                vehicle.Gas();
                vehicle.TurnLeft();
                vehicle.TurnRight();
                vehicle.TurnRight();
                vehicle.Break();
                vehicle.StopEngine();
                actuallString = outputCapture.Captured.ToString();
            }

            // Assert
            Assert.AreEqual(actuallString, expectedString);
        }
    }
}
