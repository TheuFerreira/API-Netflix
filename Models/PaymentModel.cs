using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Netflix_Api.Models
{
    [Table("payment")]
    public class PaymentModel
    {
        [Key, Column("id_payment")]
        public int PaymentId { get; set; }
        
        [Required, Column("name"), MaxLength(50)]
        public String Name { get; set; }

        [Column("last_name")]
        public String? LastName { get; set; }

        [Required, Column("month_date")]
        public short MonthDate { get; set; }
        [Required, Column("year_date")]
        public short YearDate { get; set; }
        
        [Required, Column("number_card")]
        public long NumberCard { get; set; }
        
        [Required, Column("cvv")]
        public short CVV { get; set; }
        
        [Required, Column("type_payment")]
        public int TypePaymentId { get; set; }

        public PaymentModel(string name, string? lastName) {
            NumberCard = NumberCard;
            Name = name;
            LastName = lastName;
        }
    }
}