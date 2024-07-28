// Zeeshan Kazmi
// KAZ22527866

// Bookings interface created with 2 methods
using System.Windows;

public interface Bookings
{
    void Book(Accommodation accommodation);
    void CancelBooking(Accommodation accommodation);
}


// Booked accommodation cannot be booked again by anyone
// but can be cancelled by the user who initally booked them
public class Booked : Bookings
{
    public void Book(Accommodation accommodation)
    {
        MessageBox.Show($"Sorry, {accommodation.Name} has already been booked.");
    }

    public void CancelBooking(Accommodation accommodation)
    {
        MessageBox.Show($"You have cancelled your booking for {accommodation.Name}.");
        accommodation.ChangeState(new Available());
        accommodation.IsBooked = false;
    }
}


// Available accommodation can be booked by anyone
// but cannot be cancelled by anyone
class Available : Bookings
{
    public void Book(Accommodation accommodation)
    {
        accommodation.IsBooked = true;
        MessageBox.Show($"You have succesfully booked {accommodation.Name}.");
        accommodation.ChangeState(new Booked());
    }

    public void CancelBooking(Accommodation accommodation)
    {
        MessageBox.Show($"You have succesfully booked {accommodation.Name}.");
    }
}
