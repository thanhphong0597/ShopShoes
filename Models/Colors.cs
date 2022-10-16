using DoAnTotNghiep.Models.SupportTable;

namespace DoAnTotNghiep.Models
{
    public class Colors
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //foreign key SpecificShoes
        public ICollection<SpecificShoes_Colors> SpecificShoes_Colors { get; set; }
    }
}
