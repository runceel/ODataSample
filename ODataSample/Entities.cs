using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ODataSample
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}