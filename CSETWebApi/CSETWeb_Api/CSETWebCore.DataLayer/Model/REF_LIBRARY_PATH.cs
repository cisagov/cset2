﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerCore.Model
{
    /// <summary>
    /// A collection of REF_LIBRARY_PATH records
    /// </summary>
    public partial class REF_LIBRARY_PATH
    {
        public REF_LIBRARY_PATH()
        {
            GEN_FILE_LIB_PATH_CORL = new HashSet<GEN_FILE_LIB_PATH_CORL>();
            InverseParent_Path_ = new HashSet<REF_LIBRARY_PATH>();
        }

        /// <summary>
        /// The Lib Path Id is used to
        /// </summary>
        [Key]
        [Column(TypeName = "numeric(38, 0)")]
        public decimal Lib_Path_Id { get; set; }
        /// <summary>
        /// The Parent Path Id is used to
        /// </summary>
        [Column(TypeName = "numeric(38, 0)")]
        public decimal? Parent_Path_Id { get; set; }
        /// <summary>
        /// The Path Name is used to
        /// </summary>
        [StringLength(60)]
        public string Path_Name { get; set; }

        [ForeignKey(nameof(Parent_Path_Id))]
        [InverseProperty(nameof(REF_LIBRARY_PATH.InverseParent_Path_))]
        public virtual REF_LIBRARY_PATH Parent_Path_ { get; set; }
        [InverseProperty("Lib_Path_")]
        public virtual ICollection<GEN_FILE_LIB_PATH_CORL> GEN_FILE_LIB_PATH_CORL { get; set; }
        [InverseProperty(nameof(REF_LIBRARY_PATH.Parent_Path_))]
        public virtual ICollection<REF_LIBRARY_PATH> InverseParent_Path_ { get; set; }
    }
}