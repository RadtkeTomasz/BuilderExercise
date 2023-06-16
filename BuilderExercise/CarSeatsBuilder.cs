namespace BuilderExercise
{
    internal class CarSeatsBuilder : CarBuilder
    {
        public CarSeatsBuilder(Car car) : base(car) { }

        public CarSeatsBuilder OfType(Seats.SeatType seatType)
        {
            this.car.Seats.Type = seatType;
            return this;
        }
    }
}
