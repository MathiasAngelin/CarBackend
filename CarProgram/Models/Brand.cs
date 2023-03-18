using System.ComponentModel.DataAnnotations;

namespace CarProgram.Models
{
    public class Brand
    {
        [Key]
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int CarId { get; set; }
        public Car? Car { get; set; }
    }
}
