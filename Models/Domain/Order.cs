using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneWeb.Models.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        [DisplayName("Ngày tạo hoá đơn")]
        public DateTime OrderDate { get; set; }
        [DisplayName("Tên khách hàng")]
        [Required(ErrorMessage = "Phải nhập tên khách hàng!!")]
        public string TenKhachHang { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Phải nhập Email !!")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Nhập sai Email !!")]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        [StringLength(maximumLength: 10, MinimumLength = 0, ErrorMessage = "Phải có 10 số !!")]
        [RegularExpression(@"^\(?([0-9]{3})\(?([0-9]{7})$", ErrorMessage = "Phải nhập sô!!!!!")]
        public string SoDienThoai { get; set; }
        [DisplayName("Địa chỉ giao hàng")]
        [Required(ErrorMessage = "Phải nhập địa chỉ giao hàng !!")]
        public string DiaChiGiaoHang { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
