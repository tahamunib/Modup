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
    
    public partial class tbProposal
    {
        public tbProposal()
        {
            this.tbAwardedModules = new HashSet<tbAwardedModule>();
        }
    
        public int propID { get; set; }
        public int devID { get; set; }
        public int modID { get; set; }
        public string covLetter { get; set; }
        public string hourlyRate { get; set; }
        public string estCompletion { get; set; }
    
        public virtual ICollection<tbAwardedModule> tbAwardedModules { get; set; }
        public virtual tbDeveloper tbDeveloper { get; set; }
        public virtual tbModule tbModule { get; set; }
    }
}
