using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai03 : ContentPage
    {
        public Bai03()
        {
            InitializeComponent();
            createMonkeyList();
        }

        List<Bai03_Class> Monkeys = new List<Bai03_Class>();

        void createMonkeyList()
        {
            Monkeys.Add(new Bai03_Class { Name = "Baboon", Locate = "Africa & Asia", picture = "Baboon.jpg" });
            Monkeys.Add(new Bai03_Class { Name = "Cabuchin Mokey", Locate = "Central & South America", picture = "Capuchin.jpg" });
            Monkeys.Add(new Bai03_Class { Name = "Blue Monkey", Locate = "Central & East Africa", picture = "Blue_Monkey.jpg" });
            Monkeys.Add(new Bai03_Class { Name = "Squirrel Monkey", Locate = "Central & South America", picture = "Squirrel_Monkey.jpg" });
            List03.ItemsSource = Monkeys;
        }
    }
}