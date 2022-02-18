using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sales2Project.Models {
    public class Customer {
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Name { get; set; }
        public bool Active { get; set; }
        [Required, StringLength(2)]
        public string StateCode { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal Sales { get; set; }

        public Customer() {
        }
    }
}
