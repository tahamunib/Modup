//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModupDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbProjWorkroom
    {
        public tbProjWorkroom()
        {
            this.tbMessages = new HashSet<tbMessage>();
            this.tbProjWorkroomFiles = new HashSet<tbProjWorkroomFile>();
        }
    
        public int wrID { get; set; }
        public int projID { get; set; }
    
        public virtual tbAwardedProj tbAwardedProj { get; set; }
        public virtual ICollection<tbMessage> tbMessages { get; set; }
        public virtual ICollection<tbProjWorkroomFile> tbProjWorkroomFiles { get; set; }
    }
}
