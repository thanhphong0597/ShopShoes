

using System.ComponentModel.DataAnnotations;

namespace DoAnTotNghiep.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Toi da 40 ki tu")]
        public string Name { get; set; }



        //foreign Key
        public ICollection<GenericShoes> GenericShoes { get; set; }

    }
}
