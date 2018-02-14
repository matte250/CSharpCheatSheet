using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;

namespace MyClassesTest
{
    // AAA
    // Arange - Initialize variables.
    // Act - Invoke methods to test.
    // Assert - Verify the act.

    [TestClass]
    public class FileProcessTest
    {
        private const string BAD_FILE_NAME = @"C:\BadFileName.bad";
        [TestMethod]
        public void FileNameDoesExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(@"C:\Windows\Regedit.exe");

            Assert.IsTrue(fromCall);
                
        }
        [TestMethod]
        public void FileNameDoesNotExist()
        {
            FileProcess fp = new FileProcess();
            bool fromCall;

            fromCall = fp.FileExists(BAD_FILE_NAME);

            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArumentNullException()
        {
            FileProcess fp = new FileProcess();
            fp.FileExists("");
        }
        [TestMethod]
          public void FileNameNullOrEmpty_ThrowsArumentNullException_UsingTryCatch()
        {
            FileProcess fp = new FileProcess();

            try
            {
                fp.FileExists("");
            }
            catch (ArgumentNullException)
            {
                return;
            }

            Assert.Fail("Call to FileExists did NOT throw an ArgumentNullException.");
        }
    }
}
