﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerCore.Model
{
    /// <summary>
    /// A collection of MATURITY_LEVELS records
    /// </summary>
    public partial class MATURITY_LEVELS
    {
        public MATURITY_LEVELS()
        {
            MATURITY_QUESTIONS = new HashSet<MATURITY_QUESTIONS>();
        }

        public int Level { get; set; }
        [StringLength(50)]
        public string Level_Name { get; set; }
        [Key]
        public int Maturity_Level_Id { get; set; }
        public int? Maturity_Model_Id { get; set; }

        [ForeignKey(nameof(Maturity_Model_Id))]
        [InverseProperty(nameof(MATURITY_MODELS.MATURITY_LEVELS))]
        public virtual MATURITY_MODELS Maturity_Model_ { get; set; }
        [InverseProperty("Maturity_LevelNavigation")]
        public virtual ICollection<MATURITY_QUESTIONS> MATURITY_QUESTIONS { get; set; }
    }
}