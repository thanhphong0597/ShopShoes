using DoAnTotNghiep.Models.SupportTable;

namespace DoAnTotNghiep.Models
{
    public class Sizes
    {
        public int Id { get; set; }

        public int Number { get; set; }


        //foreign key SpecificShoes
        public ICollection<SpecificShoes_Sizes> SpecificShoes_Sizes { get; set; }
    }
}
