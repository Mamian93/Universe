using AllinOneForDummies.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllinOneForDummies.Core
{
    public class Moon : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Radius { get; set; }

        [Range(0, 10, ConvertValueInInvariantCulture = true, ErrorMessage = "Value out of range")]
        public decimal AttractivenessRating { get; set; }

        public Planet Planet { get; set; }
    }
}
