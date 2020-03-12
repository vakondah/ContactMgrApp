//CSC 237
//Aliaksandra Hrechka
//02/16/2020
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactMgrApp.Models
{
    public class Category
    {
        //primary key - generate by database
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
