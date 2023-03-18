using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarProgram.Models
{
    public class Car
    {
        [Key]
        public int? VIN { get; set; }
        public string? LicesePlateNumber { get; set; }
        public Brand? Brand { get; set; }
        public string? Model { get; set; }
        public ICollection<Equipment>? Equipment { get; set; }

    }
}
