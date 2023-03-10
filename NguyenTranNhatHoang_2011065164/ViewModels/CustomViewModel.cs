using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenTranNhatHoang_2011065164.ViewModels
{
    public class CustomViewModel
    {
        [Required]
        public string Plasce { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        public string Time { get; set; }
    }
}