namespace BuilderExercise
{
    internal class CarTireBuilder : CarBuilder
    {
        private Car car;
        public CarTireBuilder(Car car) : base(car) { }

        public CarTireBuilder OfType(Tires.TireType type)
        {
            this.car.Tires.Type = type;
            return this;
        }
    }
}
