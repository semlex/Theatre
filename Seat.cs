namespace Theatre
{
    // Класс места в зрительном зале
    class Seat
    {
        private int row; // Ряд
        private int seat; // Место в ряду
        private string status; // Занято место или свободно
        public Seat(int _row, int _seat, string _status = "free")
        {
            row = _row;
            seat = _seat;
            status = _status;
        }

        public int Row // Получить ряд
        {
            get { return row; }
        }
        public int SeatNum // Получить место
        {
            get { return seat; }
        }
        public string Status // Получить статус места
        {
            get { return status; }
        }
        public void setStatus(string _status) // Задать статус месту
        {
            status = _status;
        }
    }
}
