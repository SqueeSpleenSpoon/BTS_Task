using NUnit.Framework;

namespace BookingTable.Tests
{
    public class TableTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TableTest_BookingMethod()
        {
            var table = new Table();
            var table2 = new Table();

            table.AddTable(table2);
            table2.BookedTime = 10;
            table.BookedTime = 10;

            var findTable = table.TableList.Find(table => table.BookedTime != table2.BookedTime);


            //table.TableList.Find(table2, table.TableList);
            //var findTable = TableList.Find(table => table.BookedTime != bookedTime);

            //var inputTime = 13;


            Assert.IsNull(findTable);
        }
    }
}