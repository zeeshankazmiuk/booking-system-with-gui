// Zeeshan Kazmi
// KAZ22527866

// Subclass Sofa created
public class Sofa : Accommodation
{
    private string material;

    // Constructor includes base attributes inherited from Accommodation
    public Sofa(string name, string address, int doorNum, decimal price, bool isOccupied, int occupantCapacity, string material)
        : base(name, address, doorNum, price, occupantCapacity, isOccupied)
    {
        this.material = material;

    }

    // Overide Print method to extra line specific to Sofa
    public override void Print()
    {
        base.Print();
    }
}
