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

    public partial class OrderDetail
    {
        public int orderDetailID { get; set; }
        public int orderID { get; set; }
        [Display(Name = "Sản Phẩm")]
        public int ProductID { get; set; }

        [Display(Name = "Giá")]
        public decimal Price { get; set; }

        [Display(Name = "Số Lượng")]
        public int Quanlity { get; set; }
        [Display(Name = "Thành Tiền")]
        public decimal TotalProduct { get; set; }
        [Display(Name = "Trạng Thái")]
        public bool Status { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}