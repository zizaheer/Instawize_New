using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstawizePoco
{


    [Table("Admin_Institute")]
    public class UserChatHistoryPoco
    {
        [Key]
        [Column("InstituteId")]
        public Int16 InstituteId { get; set; }

        [ForeignKey("ChargingPolicyPoco")]
        [Column("ChargePolicyId")]
        public byte ChargePolicyId { get; set; }

        [Column("InstituteName")]
        public string InstituteName { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [Column("Phone")]
        public string Phone { get; set; }

        [Column("ContactPersonName")]
        public string ContactPersonName { get; set; }

        [Column("DefaultEmail")]
        public string DefaultEmail { get; set; }

        [Column("BillingEmail")]
        public string BillingEmail { get; set; }

        [Column("TechnicalEmail")]
        public string TechnicalEmail { get; set; }

        [Column("DisputeEmail")]
        public string DisputeEmail { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [ForeignKey("UserInfoPoco")]
        [Column("UserId")]
        public int CreatedBy { get; set; }

        public UserBasicInfoPoco UserInfoPoco { get; set; }
        public AdminChargingPolicyPoco ChargingPolicyPoco { get; set; }

    }


}
