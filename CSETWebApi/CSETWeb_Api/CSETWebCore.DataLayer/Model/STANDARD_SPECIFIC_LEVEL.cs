﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerCore.Model
{
    /// <summary>
    /// A collection of STANDARD_SPECIFIC_LEVEL records
    /// </summary>
    public partial class STANDARD_SPECIFIC_LEVEL
    {
        public STANDARD_SPECIFIC_LEVEL()
        {
            REQUIREMENT_LEVELS = new HashSet<REQUIREMENT_LEVELS>();
            STANDARD_TO_UNIVERSAL_MAP = new HashSet<STANDARD_TO_UNIVERSAL_MAP>();
        }

        /// <summary>
        /// The Standard Level is used to
        /// </summary>
        [Key]
        [StringLength(50)]
        public string Standard_Level { get; set; }
        /// <summary>
        /// The Level Order is used to
        /// </summary>
        public int Level_Order { get; set; }
        /// <summary>
        /// The Full Name is used to
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Full_Name { get; set; }
        /// <summary>
        /// The Standard is used to
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Standard { get; set; }
        [Required]
        [StringLength(50)]
        public string Display_Name { get; set; }
        public int? Display_Order { get; set; }
        public bool Is_Default_Value { get; set; }
        public bool Is_Mapping_Link { get; set; }

        [InverseProperty("Standard_LevelNavigation")]
        public virtual ICollection<REQUIREMENT_LEVELS> REQUIREMENT_LEVELS { get; set; }
        [InverseProperty("Standard_LevelNavigation")]
        public virtual ICollection<STANDARD_TO_UNIVERSAL_MAP> STANDARD_TO_UNIVERSAL_MAP { get; set; }
    }
}