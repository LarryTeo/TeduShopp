using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  ID { set; get; }
        [Required]
        [MaxLength(50)]
        public string Name { set; get; }
        public virtual IEnumerable<Menu> Menus { set; get; }//quan hệ tới bảng menu
    }
}
