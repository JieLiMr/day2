using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthExam.Model
{
    [Table("UserInfo")]
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

    }
}
