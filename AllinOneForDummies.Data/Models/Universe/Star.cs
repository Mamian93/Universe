using AllinOneForDummies.Core.Enums;
using AllinOneForDummies.Core.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AllinOneForDummies.Core
{
    public class Star : BaseModel
    {
        public Star()
        {
            List<Planet> Planets = new List<Planet>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        public StarActivity  StarActivity { get; set; }
        [Range(1, 10, ConvertValueInInvariantCulture = true, ErrorMessage = "Value out of range")]
        public double CapableOfLiving { get; set; }
        public ObjectSize Size { get; set; }

        public ICollection<Planet> Planets { get; set; }
    }
}
