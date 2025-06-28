using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEdiDemo.models
{
    [Table("dessert")]
    public class Dessert
    {
        [Key]
        [Column("DESSERT_ID")]
        public int DessertId { get; set; }

        [Column("DESSERT_DATE")]
        public int DessertPreserveDate { get; set; }

        [Column("DESSERT_TYPE_ID")]
        public int DessertTypeId { get; set; }

        [Column("DESSERT_NAME")]
        [Required]
        public string DessertName { get; set; }

        [Column("DESSERT_PRICE")]
        public int DessertPrice { get; set; }

        [Column("DESSERT_AMOUNT")]
        public int DessertAmount { get; set; }

        [Column("DESSERT_INSTRUCTION")]
        [Required]
        public string DessertInstruction { get; set; }

        [Column("TKT_TOTAL_SCORE")]
        public int? DessertTotalScore { get; set; }

        [Column("TKT_TOTAL_PEOPLE")]
        public int? DessertTotalPeople { get; set; }

        [Column("DESSERT_IMG")]
        public byte[] DessertPic { get; set; }

    }
}