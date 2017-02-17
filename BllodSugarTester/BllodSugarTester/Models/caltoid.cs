using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace BllodSugarTester.Models
{
    public class caltoid
    {
        [Key]
        public string Id { get; set; }
       
        public string calenID { get; set; }
    }
}