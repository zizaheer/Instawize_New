using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstawizePoco
{
    [Table("App_Country")]
    public class AppCountryPoco
    {
        [Key]
        [Column("CountryId")]
        public Int16 CountryId { get; set; }

        [Column("CountryCode")]
        public string CountryCode { get; set; }

        [Column("CountryName")]
        public string CountryName { get; set; }

        [Column("CountryFlagImage")]
        public byte?[] CountryFlagImage { get; set; }


    }
}
