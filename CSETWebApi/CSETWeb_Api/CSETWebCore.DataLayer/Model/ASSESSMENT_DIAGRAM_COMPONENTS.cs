﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayerCore.Model
{
    public partial class ASSESSMENT_DIAGRAM_COMPONENTS
    {
        [Key]
        public int Assessment_Id { get; set; }
        [Key]
        public Guid Component_Guid { get; set; }
        public int Component_Symbol_Id { get; set; }
        [StringLength(200)]
        public string label { get; set; }
        [StringLength(50)]
        public string DrawIO_id { get; set; }
        public int? Zone_Id { get; set; }
        public int? Layer_Id { get; set; }
        [StringLength(50)]
        public string Parent_DrawIO_Id { get; set; }

        [ForeignKey(nameof(Assessment_Id))]
        [InverseProperty(nameof(ASSESSMENTS.ASSESSMENT_DIAGRAM_COMPONENTS))]
        public virtual ASSESSMENTS Assessment_ { get; set; }
        [ForeignKey(nameof(Component_Symbol_Id))]
        [InverseProperty(nameof(COMPONENT_SYMBOLS.ASSESSMENT_DIAGRAM_COMPONENTS))]
        public virtual COMPONENT_SYMBOLS Component_Symbol_ { get; set; }
        [ForeignKey(nameof(Layer_Id))]
        [InverseProperty(nameof(DIAGRAM_CONTAINER.ASSESSMENT_DIAGRAM_COMPONENTSLayer_))]
        public virtual DIAGRAM_CONTAINER Layer_ { get; set; }
        [ForeignKey(nameof(Zone_Id))]
        [InverseProperty(nameof(DIAGRAM_CONTAINER.ASSESSMENT_DIAGRAM_COMPONENTSZone_))]
        public virtual DIAGRAM_CONTAINER Zone_ { get; set; }
    }
}