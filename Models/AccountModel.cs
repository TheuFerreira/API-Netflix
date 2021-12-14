using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Netflix_Api.Models
{
    [Table("Account")]
    public class AccountModel
    {
        [Key]
        [Column("id_account")]
        public int AccountId { get; set; }

        [Column("id_plan")]
        [ForeignKey("PlanModel")]
        public int? PlanId { get; set; }
        public virtual PlanModel? Plan { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        
        [Required]
        [MaxLength(60)]
        public string Password { get; set; }

        [Column("id_payment")]
        public int? PaymentId { get; set; }
        public virtual PaymentModel? Payment { get; set; }

        public AccountModel(int accountId, string email, string password) {
            AccountId = accountId;
            Email = email;
            Password = password;
        }

    }
}