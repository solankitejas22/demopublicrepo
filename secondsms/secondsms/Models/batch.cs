//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace secondsms.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class batch
    {
        public batch()
        {
            this.registrations = new HashSet<registration>();
        }
    
        public int Id { get; set; }
        public string batch1 { get; set; }
        public string year { get; set; }
    
        public virtual ICollection<registration> registrations { get; set; }
    }
}
