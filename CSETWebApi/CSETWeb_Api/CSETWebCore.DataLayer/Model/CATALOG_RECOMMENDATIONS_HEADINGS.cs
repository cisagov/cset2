﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerCore.Model
{
    /// <summary>
    /// A collection of CATALOG_RECOMMENDATIONS_HEADINGS records
    /// </summary>
    public partial class CATALOG_RECOMMENDATIONS_HEADINGS
    {
        public CATALOG_RECOMMENDATIONS_HEADINGS()
        {
            CATALOG_RECOMMENDATIONS_DATA = new HashSet<CATALOG_RECOMMENDATIONS_DATA>();
        }

        /// <summary>
        /// The Id is used to
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// The Heading Num is used to
        /// </summary>
        public int Heading_Num { get; set; }
        /// <summary>
        /// The Heading Name is used to
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Heading_Name { get; set; }

        [InverseProperty("Parent_Heading_")]
        public virtual ICollection<CATALOG_RECOMMENDATIONS_DATA> CATALOG_RECOMMENDATIONS_DATA { get; set; }
    }
}