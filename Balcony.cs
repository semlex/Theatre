namespace Theatre
{
    class Balcony : Zone // Балкон
    {
        public Balcony(int _quantityRows, int _quantitySeats, double _price) :
            base("Balcony", _quantityRows, _quantitySeats, _price)
        { }
    }
}
