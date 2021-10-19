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
    public partial class Bai04 : ContentPage
    {
        public Bai04()
        {
            InitializeComponent();
        }

        public Bai04(Bai2_class x)
        {
            InitializeComponent();
            Title = x.cityName;
            createHotel(x);
        }

        void createHotel(Bai2_class x)
        {
            List<Bai04_class> hotel = new List<Bai04_class>();

            if (x.cityCode == "dl")
            {
                hotel.Add(new Bai04_class
                {
                    hotelID = "AVRS",
                    cityCode = "dl",
                    hotelName = "Ana Villas Resort and Spa",
                    address = "Đường Lê Lai, Phường 5, Thành phố Đà Lạt, Lâm Đồng",
                    intro = "Ana Mandara Villas Dalat Resort & Spa như một ngôi làng Pháp cổ vẫn giữ trọn vẹn nét đặc trưng từ thiết kế đến vẻ quyến rũ vốn có của kiến trúc Pháp",
                    picture = "Dalat_Ana_Villas_Resort_Spa.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "HC",
                    cityCode = "dl",
                    hotelName = "Colline Hotel",
                    address = "10 Phan Bội Châu, Phường 2, Thành phố Đà Lạt, Lâm Đồng",
                    intro = "Với tông màu gỗ độc lạ, kiến trúc Châu Âu sẽ mang đến sự ấm cúng và gần gũi cho Quý khách.",
                    picture = "Dalat_hotel_colline.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "KH",
                    cityCode = "dl",
                    hotelName = "Kings Hotel",
                    address = "Số 10 Đường Bùi Thị Xuân, Phường 2, Thành phố Đà Lạt, Lâm Đồng",
                    intro = "Tọa lạc tại trung tâm thành phồ Đà Lạt. Khách sạn Kings chính là sự kết hợp hoàn hảo giữa nét đặc trưng cổ kính của thành phố Đà Lạt sương mù nhưng vẫn không kém phần hiện đại và sang trọng theo tiêu chuẩn 4 sao.",
                    picture = "Dalat_Kings_Hotel.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "PHH",
                    cityCode = "dl",
                    hotelName = "Palace Heritage Hotel",
                    address = "2 Đ. Trần Phú, Phường 3, Thành phố Đà Lạt, Lâm Đồng 66100",
                    intro = "Được xây dựng từ năm 1922 của thế kỷ trước, khách sạn Dalat Palace thể hiện đẳng cấp thanh lịch sang trọng với dịch vụ hoàn hảo và vẻ duyên dáng thời thuộc địa Pháp.",
                    picture = "Dalat_Palace_Heritage_Hotel.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "THR",
                    cityCode = "dl",
                    hotelName = "Terracotta Hotel Resort",
                    address = "Phân khu chức năng 7.9, KDL hồ Tuyền Lâm, Lâm Đồng",
                    intro = "Nằm tại vị trí đắc địa bên cạnh hồ Tuyền Lâm, được bao phủ bởi rừng thông xanh, cách trung tâm thành phố Đà Lạt chỉ 10 phút di chuyển bằng xe. Với 240 phòng và 21 villas, khách sạn được xem là một trong những nơi có số lượng phòng nhiều nhất trong khu vực.",
                    picture = "Dalat_Terracotta_Hotel_Resort.jpg"
                });
            }
            else if (x.cityCode == "hn")
            {
                hotel.Add(new Bai04_class
                {
                    hotelID = "AHS",
                    cityCode = "hn",
                    hotelName = "Acoustic Hotel Spa",
                    address = "39 Thợ Nhuộm, Street, Hoàn Kiếm, Hà Nội",
                    intro = "Đến với Acoustic Hotel, bạn sẽ được hòa mình vào với thiên nhiên trong lành, được tham gia các hoạt động vui chơi giải trí, thư giãn nghỉ ngơi để trút bỏ hết những ưu phiền và bộn bề của cuộc sống.",
                    picture = "Hanoi_Acoustic_Hotel_Spa.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "PCHS",
                    cityCode = "hn",
                    hotelName = "Paradise Center Hotel Spa",
                    address = "5 Hàng Vôi, Lý Thái Tổ, Hoàn Kiếm, Hà Nội",
                    intro = "Bất động sản mới nhất của VOT trong phạm vi Hanoi Paradise Centre dự kiến ​​sẽ khai trương vào tháng 10 năm 2019.",
                    picture = "Hanoi_Paradise_Center_Hotel_Spa.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "PGHS",
                    cityCode = "hn",
                    hotelName = "Peridot Grand Hotel Spa",
                    address = "33 Đường Thành, Old Quarter, Hoàn Kiếm, Hà Nội",
                    intro = "Tọa lạc tại thành phố Hà Nội, Peridot Grand Hotel & Spa by AIRA có 2 nhà hàng trong khuôn viên, 3 quán bar, hồ bơi ngoài trời, trung tâm thể dục và quán.",
                    picture = "Hanoi_Peridot_Grand_Hotel_Spa_by_AIRA.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "SLM",
                    cityCode = "hn",
                    hotelName = "Sofitel Legend Metropole",
                    address = "15 P. Ngô Quyền, Street, Hoàn Kiếm, Hà Nội",
                    intro = "Nằm ở trung tâm của thành phố cổ, Sofitel Legend Metropole Hanoi là một khách sạn sang trọng đã từng đoạt giải thưởng mang tính biểu tượng.",
                    picture = "Hanoi_Sofitel_Legend_Metropole.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "SH",
                    cityCode = "hn",
                    hotelName = "Solaria Hotel",
                    address = "22 P. Báo Khánh, Hàng Trống, Hoàn Kiếm, Hà Nội",
                    intro = "Khách sạn Solaria Hà Nội chào đón du khách trong một bầu không khí tinh tế và thân mật, nơi mọi chi tiết đều được suy nghĩ để mang đến cho họ dịch vụ tốt nhất và làm cho kỳ nghỉ của họ thú vị hơn.",
                    picture = "Hanoi_Solaria_Hotel.jpg"
                });
            }
            else if (x.cityCode == "pq")
            {
                hotel.Add(new Bai04_class
                {
                    hotelID = "FR",
                    cityCode = "pq",
                    hotelName = "Fusion Resort",
                    address = "Hamlet 4, Vũng Bầu Beach Ward, Cửa Cạn, Phú Quốc, Kiên Giang",
                    intro = "Cung cấp chỗ ở ấm cúng tại Cửa Cạn, Fusion Resort Phu Quoc có hồ bơi ngoài trời, nhà hàng trong khuôn viên và khu vườn.",
                    picture = "PhuQuoc_Fusion_Resort.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "MR",
                    cityCode = "pq",
                    hotelName = "Movenpick Residences",
                    address = "Ong Lang Beach, Village, Cửa Dương, Tp. Phú Quốc, Kiên Giang",
                    intro = "Nằm ở Bắc đảo, Mövenpick Villas & Residences Phú Quốc giữ trọn sự riêng tư cần thiết.",
                    picture = "PhuQuoc_Movenpick_Residences.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "SHS",
                    cityCode = "pq",
                    hotelName = "Seashells Hotel Spa",
                    address = "1 Đường Võ Thị Sáu, Khu 1, Phú Quốc, Kiên Giang",
                    intro = "Nép mình ở trung tâm của Đảo Phú Quốc, Seashells Phú Quốc Hotel & Spa là cửa ngõ bình dị của bạn đến một trong những hòn đảo đẹp nhất của Việt Nam.",
                    picture = "PhuQuoc_Seashells_Hotel_Spa.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "SH",
                    cityCode = "pq",
                    hotelName = "Sen Hotel",
                    address = "Hẻm 63 Đường Trần Hưng Đạo, TT. Dương Đông, Phú Quốc, Kiên Giang",
                    intro = "Sen Hotel Phu Quoc nằm bên bờ biển ở đảo Phú Quốc, cách Bãi Dài 300 m và Chùa Sùng Hưng 500 m.",
                    picture = "PhuQuoc_Sen_Hotel.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "SBRS",
                    cityCode = "pq",
                    hotelName = "Sunset Beach Resort Spa",
                    address = "100C2 Đường Trần Hưng Đạo, Str, Phú Quốc, Kiên Giang",
                    intro = "Sunset Beach Resort & Spa được thiết kế theo phong cách kiến ​​trúc hiện đại, không chỉ chú trọng đến trải nghiệm và sự thoải mái của du khách mà còn mang đến cho khách hàng cảm giác hòa mình vào thiên nhiên, đặc biệt là với bãi biển Dương Đông xinh đẹp của Phú Quốc.",
                    picture = "PhuQuoc_Sunset_Beach_Resort_Spa.jpg"
                });
            }
            else if (x.cityCode == "hcm")
            {
                hotel.Add(new Bai04_class
                {
                    hotelID = "C",
                    cityCode = "hcm",
                    hotelName = "Caravelle",
                    address = "19-23 Lam Son Square, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                    intro = "Tọa lạc tại trung tâm thành phố, khách sạn cách các địa danh và địa điểm mang tính biểu tượng như Nhà hát Thành phố Sài Gòn, còn được gọi là Nhà hát Lớn, Nhà thờ Đức Bà, Đường Đồng Khởi lịch sử, Phố đi bộ Nguyễn Huệ hiện đại và huyền thoại. Chợ Bến Thành.",
                    picture = "Saigon_Caravelle.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "GH",
                    cityCode = "hcm",
                    hotelName = "Grand Hotel",
                    address = "8 Đồng Khởi, Bến Nghé, Quận 1, Thành phố Hồ Chí Minh",
                    intro = "Saigon Grand Hotel là một địa điểm được sắp xếp trong danh mục Du Lịch & Vận Chuyển và Saigon Grand Hotel nằm ở địa chỉ Ho Chi Minh City..",
                    picture = "Saigon_Grand_Hotel.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "ILDH",
                    cityCode = "hcm",
                    hotelName = "Icon LifeStyle Design Hotel",
                    address = "65-67 Hai Bà Trưng, Ward, Quận 1, Thành phố Hồ Chí Minh",
                    intro = "Tọa lạc ở Thành phố Hồ Chí Minh, Icon Saigon - LifeStyle Design Hotel có nhà hàng, hồ bơi ngoài trời, trung tâm thể dục và quầy bar.",
                    picture = "Saigon_Icon_LifeStyle_Design_Hotel.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "TMDK",
                    cityCode = "hcm",
                    hotelName = "The Myst Dong Khoi",
                    address = "4-6-8 Hồ Huấn Nghiệp, street, Quận 1, Thành phố Hồ Chí Minh",
                    intro = "Đến với The Myst Đồng Khởi, du khách sẽ được quay trở về quãng thời gian yên bình với những nét đẹp văn hóa mang hồn phách Sài Gòn.",
                    picture = "Saigon_The_Myst_Dong_Khoi.jpg"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "WH",
                    cityCode = "hcm",
                    hotelName = "Winsuites",
                    address = "32 Lê Lai, St, Quận 1, Thành phố Hồ Chí Minh",
                    intro = "Kỳ nghỉ mơ ước trong tầm tay. Ưu đãi cực lớn. Đừng đợi. Đặt ngay! Sẵn có 24 giờ. Dễ dàng. Thuận tiện. Thanh toán đa dạng. Types: Hotel, Resort, Villa, Homestay.",
                    picture = "Saigon_Winsuites.jpg"
                });
            }
            else if (x.cityCode == "vt")
            {
                hotel.Add(new Bai04_class
                {
                    hotelID = "FS",
                    cityCode = "vt",
                    hotelName = "Fusion Suites",
                    address = "2 Trương Công Định, Phường 1, Thành phố Vũng Tầu, Bà Rịa - Vũng Tàu",
                    intro = "Tọa lạc tại thành phố Vũng Tàu, cách Bãi Dâu 2,9 km, Fusion Suites Vung Tau cung cấp chỗ nghỉ với nhà hàng, chỗ đỗ xe riêng miễn phí, hồ bơi ngoài trời.",
                    picture = "VungTau_Fusion_Suites.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "MH",
                    cityCode = "vt",
                    hotelName = "Malibu Hotel",
                    address = "263 Lê Hồng Phong, Phường Thắng Tam, ward, Bà Rịa - Vũng Tàu",
                    intro = "Tọa lạc trong một tòa nhà chọc trời màu xám, hiện đại và nổi bật, Malibu Hotel cung cấp chỗ nghỉ đẹp mắt tại thành phố Vũng Tàu.",
                    picture = "VungTau_Malibu_Hotel.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "MBRS",
                    cityCode = "vt",
                    hotelName = "Marina Bay Resort Spa",
                    address = "115 Trần Phú, Phường 5, Thành phố Vũng Tầu, Bà Rịa - Vũng Tàu",
                    intro = "Marina Bay Vung Tau Resort & Spa Website Là Lựa Chọn Lý Tưởng Để Bạn Và Những Người Thân Yêu Tận Hưởng Một Kỳ Nghỉ Tuyệt Vời, Lãng Mạn.",
                    picture = "VungTau_Marina_Bay_Resort_Spa.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "PH",
                    cityCode = "vt",
                    hotelName = "Pullman",
                    address = "15 Đường Thi Sách, Street, Thành phố Vũng Tầu, Bà Rịa - Vũng Tàu",
                    intro = "Khách sạn Pullman Vũng Tàu (Pullman Vung Tau) - Miễn phí 1 trẻ dưới 12 tuổi. Lý tưởng cho kì nghỉ gia đình. Siêu khuyến mãi Xuân Hè 2021.",
                    picture = "VungTau_Pullman.webp"
                });

                hotel.Add(new Bai04_class
                {
                    hotelID = "TIH",
                    cityCode = "vt",
                    hotelName = "The Imperial Hotel",
                    address = "159 Thùy Vân, Phường Thắng Tam, Thành phố Vũng Tầu, Bà Rịa - Vũng Tàu",
                    intro = "The Imperial Hotel Vung Tau có khu vực bãi biển riêng và cung cấp chỗ nghỉ với lối trang trí thời Victoria ở khu vực Bãi Sau.",
                    picture = "VungTau_The_Imperial_Hotel.webp"
                });
            }

            list04.ItemsSource = hotel;
        }
    }
}