// Zeeshan Kazmi
// KAZ22527866

// Subclass Hotel created
public class Hotel : Accommodation
{
    private int floor;
    private bool servesFood;
    private bool hasDoublebed;
    private bool petsAllowed;
    private bool hasBalcony;

    // Constructor includes base attributes inherited from Accommodation
    public Hotel(string Name, string Address, int DoorNum, decimal Price, int OccupantCapacity, bool isBooked, int Floor, bool ServesFood, bool HasDoublebed, bool PetsAllowed, bool HasBalcony)
        : base(Name, Address, DoorNum, Price, OccupantCapacity, isBooked)
    {
        floor = Floor;
        servesFood = ServesFood;
        hasDoublebed = HasDoublebed;
        petsAllowed = PetsAllowed;
        hasBalcony = HasBalcony;
    }
}

