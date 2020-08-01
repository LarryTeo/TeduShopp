using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { set; get; }
        [Required]
        public DateTime VististedDate { set; get; }
        [Required]
        [MaxLength(50)]
        public string IPAddress { set; get; }
    }
}
