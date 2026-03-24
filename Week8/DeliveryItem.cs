namespace Practice_8;
abstract class DeliveryItem
{
    protected string trackingNumber;
    public string TrackingNumber
    {
        get => trackingNumber;
        private set
        {
            trackingNumber = value;
        }
    }
    protected double weight;
    public double Weight
    {
        get => weight;
        private set
        {
            weight = value;
        }
    }

    public DeliveryItem(string trackingNumber, double weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Tracking number: {trackingNumber}, weight: {weight}");
    }


}