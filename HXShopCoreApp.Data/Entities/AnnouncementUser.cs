﻿using HXShopCoreApp.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HXShopCoreApp.Data.Entities
{
    [Table("AnnouncementUsers")]
    public class AnnouncementUser : DomainEntity<int>
    {
        [StringLength(128)]
        [Required]
        public string AnnouncementId { get; set; }

       
        [Required]
        public Guid UserId { get; set; }

        public bool? HasRead { get; set; }



        [ForeignKey("AnnouncementId")]
        public virtual Announcement Announcement { get; set; }
    }
}
