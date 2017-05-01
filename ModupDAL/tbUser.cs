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
    
    public partial class tbUser
    {
        public tbUser()
        {
            this.tbClients = new HashSet<tbClient>();
            this.tbPMs = new HashSet<tbPM>();
        }
    
        public int userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string contactNumber { get; set; }
        public string accountType { get; set; }
        public string username { get; set; }
        public byte[] password { get; set; }
        public string email { get; set; }
        public string secretQ { get; set; }
        public string secretA { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public int userType { get; set; }
    
        public virtual ICollection<tbClient> tbClients { get; set; }
        public virtual ICollection<tbPM> tbPMs { get; set; }
    }
}
