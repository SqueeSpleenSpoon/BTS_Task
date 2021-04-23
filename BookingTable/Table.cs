namespace BookingTable
{
    public class Table
    {
        public string NumberOfTable { get; set; }
        public int BookingTime { get; set; }
        public string Placement { get; set; }

        Table(string numberOfTable, int bookingTime, string placement)
        {
            NumberOfTable = numberOfTable;
            BookingTime = bookingTime;
            Placement = placement;
        }

        public override string ToString()
        {
            return $"{BookingTime}: {Placement}";
        }
    }
}
