using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Netflix_Api.Models
{
    [Table("plan")]
    public class PlanModel
    {
        [Key]
        [Column("id_plan")]
        public int PlanId { get; set; }

        [MaxLength(15)]
        public string Title { get; set; }

        [Range(0, double.MaxValue)]
        public double Price { get; set; }

        [MaxLength(10)]
        public string Quality { get; set; }

        [MaxLength(10)]
        public string Resolution { get; set; }

        public PlanModel(int planId, string title, double price, string quality, string resolution)
        {
            this.PlanId = planId;
            this.Title = title;
            this.Price = price;
            this.Quality = quality;
            this.Resolution = resolution;
        }
    }
}
