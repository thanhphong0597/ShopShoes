using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DoAnTotNghiep.Models.SupportTable;

namespace DoAnTotNghiep.Models
{

    public class Specific_Shoes
    {
        [Key]
        [DatabaseGenerat‌ed(DatabaseGeneratedOp‌​tion.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Toi da 40 ki tu")]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }

        //foreign key

        [ForeignKey("GenericShoes")]
        public int GenericShoes_ID { get; set; }
        public GenericShoes GenericShoes { get; set; }

        //foreign key Color
        public ICollection<SpecificShoes_Colors> SpecificShoes_Colors { get; set; }

        //foreign key Size
        public ICollection<SpecificShoes_Sizes> SpecificShoes_Sizes { get; set; }




    }
}
