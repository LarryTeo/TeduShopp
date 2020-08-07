using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        [Required]
        [MaxLength(50)]
        public string Type { set; get; }
        
    }
}
