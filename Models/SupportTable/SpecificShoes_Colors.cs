
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DoAnTotNghiep.Models.SupportTable
{
    public class SpecificShoes_Colors
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Color")]
        [Required]
        public int Colors_ID { get; set; }
        public Colors Color { get; set; }


        [ForeignKey("Specific_Shoes")]
        [Required]
        public int SpecificShoes_ID { get; set; }
        public Specific_Shoes Specific_Shoes { get; set; }
    }
}
