namespace BuilderExercise
{
    internal class CarEngineBuilder : CarBuilder
    {
        private Car car;
        public CarEngineBuilder(Car car ) : base( car ) { }

        public CarEngineBuilder OfType(Engine.EngineType type)
        {
            this.car.Engine.Type = type;
            return this;
        }
        
        public CarEngineBuilder WithPower(int power)
        {
            this.car.Engine.HorsePower = power;
            return this;
        }
    }
}
