using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EVotingSystems.Models
{
    public class VoterPerson
    {
        [Required]
        public int CNIC { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Maiden { get; set; }
        public bool Facical { get; set; }
        public bool thumb { get; set; }

    }
}