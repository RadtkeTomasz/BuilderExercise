namespace BuilderExercise
{
    internal class CarBuilder
    {
        protected Car car;

        public CarBuilder()
        {
            car = new Car();
        }

        public CarBuilder(Car car)
        {
            this.car = car;
        }

        public CarBuilder WithModelName(string name)
        {
            car.ModelName = name;
            return this;
        }
        public CarEngineBuilder WithEngine() => new(car);

        public CarSeatsBuilder WithSeats() => new(car);

        public CarSteeringWheelBuilder WithSteeringWheel() => new(car);

        public CarTireBuilder WithTires() => new(car);

        public Car Build()
        {
            return this.car;
        }

        public static implicit operator Car (CarBuilder carBuilder)
        {
            return carBuilder.car;
        }   
    }
}
