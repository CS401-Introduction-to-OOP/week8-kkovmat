namespace Practice_8;
class Letter : DeliveryItem
{
    public Letter(string trackingNumber, double weight) : base(trackingNumber, weight)
    {
        
    }

    public override double CalculateCost()
    {
        return 15 + (weight * 10);
    }
}