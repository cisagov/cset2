﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerCore.Model
{
    public partial class MATURITY_MODELS
    {
        public MATURITY_MODELS()
        {
            AVAILABLE_MATURITY_MODELS = new HashSet<AVAILABLE_MATURITY_MODELS>();
        }

        [Key]
        [StringLength(50)]
        public string Model_Name { get; set; }

        [InverseProperty("Model_NameNavigation")]
        public virtual ICollection<AVAILABLE_MATURITY_MODELS> AVAILABLE_MATURITY_MODELS { get; set; }
    }
}