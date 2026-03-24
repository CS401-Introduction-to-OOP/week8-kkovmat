namespace Practice_8;
class CargoContainer<T> where T : DeliveryItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public double GetTotalCost()
    {
        double totalCost = 0; 
        foreach (T item in items)
        {
            totalCost += item.CalculateCost();
        }
        return totalCost;
    }
}