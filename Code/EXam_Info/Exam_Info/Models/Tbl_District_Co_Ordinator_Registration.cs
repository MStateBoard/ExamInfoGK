//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam_Info.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_District_Co_Ordinator_Registration
    {
        public int ID { get; set; }
        public string Index_No { get; set; }
        public string College_Name { get; set; }
        public string College_Address { get; set; }
        public string Coordinator_Name { get; set; }
        public string Coordinator_Mobile { get; set; }
        public string Coordinator_Email { get; set; }
        public string Coordinator_Eduction { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }
        public string Division_Code { get; set; }
        public string District_Code { get; set; }
        public string Taluka_Code { get; set; }
        public string College_Code { get; set; }
        public Nullable<int> Active { get; set; }
        public List<string> College_Code1 { get; set; }
        public List<Tbl_ITCOLLEGELIST> College_List { get; set; }
    }
}
