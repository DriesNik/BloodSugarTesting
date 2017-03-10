using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNet.Identity;

namespace BllodSugarTester.Models
{
    public class BloodSugars
    {
        
        
        [Key]
        public int Id { get; set; }
        public string Time { get; set; }
        public string Date { get; set; }
        public string DocID { get; set; }
        public string BloodSugar { get; set; }
        public string UserId { get; set ; }
        public Boolean AboveRange { get; set; }
        public Boolean BelowRange { get; set; }
        public Boolean InRange { get; set; }

    }
}