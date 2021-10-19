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
    public partial class Bai2 : ContentPage
    {
        public Bai2()
        {
            InitializeComponent();
            createCityList();
        }

        List<Bai2_class> cityList = new List<Bai2_class>();

        void createCityList()
        {
            cityList.Add(new Bai2_class { cityCode = "hn", cityName = "Hà Nội", picture = "hanoi.jpg" });
            cityList.Add(new Bai2_class { cityCode = "pq", cityName = "Phú Quốc", picture = "phuquoc.jpg" });
            cityList.Add(new Bai2_class { cityCode = "hcm", cityName = "TP Hồ Chí Minh", picture = "hcm.jpg" });
            cityList.Add(new Bai2_class { cityCode = "dl", cityName = "Đà Lạt", picture = "dalat.jpg" });
            cityList.Add(new Bai2_class { cityCode = "vt", cityName = "Vũng Tàu", picture = "vungtau.jpg" });
            List02.ItemsSource = cityList;
        }

        private void List02_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (List02.SelectedItem != null)
            {
                Bai2_class city = (Bai2_class)List02.SelectedItem;
                Navigation.PushAsync(new Bai04(city));
            }
        }
    }
}