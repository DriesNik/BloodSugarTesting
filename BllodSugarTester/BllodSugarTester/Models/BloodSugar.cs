using System.ComponentModel.DataAnnotations;
using System;

namespace BllodSugarTester.Models
{
    public class BloodSugars
    {
        
        private string time;
        [Key]
        public int Id { get; set; }
        public string Time { get { return (new DateTime().ToString()); } set { time = (new DateTime().ToString()); } }
        public string Date { get { return (new DateTime().ToString()); } set { time = (new DateTime().ToString()); } }
        public string BloodSugar { get; set; }
        public string UserId { get; set; }
        public Boolean AboveRange { get; set; }
        public Boolean BelowRange { get; set; }
        public Boolean InRange { get; set; }

    }
}