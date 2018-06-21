using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstawizePoco
{
    [Table("Admin_FinancialAccount")]
    public class AdminFinancialAccountPoco
    {
        [Key]
        [Column("AccountNo")]
        public string AccountNo { get; set; }

        [Column("AccountName")]
        public string AccountName { get; set; }

        [Column("AccountType")]
        public string AccountType { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; } 

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [ForeignKey("UserInfoPoco")]
        [Column("UserId")]
        public int CreatedBy { get; set; }

        public UserBasicInfoPoco UserInfoPoco { get; set; }

    }
}
