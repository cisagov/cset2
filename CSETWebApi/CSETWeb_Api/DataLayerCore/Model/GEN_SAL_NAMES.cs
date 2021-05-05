﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerCore.Model
{
    public partial class GEN_SAL_NAMES
    {
        public GEN_SAL_NAMES()
        {
            GENERAL_SAL = new HashSet<GENERAL_SAL>();
            GEN_SAL_WEIGHTS = new HashSet<GEN_SAL_WEIGHTS>();
        }

        [Key]
        [StringLength(50)]
        public string Sal_Name { get; set; }

        [InverseProperty("Sal_NameNavigation")]
        public virtual ICollection<GENERAL_SAL> GENERAL_SAL { get; set; }
        [InverseProperty("Sal_Name1")]
        public virtual ICollection<GEN_SAL_WEIGHTS> GEN_SAL_WEIGHTS { get; set; }
    }
}