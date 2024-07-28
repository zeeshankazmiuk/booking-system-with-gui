using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace sprint3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddItems_Click(object sender, RoutedEventArgs e)
        {
            // clear previous elements from list
            listItems.Items.Clear();

            // create objects
            House wayneManor = new House("Wayne Manor", "Negra Arroyo Lane", 308, 69000, 4, false, 2, 3, 2, true);
            Hotel transylvania = new Hotel("Transylvania", "Spooky Lane", 21, 420000, 2, false, 36, true, true, true, false);
            Flat happyFlat = new Flat("Happy Flat", "Happy Street", 1, 99999, 1, false, 0, 1, 1, true);
            Sofa susSofa = new Sofa("Craigslist Sofa", "Shady Street", 666, 5, false, 1, "fabric");
            UniDorm wesleyHall = new UniDorm("Wesley Hall", "Southlands College", 1, 8000, false, 1, 2, "KAZ226969", true);

            // add objects to list box
            listItems.Items.Add(wayneManor.fetchName());
            listItems.Items.Add(transylvania.fetchName());
            listItems.Items.Add(happyFlat.fetchName());
            listItems.Items.Add(susSofa.fetchName());
            listItems.Items.Add(wesleyHall.fetchName());

            // clear elements from combo box
            accomComboBox.Items.Clear();

            // add objects to combo box
            accomComboBox.Items.Add(new { value = wayneManor, displayValue = wayneManor.fetchName() });
            accomComboBox.Items.Add(new { value = transylvania, displayValue = transylvania.fetchName() });
            accomComboBox.Items.Add(new { value = happyFlat, displayValue = happyFlat.fetchName() });
            accomComboBox.Items.Add(new { value = susSofa, displayValue = susSofa.fetchName() });
            accomComboBox.Items.Add(new { value = wesleyHall, displayValue = wesleyHall.fetchName() });

            // find value and display value
            accomComboBox.SelectedValuePath = "value";
            accomComboBox.DisplayMemberPath = "displayValue";
        }

        private void accom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // retrieve selected element
            var selection = accomComboBox.SelectedItem as dynamic;

            // book
            Accommodation selectedAccommodation = selection.value;
            selectedAccommodation.Book(selectedAccommodation);
        }
    }
}
