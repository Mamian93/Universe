using AllinOneForDummies.Core.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllinOneForDummies.Core
{
    public class Planet : BaseModel
    {
        public Planet()
        {
            List<Moon> Moons = new List<Moon>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public decimal Radius { get; set; }
        public long Distance { get; set; }

        [Range(0, 10, ConvertValueInInvariantCulture = true, ErrorMessage = "Value out of range")]
        public decimal AttractivenessRating { get; set; }

        public PlanetType PlanetType { get; set; }

        public ICollection<Moon> Moons { get; set; }

        public int StarId { get; set; }
        public Star Star { get; set; }
    }
}