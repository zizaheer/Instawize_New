using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstawizePoco
{
    [Table("App_AccountBalance")]
    public class AppAccountBalancePoco
    {
        [Key]
        [Column("AccountNo")]
        public string AccountNo { get; set; }

        [Column("CurrentBalance")]
        public decimal CurrentBalance { get; set; }

        [Column("UpdateDate")]
        public DateTime UpdateDate { get; set; }

    }
}
