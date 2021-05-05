﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerCore.Model
{
    /// <summary>
    /// A collection of AVAILABLE_STANDARDS records
    /// </summary>
    public partial class AVAILABLE_STANDARDS
    {
        [Key]
        public int Assessment_Id { get; set; }
        /// <summary>
        /// The Old Entity Name is used to
        /// </summary>
        [Key]
        [StringLength(50)]
        public string Set_Name { get; set; }
        /// <summary>
        /// The Selected is used to
        /// </summary>
        public bool Selected { get; set; }

        [ForeignKey(nameof(Assessment_Id))]
        [InverseProperty(nameof(ASSESSMENTS.AVAILABLE_STANDARDS))]
        public virtual ASSESSMENTS Assessment_ { get; set; }
        [ForeignKey(nameof(Set_Name))]
        [InverseProperty(nameof(SETS.AVAILABLE_STANDARDS))]
        public virtual SETS Set_NameNavigation { get; set; }
    }
}