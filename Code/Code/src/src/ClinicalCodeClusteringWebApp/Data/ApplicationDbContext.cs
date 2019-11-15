using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClinicalCodeClusteringWebApp.Models;


namespace ClinicalCodeClusteringWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public virtual DbSet<Claims> Claims { get; set; }
        public virtual DbSet<CPTCats> CptCats { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\mssqllocaldb;Database=aspnet-ClinicalCodeClusteringWebApp-A345E173-EF1B-4546-9C65-95A9181858FC");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

               

            modelBuilder.Entity<Claims>(entity =>
            {
                entity.HasKey(e => new { e.ClaimId, e.Cpt });

                entity.Property(e => e.ClaimId)
                    .HasColumnName("Claim_ID")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Cpt)
                    .HasColumnName("CPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeAmount)
                    .HasColumnName("Charge_Amount")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfSubmission)
                    .HasColumnName("Date_of_Submission")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmount)
                    .HasColumnName("Payment_Amount")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CPTCats>(entity =>
            {
                entity.HasKey(e => e.ClaimId)
                    .HasName("PK_Table");

                entity.ToTable("CPT_Cats");

                entity.Property(e => e.ClaimId)
                    .HasColumnName("Claim_ID")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DrugAssay)
                    .HasColumnName("DrugAssay")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Microbiology)
                    .HasColumnName("Microbiology")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Chemistry)
                    .HasColumnName("Chemistry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiseasePanels)
                    .HasColumnName("DiseasePanels")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hematology)
                    .HasColumnName("Hematology")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Immunology)
                    .HasColumnName("Immunology")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Urinalysis)
                    .HasColumnName("Urinalysis")
                    .HasMaxLength(50)
                    .IsUnicode(false);



            });
        }
    }
}
