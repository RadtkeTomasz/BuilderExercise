using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderExercise
{
    internal class CarSteeringWheelBuilder : CarBuilder
    {
        private Car car;
        public CarSteeringWheelBuilder(Car car) : base(car) { }

        public CarSteeringWheelBuilder OfType(SteeringWheel.SteeringWheelType type)
        {
            this.car.SteeringWheel.Type = type;
            return this;
        }
    }
}
