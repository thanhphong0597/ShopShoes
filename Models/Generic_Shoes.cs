using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnTotNghiep.Models
{

    public class GenericShoes
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Details { get; set; }

        public string? Image { get; set; }


        //foreign key Category
        [ForeignKey("Category")]
        public int Category_ID { get; set; }
        public Category Category { get; set; }


        //foreign key SpecificShoes
        public ICollection<Specific_Shoes> Specific_Shoes { get; set; }


    }
}
