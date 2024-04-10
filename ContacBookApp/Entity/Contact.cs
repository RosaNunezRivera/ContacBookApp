using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContacBookApp.Entity
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
