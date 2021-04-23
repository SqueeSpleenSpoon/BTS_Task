using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingTable;

namespace BookingTable.Tests
{
    class UnitTest2
    {       

        [Test]
        public void Test1()
        {
            Table table = new Table();
            table.AddTable(table);
            Assert.IsNotEmpty(table.TableList);
        }

    }
}
