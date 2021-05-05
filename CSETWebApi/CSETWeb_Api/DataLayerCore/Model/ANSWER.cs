﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSETWebCore.DataLayer
{
    public partial class ANSWER
    {
        public int Assessment_Id { get; set; }
        [Key]
        public int Answer_Id { get; set; }
        /// <summary>
        /// The Question Or Requirement Id is used to
        /// </summary>
        public int Question_Or_Requirement_Id { get; set; }
        /// <summary>
        /// The Mark For Review is used to
        /// </summary>
        public bool? Mark_For_Review { get; set; }
        /// <summary>
        /// The Comment is used to
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// The Alternate Justification is used to
        /// </summary>
        [StringLength(2048)]
        public string Alternate_Justification { get; set; }
        /// <summary>
        /// The Question Number is used to
        /// </summary>
        public int? Question_Number { get; set; }
        /// <summary>
        /// The Answer Text is used to
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Answer_Text { get; set; }
        /// <summary>
        /// The Component Guid is used to
        /// </summary>
        public Guid Component_Guid { get; set; }
        [StringLength(50)]
        public string Custom_Question_Guid { get; set; }
        public int? Old_Answer_Id { get; set; }
        public bool Reviewed { get; set; }
        [StringLength(2048)]
        public string Feedback { get; set; }
        [Required]
        [StringLength(20)]
        public string Question_Type { get; set; }
        public bool? Is_Requirement { get; set; }
        public bool? Is_Component { get; set; }
        public bool? Is_Framework { get; set; }
        public bool? Is_Maturity { get; set; }

        [ForeignKey("Answer_Text")]
        [InverseProperty("ANSWER")]
        public virtual ANSWER_LOOKUP Answer_TextNavigation { get; set; }
        [ForeignKey("Assessment_Id")]
        [InverseProperty("ANSWER")]
        public virtual ASSESSMENTS Assessment_ { get; set; }
        [InverseProperty("Answer_")]
        public virtual ICollection<DOCUMENT_ANSWERS> DOCUMENT_ANSWERS { get; set; }
        [InverseProperty("Answer_")]
        public virtual ICollection<FINDING> FINDING { get; set; }
        [InverseProperty("Answer_")]
        public virtual ICollection<PARAMETER_VALUES> PARAMETER_VALUES { get; set; }

    }
}