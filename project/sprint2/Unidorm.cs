// Zeeshan Kazmi
// KAZ22527866

// Subclass UniDorm created
public class UniDorm : Accommodation
{
    private int floor;
    private string studentId;
    private bool hasEnsuite;

    // Constructor includes base attributes inherited from Accommodation
    public UniDorm(string name, string address, int doorNum, decimal price, bool isOccupied, int occupantCapacity, int floor, string studentId, bool hasEnsuite)
        : base(name, address, doorNum, price, occupantCapacity, isOccupied)
    {
        this.floor = floor;
        this.studentId = studentId;
        this.hasEnsuite = hasEnsuite;
    }
}
