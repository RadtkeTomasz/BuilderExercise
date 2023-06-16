namespace BuilderExercise
{
    internal class CarSteeringWheelBuilder : CarBuilder
    {
        public CarSteeringWheelBuilder(Car car) : base(car) { }

        public CarSteeringWheelBuilder OfType(SteeringWheel.SteeringWheelType type)
        {
            this.car.SteeringWheel.Type = type;
            return this;
        }
    }
}
