using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace BookingTable.Tests
{
    public class TableTest
    {
        private Table mainTable;

        [SetUp]
        public void Setup()
        {
            mainTable = new Table();

            mainTable.AddTable(new Table(1, 0, "In hole"));
            mainTable.AddTable(new Table(2, 0, "In corner"));
            mainTable.AddTable(new Table(3, 0, "In hole"));
            mainTable.AddTable(new Table(4, 0, "In hole"));
            mainTable.AddTable(new Table(5, 0, "In corner"));
            mainTable.AddTable(new Table(6, 0, "In hole"));
        }

        [Test]
        public void TableTest_SuccessedBookingMethod()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("10");
            Console.SetIn(input);

            mainTable.Booking();

            var expectedOutput = "Hello, choose time: 10, 12, 14, 16, 18, 20\r\nYou have successfully booked a table!  \nPlace: In hole, Number: 1, Time: 10\r\n";

            Assert.AreEqual(expectedOutput, output.ToString());   
        }

        [Test]
        public void TableTest_IncorrectTime()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader("13");
            Console.SetIn(input);

            mainTable.Booking();

            var expectedOutput = "Hello, choose time: 10, 12, 14, 16, 18, 20\r\nYou write incorrect time";

            Assert.AreEqual(expectedOutput, output.ToString());
        }

        [Test]
        public void TableTest_TryToReserve7thTable()
        {
            var outputs = new List<StringWriter>();

            for (int i = 0; i < 7; i++)
            {
                var temporaryOutput = new StringWriter();
                Console.SetOut(temporaryOutput);

                var input = new StringReader("10");
                Console.SetIn(input);

                mainTable.Booking();

                outputs.Add(temporaryOutput);
            }

            var output = "";

            foreach (var item in outputs)
            {
                output += $"{ item.ToString()} ";
            }

            var expectedOutput = "Hello, choose time: 10, 12, 14, 16, 18, 20\r\nYou have successfully booked a table!  \nPlace: In hole, Number: 1, Time: 10\r\n Hello, choose time: 10, 12, 14, 16, 18, 20\r\nYou have successfully booked a table!  \nPlace: In corner, Number: 2, Time: 10\r\n Hello, choose time: 10, 12, 14, 16, 18, 20\r\nYou have successfully booked a table!  \nPlace: In hole, Number: 3, Time: 10\r\n Hello, choose time: 10, 12, 14, 16, 18, 20\r\nYou have successfully booked a table!  \nPlace: In hole, Number: 4, Time: 10\r\n Hello, choose time: 10, 12, 14, 16, 18, 20\r\nYou have successfully booked a table!  \nPlace: In corner, Number: 5, Time: 10\r\n Hello, choose time: 10, 12, 14, 16, 18, 20\r\nYou have successfully booked a table!  \nPlace: In hole, Number: 6, Time: 10\r\n Hello, choose time: 10, 12, 14, 16, 18, 20\r\nSorry, we dont have free table for this time( \r\n ";

            Assert.AreEqual(expectedOutput, output);
        }
    }
}