using System;

namespace BookingTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();

            table.AddTable(new Table(1, 0, "In hole"));
            table.AddTable(new Table(2, 0, "In corner"));
            table.AddTable(new Table(3, 0, "In hole"));
            table.AddTable(new Table(4, 0, "In hole"));
            table.AddTable(new Table(5, 0, "In corner"));
            table.AddTable(new Table(6, 0, "In hole"));

            while (true)
            {
                Console.WriteLine();
                table.Booking();
            }
        }
    }
}
