using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CustomersEFCodeFirstAssMVC.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [StringLength(6)]
        public string Cid { get; set; }
        [StringLength(35)]
        [Required]
        public string Cname { get; set; }
        [StringLength(40)]
        [Required]
        public string Email { get; set; }
        [StringLength(10)]
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public string City { get; set; }
    }
}
