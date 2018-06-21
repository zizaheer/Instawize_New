using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstawizePoco
{
    [Table("Admin_ChargingPolicy")]
    public class AdminChargingPolicyPoco
    {
        [Key]
        [Column("ChargePolicyId")]
        public byte ChargePolicyId { get; set; }

        [Column("ChargeType")]
        public string ChargeType { get; set; }

        [Column("IsPerSessionModel")]
        public bool? IsPerSessionModel { get; set; }

        [Column("MinimumSessionLength")]
        public byte? MinimumSessionLength { get; set; } // 8 bit unsigned integer: 0-255

        [Column("MinimumChargePerSession")]
        public decimal? MinimumChargePerSession { get; set; }

        [Column("MaximumParticipantsPerSession")]
        public byte? MaximumParticipantsPerSession { get; set; }

        [Column("IsEligibleForFreeSession")]
        public bool? IsEligibleForFreeSession { get; set; }

        [Column("FreeSessionExpiryDate")]
        public bool? FreeSessionExpiryDate { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [ForeignKey("UserInfoPoco")]
        [Column("UserId")]
        public int CreatedBy { get; set; }

        
        public UserBasicInfoPoco UserInfoPoco { get; set; }
    }
}
