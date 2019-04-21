using System;
using System.Collections.Generic;
using System.Linq;
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
using Prototype.Classes;

namespace Prototype
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Animal firstAnimal = new Animal();

            firstAnimal.Name = "Deer";
            //work on head
            firstAnimal.AHead.Name = "Antlers";
            firstAnimal.AHead.Number = 2;

            Leg leftLeg = new Leg();
            leftLeg.Side = "Left";
            leftLeg.Name = "Hoove";

            Leg rightLeg = new Leg();
            rightLeg.Side = "Right";
            rightLeg.Name = "Hoove";

            firstAnimal.Legs.Add(leftLeg);
            firstAnimal.Legs.Add(rightLeg);

            firstAnimal.ATail.Color = "Brown";

            //Elizabeth copied the firstAnimal(prototype)
            Animal copiedAnimal = (Animal)firstAnimal.Clone();

            ListBoxItem _li = new ListBoxItem();
            _li.Content = "Display the first animal";
            _li.Foreground = System.Windows.Media.Brushes.Red;
            lstList.Items.Add(_li);

            List<String> lst = firstAnimal.Show();
            foreach (string l in lst)
            {
                lstList.Items.Add(l);
            }

            ListBoxItem _li1 = new ListBoxItem();
            _li1.Content = "Display the copied animal";
            _li1.Foreground = System.Windows.Media.Brushes.Red;
            lstList.Items.Add(_li1);

            List<String> lst1 = copiedAnimal.Show();
            foreach (string l in lst1)
            {
                lstList.Items.Add(l);
            }
            
            //Elizabeth play aroud with the copiedAnimal
            copiedAnimal.Name = "Copied Deer";
            copiedAnimal.AHead.Name = "Antlers";
            copiedAnimal.AHead.Number = 1;

            //display the result               
            ListBoxItem _li2 = new ListBoxItem();
            _li2.Content = "Display the copied animal after some play. Elizabeh only made 1 antler for it";
            _li2.Foreground = System.Windows.Media.Brushes.Red;
            lstList.Items.Add(_li2);

            List<String> lst2 = copiedAnimal.Show();
            foreach (string l in lst2)
            {
                lstList.Items.Add(l);
            }
            
            ListBoxItem _li3 = new ListBoxItem();
            _li3.Content = "Display the original prototype";
            _li3.Foreground = System.Windows.Media.Brushes.Red;
            lstList.Items.Add(_li3);

            List<String> lst3 = firstAnimal.Show();
            foreach (string l in lst3)
            {
                lstList.Items.Add(l);
            }
            
            //Elizabeth make an other copy by using the copiedAnimal as the prototype
            Animal secondCopy = (Animal)copiedAnimal.Clone();
            secondCopy.Name = "An other copy";

            //Display the second copy          
            ListBoxItem _li4 = new ListBoxItem();
            _li4.Content = "Display the secnod copy animal";
            _li4.Foreground = System.Windows.Media.Brushes.Red;
            lstList.Items.Add(_li4);

            List<String> lst4 = secondCopy.Show();
            foreach (string l in lst4)
            {
                lstList.Items.Add(l);
            }
        }
    }
}
