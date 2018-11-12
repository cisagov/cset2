//////////////////////////////// 
// 
//   Copyright 2018 Battelle Energy Alliance, LLC  
// 
// 
//////////////////////////////// 
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class GEN_FILE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GEN_FILE()
        {
            this.REQUIREMENT_REFERENCES = new HashSet<REQUIREMENT_REFERENCES>();
            this.REQUIREMENT_SOURCE_FILES = new HashSet<REQUIREMENT_SOURCE_FILES>();
            this.REF_LIBRARY_PATH = new HashSet<REF_LIBRARY_PATH>();
        }
    
        public int Gen_File_Id { get; set; }
        public Nullable<decimal> File_Type_Id { get; set; }
        public string File_Name { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public Nullable<double> File_Size { get; set; }
        public string Doc_Num { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }
        public string Short_Name { get; set; }
        public Nullable<System.DateTime> Publish_Date { get; set; }
        public string Doc_Version { get; set; }
        public string Summary { get; set; }
        public string Source_Type { get; set; }
        public byte[] Data { get; set; }
        public Nullable<bool> Is_Uploaded { get; set; }
    
        public virtual FILE_REF_KEYS FILE_REF_KEYS { get; set; }
        public virtual FILE_TYPE FILE_TYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUIREMENT_REFERENCES> REQUIREMENT_REFERENCES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REQUIREMENT_SOURCE_FILES> REQUIREMENT_SOURCE_FILES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REF_LIBRARY_PATH> REF_LIBRARY_PATH { get; set; }
    }
}


