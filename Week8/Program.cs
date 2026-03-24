namespace Practice_8;
class Program
{
    static void Main()
    {
        Letter letter1 = new Letter("er2t1", 10);
        Letter letter2 = new Letter("wty35", 55);
        Parcel parcel1 = new Parcel("wrfgk2", 40, "20x10x10");
        Parcel parcel2 = new Parcel("lkjr1", 4, "5x5x5");
        letter1.PrintInfo();
        parcel2.PrintInfo();
        Console.WriteLine(letter1.CalculateCost());

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);
        Console.WriteLine(myCargo.GetTotalCost());
    }
}