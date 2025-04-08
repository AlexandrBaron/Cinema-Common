namespace Cinema.Common
{
    public class SeatViewModel
    {
        public int SeatNumber { get; set; }
        public int RowNumber { get; set; }
        public Guid SeatId { get; set; }
        public bool IsOccupied { get; set; }
    }
}
