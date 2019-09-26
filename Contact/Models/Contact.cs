using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//ssss
namespace Contact.Models
{
    public enum TypeContact
    {
        telephone,
        email,
        facebook,
        instagram
    }

    public class Contact
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public TypeContact type { get; set; }
        [Required]
        public string ContactValue { get; set; }
    }
}