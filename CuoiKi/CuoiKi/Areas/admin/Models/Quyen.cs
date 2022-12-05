using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CuoiKi.Areas.admin.Models
{
    public class Quyen
    {
        
        public string id { get; set; }
        [Display(Name = "Quyền")]
        public string tenQuyen { get; set; }

    }

}