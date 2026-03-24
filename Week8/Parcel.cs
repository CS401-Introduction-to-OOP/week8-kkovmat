namespace Practice_8;
class Parcel : DeliveryItem
{
    private string dimensions;
    public string Dimensions
    {
        get => dimensions;
        private set
        {
            dimensions = value;
        }
    }
    public Parcel(string trackingNumber, double weight, string dimensions) : base(trackingNumber, weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost()
    {
        return 50 + (weight * 25);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Dimensions: {dimensions}");
    }
}