namespace Solutions.Entities
{
    public class Ticket
    {
        public int RowNumber { get; set; }

        public string BinaryIndicator { get; set; }
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
            return $"{BinaryIndicator}:{SeatID} -- RowNumber: {RowNumber}, SeatNumber: {SeatNumber}";
        }
    }
}