﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BllodSugarTester.Models
{
    public class AddingSugarViewModel
    {
        [Key]
        public string Id { get; set; }

        public string calenID { get; set; }


    }

}