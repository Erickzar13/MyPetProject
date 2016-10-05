using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebTutorial.Models
{
    public class Location
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        [ForeignKey("Country")]
        [DisplayName("Country")]
        public int Country_Id { get; set; }
       

        public virtual Country Country { get; set; }
    }
}