﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerCore.Model
{
    [Table("AggregatedCounter", Schema = "HangFire")]
    public partial class AggregatedCounter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Key { get; set; }
        public long Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ExpireAt { get; set; }
    }
}