﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Data.Models
{
    public partial class TagCloud
    {
        public TagCloud()
        {
            ArticleTagCloudMapping = new HashSet<ArticleTagCloudMapping>();
        }

        [Key]
        public Guid TagId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int Amount { get; set; }

        [InverseProperty("Tag")]
        public virtual ICollection<ArticleTagCloudMapping> ArticleTagCloudMapping { get; set; }
    }
}