using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(42)]
        [Required(AllowEmptyStrings = false)]
        public string Login { get; set; }

        [MaxLength(24)]
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }

        [MaxLength(24)]
        [Required(AllowEmptyStrings = false)]
        public string ConfirmPassword { get; set; }

        [MaxLength(13)]
        [Required(AllowEmptyStrings = false)]
        public string Phone { get; set; }

    }
}
