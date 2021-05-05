﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSETWebCore.DataLayer
{
    public partial class MATURITY_SOURCE_FILES
    {
        [Key]
        public int Mat_Question_Id { get; set; }
        [Key]
        public int Gen_File_Id { get; set; }
        [Key]
        [StringLength(850)]
        public string Section_Ref { get; set; }
        public int? Page_Number { get; set; }
        [StringLength(2000)]
        public string Destination_String { get; set; }

        [ForeignKey(nameof(Gen_File_Id))]
        [InverseProperty(nameof(GEN_FILE.MATURITY_SOURCE_FILES))]
        public virtual GEN_FILE Gen_File_ { get; set; }
        [ForeignKey(nameof(Mat_Question_Id))]
        [InverseProperty(nameof(MATURITY_QUESTIONS.MATURITY_SOURCE_FILES))]
        public virtual MATURITY_QUESTIONS Mat_Question_ { get; set; }
    }
}