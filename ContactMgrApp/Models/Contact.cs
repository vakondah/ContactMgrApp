//CSC 237
//Aliaksandra Hrechka
//02/16/2020
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContactMgrApp.Models
{
    public class Contact
    {
        // primary key - generate by database
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage ="Please enter the first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter the last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter the phone number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please enter the email.")]
        public string Email { get; set; }

        
        public string Organization { get; set; } // no validation required
        public DateTime DateAdded { get; set; }// will be set by application

        // Foreign Key
        [ForeignKey("CategoryId")]// part of the schema
        public Category Category { get; set; }

        [Range(1, 1000000, ErrorMessage ="Please, select a category.")]
        public int CategoryId { get; set; }

        // read only property 
        public string Slug => FirstName?.Replace(' ', '-').ToLower()
            + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}
