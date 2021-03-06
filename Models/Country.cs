﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgnosticAlbatros.Models
{
    public class Country
    {
        [Key]
        public long ID { get; set; }
        public string Name { get; set; }
        public string ISOCode { get; set; }
        
        public virtual List<City> Cities { get; set; }
    }
}
