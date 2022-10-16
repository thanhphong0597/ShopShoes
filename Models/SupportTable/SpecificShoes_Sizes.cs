
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DoAnTotNghiep.Models.SupportTable
{
    public class SpecificShoes_Sizes
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Sizes")]
        public int Sizes_ID { get; set; }
        public Sizes Sizes { get; set; }


        [ForeignKey("Specific_Shoes")]
        public int SpecificShoes_ID { get; set; }
        public Specific_Shoes Specific_Shoes { get; set; }
    }
}
