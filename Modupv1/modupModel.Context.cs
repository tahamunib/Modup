﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbModupEntities : DbContext
    {
        public dbModupEntities()
            : base("name=dbModupEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tbAnswer> tbAnswers { get; set; }
        public DbSet<tbAwardedModule> tbAwardedModules { get; set; }
        public DbSet<tbAwardedProj> tbAwardedProjs { get; set; }
        public DbSet<tbClient> tbClients { get; set; }
        public DbSet<tbDeveloper> tbDevelopers { get; set; }
        public DbSet<tbEducation> tbEducations { get; set; }
        public DbSet<tbEvaluation> tbEvaluations { get; set; }
        public DbSet<tbExperience> tbExperiences { get; set; }
        public DbSet<tbModule> tbModules { get; set; }
        public DbSet<tbPM> tbPMs { get; set; }
        public DbSet<tbPortfolio> tbPortfolios { get; set; }
        public DbSet<tbProject> tbProjects { get; set; }
        public DbSet<tbProjProposal> tbProjProposals { get; set; }
        public DbSet<tbProposal> tbProposals { get; set; }
        public DbSet<tbQualityAssurance> tbQualityAssurances { get; set; }
        public DbSet<tbQuestion> tbQuestions { get; set; }
        public DbSet<tbRequirementEngineer> tbRequirementEngineers { get; set; }
        public DbSet<tbSkill> tbSkills { get; set; }
        public DbSet<tbUser> tbUsers { get; set; }
        public DbSet<tbUserCredential> tbUserCredentials { get; set; }
        public DbSet<tbMessage> tbMessages { get; set; }
        public DbSet<tbProjWorkroom> tbProjWorkrooms { get; set; }
        public DbSet<tbSubModule> tbSubModules { get; set; }
        public DbSet<tbModMessage> tbModMessages { get; set; }
        public DbSet<tbModuleWorkroom> tbModuleWorkrooms { get; set; }
        public DbSet<tbModCheckpoint> tbModCheckpoints { get; set; }
        public DbSet<tbCheckpointReq> tbCheckpointReqs { get; set; }
        public DbSet<tbModRequest> tbModRequests { get; set; }
        public DbSet<tbModWorkroomFile> tbModWorkroomFiles { get; set; }
        public DbSet<tbProjWorkroomFile> tbProjWorkroomFiles { get; set; }
    }
}
