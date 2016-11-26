//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modupv1
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbModule
    {
        public tbModule()
        {
            this.tbProposals = new HashSet<tbProposal>();
            this.tbSubModules = new HashSet<tbSubModule>();
        }
    
        public int modID { get; set; }
        public int projID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Nullable<int> budget { get; set; }
        public Nullable<System.DateTime> closeDate { get; set; }
        public string devSkillLevel { get; set; }
        public string status { get; set; }
        public string category { get; set; }
        public string devType { get; set; }
        public string skillReq { get; set; }
        public string filename { get; set; }
    
        public virtual tbAwardedModule tbAwardedModule { get; set; }
        public virtual tbProject tbProject { get; set; }
        public virtual ICollection<tbProposal> tbProposals { get; set; }
        public virtual ICollection<tbSubModule> tbSubModules { get; set; }
    }
}