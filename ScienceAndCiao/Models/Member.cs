﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScienceAndCiao.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public bool IsSubscribedToEmails { get; set; }
        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }
        public DateTime? Birthdate { get; set; }



    }
}