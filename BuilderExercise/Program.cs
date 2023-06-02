
using BuilderExercise;
using System.ComponentModel.DataAnnotations;

var car = new CarBuilder()
    .WithModelName("Fiesta")
    .WithSeats().OfType(Seats.SeatType.Leather)
    .WithEngine().OfType(Engine.EngineType.Diesel).WithPower(220)
    .WithTires().OfType(Tires.TireType.Winter)
    .WithSteeringWheel().OfType(SteeringWheel.SteeringWheelType.Casual).Build();

var carPrice = car.TotalPrice;

public class Car
{
    public decimal TotalPrice { get => Engine.Price + Tires.Price + Seats.Price + Paint.Price + SteeringWheel.Price; }
    public string ModelName { get; set; }

    public Engine Engine { get; set; }
    public Tires Tires { get; set; }
    public Seats Seats { get; set; }
    public Paint Paint { get; set; }
    public SteeringWheel SteeringWheel { get; set; }
}

public class Tires
{
    public TireType Type { get; set; } = TireType.Summer;

    public TireBrand Brand { get; set; } = TireBrand.Continental;

    public decimal Price { get => Type == TireType.Summer ? 699.00M : 1099.00M; }
    public enum TireType
    {
        Winter,
        Summer
    }

    public enum TireBrand
    {
        Michellin,
        Continental,
        Ferrari,
        XiaoWang,
        Jelcz
    }
}

public class Paint
{
    public CoatType Type { get; set; } = CoatType.Classic;

    public decimal Price { get => Type == CoatType.Classic ? 2899.00M : 12999.00M; }
    public enum CoatType
    {
        Classic,
        Metallic
    }
}

public class Seats
{
    public SeatType Type { get; set; } = SeatType.Poliester;
    public decimal Price { get => Type == SeatType.Poliester ? 5899.00M : 16999.00M; }

    public enum SeatType
    {
        Poliester,
        Leather
    }
}

public class Engine
{
    public EngineType Type { get; set; } = EngineType.Gas;

    [Range(100,260)]
    public int HorsePower { get; set; } = 100;
    public decimal Price { get => GetPrice(); }
    public decimal GetPrice()
    {
        return Type switch
        {
            EngineType.Gas => (decimal)(23999 * (0.1* HorsePower )),
            EngineType.Diesel =>(decimal)( 28999 * (0.1 * HorsePower)),
            EngineType.Electric => (decimal)(46999 * (0.1) * HorsePower),
            _ => throw new InvalidOperationException("Engine type not found"),
        };
    }
    public enum EngineType
    {
        Electric,
        Diesel,
        Gas
    }
}

public class SteeringWheel
{
    public SteeringWheelType Type { get; set; } = SteeringWheelType.Casual;

    public decimal Price { get => Type == SteeringWheelType.Casual ? 4599.00M : 11999.00M; }
    public enum SteeringWheelType
    {
        Casual,
        Sports
    }
}





