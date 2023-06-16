namespace BuilderExercise
{
    internal class CarTireBuilder : CarBuilder
    {
        public CarTireBuilder(Car car) : base(car) { }

        public CarTireBuilder OfType(Tires.TireType type)
        {
            this.car.Tires.Type = type;
            return this;
        }
    }
}
