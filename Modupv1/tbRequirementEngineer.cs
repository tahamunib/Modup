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
    
    public partial class tbRequirementEngineer
    {
        public tbRequirementEngineer()
        {
            this.tbProjProposals = new HashSet<tbProjProposal>();
            this.tbAwardedProj = new HashSet<tbAwardedProj>();
        }
    
        public int clientID { get; set; }
        public int raID { get; set; }
    
        public virtual tbClient tbClient { get; set; }
        public virtual ICollection<tbProjProposal> tbProjProposals { get; set; }
        public virtual ICollection<tbAwardedProj> tbAwardedProj { get; set; }
    }
}
