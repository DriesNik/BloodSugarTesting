using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BllodSugarTester.Models
{
    public class BloodSugars
    {
        [Key]
        public int Id { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string BloodSugar { get; set; }
        public string UserId { get; set; }
    }
}