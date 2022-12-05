﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CuoiKi.Areas.admin.Models
{
    public class NguoiDung
    {
        public string id { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập họ tên")]
        [Display(Name = "Họ tên")]
        public string ten { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập địa chỉ")]
        [Display(Name = "Địa chỉ")]
        public string diaChi { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập số điện thoại")]
        [Display(Name = "Số điện thoại")]
        public string sdt { get; set; }
        public string maTK { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Yêu cầu nhập email")]
        public string email { get; set; }

        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Yêu cầu chọn giới tính")]
        public string gioiTinh { get; set; }

        [Display(Name = "CMND")]
        [Required(ErrorMessage = "Yêu cầu nhập chứng minh nhân dân")]
        public string cmnd { get; set; }


        [Display(Name = "Tên tài khoản")]
        [Required(ErrorMessage = "Yêu cầu nhập tên tài khoản")]
        public string tenTK { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
        public string matKhau { get; set; }

        [Required(ErrorMessage = "Yêu cầu chọn quyền")]
        public string maQuyen { get; set; }

        [Required]
        public string quyen { get; set; }

        [Display(Name = "Trạng thái")]
        public bool trangThai { get; set; }
    }
}