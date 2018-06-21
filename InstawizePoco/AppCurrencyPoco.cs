using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstawizePoco
{
    [Table("App_Currency")]
    public class AppCurrencyPoco
    {

        [Key]
        [Column("CurrencyCode")]
        public string CurrencyCode { get; set; }

        [Column("CurrencyName")]
        public string CurrencyName { get; set; }

        [Column("CurrencySymbol")]
        public string CurrencySymbol { get; set; }

        [Column("CurrencyImage")]
        public byte?[] CurrencyImage { get; set; }

        [Column("IsDefault")]
        public bool IsDefault { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [ForeignKey("UserInfoPoco")]
        [Column("UserId")]
        public int CreatedBy { get; set; }


        public UserBasicInfoPoco UserInfoPoco { get; set; }


    }
}
