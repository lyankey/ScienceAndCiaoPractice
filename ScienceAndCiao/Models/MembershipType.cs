using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScienceAndCiao.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        public string MembershipName { get; set; }
        public int SignUpFee { get; set; }
        public byte SubscriptionDuration { get; set; }
        public byte DiscountRate { get; set; }

    }
}