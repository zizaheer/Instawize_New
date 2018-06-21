using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstawizePoco
{
    [Table("App_Language")]
    public class AppTimezonePoco
    {
        [Key]
        [Column("LanguageId")]
        public byte LanguageId { get; set; }

        [Column("LanguageCode")]
        public string LanguageCode { get; set; }

        [Column("LanguageName")]
        public string LanguageName { get; set; }

        [Column("NativeName")]
        public string NativeName { get; set; }



    }
}
