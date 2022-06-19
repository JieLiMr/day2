using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthExam.Model
{
    [Table("Match")]
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        [Required]
        public string UserNameA { get; set; }
        public string PhoneA { get; set; }

        public string AddressA { get; set; }

        [Required]
        public string UserNameB { get; set; }
        public string PhoneB { get; set; }

        public string AddressB { get; set; }

        [Required]
        public string MatchName { get; set; }
        public int TypeId { get; set; }
        public DateTime HoldingTime { get; set; }
    }
}
