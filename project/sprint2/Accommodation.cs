// Zeeshan Kazmi
// KAZ22527866

// Accommodation class created 
using System;

public abstract class Accommodation
{
    // Attributes declared
    public Bookings BookState;
    public string Name { get; private set; }
    protected string Address { get; private set; }
    protected int DoorNum { get; private set; }
    protected decimal Price { get; private set; }
    protected int OccupantCapacity { get; private set; }
    public bool IsBooked { get; set; }

    // Constructor
    public Accommodation(string name, string address, int doorNum, decimal price, int occupantCapacity, bool isBooked)
    {
        Name = name;
        Address = address;
        DoorNum = doorNum;
        Price = price;
        OccupantCapacity = occupantCapacity;
        IsBooked = isBooked;

        // Initialize the current booking state
        this.BookState = new Available();
    }

    // Method to get name
    public string fetchName()
    {
        return $"{this.GetType()}: {this.Name}";
    }

    // Print method declared and made virtual to be overidden
    public virtual void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Door: {DoorNum}");
        Console.WriteLine($"Price: £{Price}");
        Console.WriteLine($"Occupant Capacity: {OccupantCapacity}");
        Console.WriteLine($"Is booked: {IsBooked}");
    }

    // Method to switch states declared
    public void ChangeState(Bookings newBookingState)
    {
        BookState = newBookingState;
    }

    // Method to book declared
    public void Book(Accommodation accommodation)
    {
        BookState.Book(accommodation);
    }

    // Method to cancel booking declared
    public void CancelBooking(Accommodation accommodation)
    {
        BookState.CancelBooking(accommodation);
    }
}
