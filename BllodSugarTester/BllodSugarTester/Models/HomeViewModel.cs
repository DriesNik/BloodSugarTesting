using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BllodSugarTester.Models
{ 
    public class AddingSugarViewModel
    {
        [Required]
        [Display(Name = "Id")]
        public string Id { get; set; }
        
        
        [Display(Name = "Time")]
        public string Time { get; set; }

       
        [Display(Name = "Date")]
        public string Date { get; set; }
        
        [Display(Name = "BloodSugar")]
        public string BloodSugar { get; set; }
    }
}