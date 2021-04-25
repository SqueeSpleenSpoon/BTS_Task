using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingTable
{
    public class Table
    {
        public int Id { get; set; }
        public int BookedTime { get; set; }
        public string Place { get; set; }

        public List<Table> TableList = new List<Table>();


    public Table(int id, int bookedTime, string place)
        {
            Id = id;
            bookedTime = BookedTime;
            Place = place;
        }
        public Table()
        {

        }

        public void AddTable(Table table)
        {
            TableList.Add(table);
        }

        public void Booking()
        {
            Console.WriteLine("Hello, choose time: 10, 12, 14, 16, 18, 20");

            var inputTime = Console.ReadLine();

            int bookedTime = 0;

            switch (inputTime)
            {
                case "10":
                    bookedTime = 10;
                    break;
                case "12":
                    bookedTime = 12;
                    break;
                case "14":
                    bookedTime = 14;
                    break;
                case "16":
                    bookedTime = 16;
                    break;
                case "18":
                    bookedTime = 18;
                    break;
                case "20":
                    bookedTime = 20;
                    break;
                default:
                    Console.WriteLine("You write incorrect time");
                    break;

            }

            var findTable = TableList.Find(table => table.BookedTime != bookedTime);

            if(findTable == null)
            {
                Console.WriteLine("Sorry, we dont have free table for this time( ");
            }
            else 
            {
                findTable.BookedTime = bookedTime;
                Console.WriteLine($"You have successfully booked a table!  \nPlace: {findTable.Place}, Number: {findTable.Id}, Time: {findTable.BookedTime}");
            }     
        }
    }
}
