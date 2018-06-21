using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstawizePoco
{
    [Table("App_StripeAccountDetail")]
    public class AppStripeAccountDetailPoco
    {
        [Key]
        [Column("StripeAccountId")]
        public byte StripeAccountId { get; set; }

        [Column("ConnectionMode")]
        public string ConnectionMode { get; set; }

        [Column("PublicKey")]
        public string PublicKey { get; set; }

        [Column("PrivateKey")]
        public string PrivateKey { get; set; }

        [Column("ConnectionKey")]
        public string ConnectionKey { get; set; }

        [Column("EmailAddress")]
        public string EmailAddress { get; set; }
    }
}
