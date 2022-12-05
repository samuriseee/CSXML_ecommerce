using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKi.Areas.admin.Models
{
    public class ThongKeSanPhamBanChay
    {

        [StringLength(15)]
        [DisplayName("Mã Giày")]
        public string maGiay { get; set; }

        [StringLength(100)]
        [DisplayName("Tên Giày")]
        public string tenGiay { get; set; }

        [Column(TypeName = "money")]
        [DisplayName("Giá Tiền")]
        public decimal giaBan { get; set; }

        [DisplayName("Số Lượng Đã Bán")]
        public int soLuongBan { get; set; }


    }
}
