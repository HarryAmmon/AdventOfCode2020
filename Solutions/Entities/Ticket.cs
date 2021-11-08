namespace Solutions.Entities
{
    public class Ticket
    {
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
        public int SeatID
        {
            get
            {
                return RowNumber * 8 + SeatNumber;
            }
        }

        public override string ToString()
        {
            return $"RowNumber: {RowNumber}, SeatNumber: {SeatNumber}";
        }
    }
}