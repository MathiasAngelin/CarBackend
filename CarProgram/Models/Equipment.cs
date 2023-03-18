using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarProgram.Models
{
    public class Equipment
    {
        [Key]
        public int? Id { get; set; }
        public string? TheEquipment { get; set; }
        public int CarId { get; set; }
        public Car? Car { get; set; }
    }
}
