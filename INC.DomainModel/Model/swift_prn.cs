//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace INC.DomainModel.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class swift_prn
    {
        public int rec_id { get; set; }
        public string swift_no { get; set; }
        public Nullable<int> serial_no { get; set; }
        public string code_title { get; set; }
        public string code_no { get; set; }
        public Nullable<int> code_no_serial { get; set; }
        public string table_name { get; set; }
        public string field_name { get; set; }
        public string field_type { get; set; }
        public Nullable<short> field_len { get; set; }
        public Nullable<short> max_lines { get; set; }
        public string field_cont { get; set; }
        public string field_cont_type { get; set; }
        public string field_not_cont { get; set; }
        public string field_not_cont_type { get; set; }
    }
}
