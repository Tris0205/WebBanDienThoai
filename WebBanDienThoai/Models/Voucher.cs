//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;

    public partial class Voucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voucher()
        {
            this.Customer = new HashSet<Customer>();
            this.Order = new HashSet<Order>();
        }

        public int IdVoucher { get; set; }
        [Display(Name = "Ảnh voucher")]
        public string Images { get; set; }
        [Display(Name = "Ngày áp dụng")]
        public Nullable<System.DateTime> DateStart { get; set; }
        [Display(Name = "Ngày kết thúc")]
        public Nullable<System.DateTime> DateEnd { get; set; }

        [DisplayFormat(DataFormatString = "{0:0,0₫}")]
        [Display(Name = "Giá sản phẩm")]
        public Nullable<decimal> Price { get; set; }
        [Display(Name = "Trạng Thái")]
        public Nullable<bool> Status { get; set; }
        [Display(Name = "Tên voucher")]
        [Required(ErrorMessage = "Tên voucher Không Được Bỏ Trống")]
        [MaxLength(250, ErrorMessage = "Tên voucher Không Được Vượt Quá 250 Kí Tự")]
        public string NameVoucher { get; set; }
        [Display(Name = "Mô tả ngắn")]
        [AllowHtml]
        public string DescriptShort { get; set; }
        [AllowHtml]
        [Column(TypeName = "ntext")]
        [Display(Name = "Nội Dung")]
        public string Content { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        [Display(Name = "Mã voucher")]
        [Required(ErrorMessage = "Mã voucher Không Được Bỏ Trống")]
        [MaxLength(250, ErrorMessage = "Tên voucher Không Được Vượt Quá 250 Kí Tự")]
        public string Code { get; set; }
        [Display(Name = "Số Lượng")]
        [Required(ErrorMessage = "Số Lượng Không Được Bỏ Trống")]
        public int Quanlity { get; set; }
        public string Author { get; set; }
        [Display(Name = "Đường Dẫn URL")]
        [Required(ErrorMessage = "URL Không Được Bỏ Trống")]
        [MaxLength(250, ErrorMessage = "URL Không Được Vượt Quá 250 Kí Tự")]
        [Index(IsUnique = true)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer> Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
