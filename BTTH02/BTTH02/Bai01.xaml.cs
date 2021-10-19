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
    public partial class Bai01 : ContentPage
    {
        public Bai01()
        {
            InitializeComponent();
            string[] dsMonHoc = new string[]
            {
                "Nhập môn lập trình",
                "Giải tích",
                "Đại số tuyến tính",
                "Giới thiệu ngành",
                "Pháp luật đại cương",
                "Giáo dục Quốc phòng"
            };
            List01.ItemsSource = dsMonHoc;
        }
    }
}