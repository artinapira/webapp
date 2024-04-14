using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webapp.Models;

public partial class ClinicDbContext : DbContext
{
    public ClinicDbContext()
    {
    }

    public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ankesat> Ankesats { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Knowledge> Knowledges { get; set; }

    public virtual DbSet<Marketing> Marketings { get; set; }

    public virtual DbSet<MedicalRecord> MedicalRecords { get; set; }

    public virtual DbSet<PacientNote> PacientNotes { get; set; }

    public virtual DbSet<Pacienti> Pacientis { get; set; }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<Prescription> Prescriptions { get; set; }

    public virtual DbSet<SherbimiShtese> SherbimiShteses { get; set; }

    public virtual DbSet<Stafi> Stafis { get; set; }

    public virtual DbSet<Terapium> Terapia { get; set; }

    public virtual DbSet<Terminet> Terminets { get; set; }

    public virtual DbSet<Vlersimet> Vlersimets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-QM3J7EJG;Initial Catalog=DentalClinic;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ankesat>(entity =>
        {
            entity.HasKey(e => e.AnkesaId).HasName("PK__Ankesat__932170085DBF0B35");

            entity.ToTable("Ankesat");

            entity.Property(e => e.AnkesaId).HasColumnName("AnkesaID");
            entity.Property(e => e.Ankesa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PacientiId).HasColumnName("PacientiID");
            entity.Property(e => e.StafiId).HasColumnName("StafiID");

            entity.HasOne(d => d.Pacienti).WithMany(p => p.Ankesats)
                .HasForeignKey(d => d.PacientiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ankesat__Pacient__412EB0B6");

            entity.HasOne(d => d.Stafi).WithMany(p => p.Ankesats)
                .HasForeignKey(d => d.StafiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ankesat__StafiID__403A8C7D");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PK__Departme__B2079BCD553C1E5A");

            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.Emri)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Pershkrimi)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK__Inventor__727E83EB5E10EEBC");

            entity.ToTable("Inventory");

            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.Emri)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasMany(d => d.Stafis).WithMany(p => p.Inventories)
                .UsingEntity<Dictionary<string, object>>(
                    "StafiInventory",
                    r => r.HasOne<Stafi>().WithMany()
                        .HasForeignKey("StafiId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Stafi_Inv__Stafi__4E88ABD4"),
                    l => l.HasOne<Inventory>().WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Stafi_Inv__Inven__4D94879B"),
                    j =>
                    {
                        j.HasKey("InventoryId", "StafiId").HasName("PK__Stafi_In__EC8444EC5675982D");
                        j.ToTable("Stafi_Inventory");
                        j.IndexerProperty<int>("InventoryId").HasColumnName("InventoryID");
                        j.IndexerProperty<int>("StafiId").HasColumnName("StafiID");
                    });
        });

        modelBuilder.Entity<Knowledge>(entity =>
        {
            entity.HasKey(e => e.KnowledgeId).HasName("PK__Knowledg__FF28F869B79B5A2E");

            entity.ToTable("Knowledge");

            entity.Property(e => e.KnowledgeId).HasColumnName("KnowledgeID");
            entity.Property(e => e.Pershkrimi)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Marketing>(entity =>
        {
            entity.HasKey(e => e.MarketingId).HasName("PK__Marketin__4CCE5A4F57292385");

            entity.ToTable("Marketing");

            entity.Property(e => e.MarketingId).HasColumnName("MarketingID");
            entity.Property(e => e.Img).HasColumnType("image");
            entity.Property(e => e.Pershkrimi)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MedicalRecord>(entity =>
        {
            entity.HasKey(e => e.RecordId).HasName("PK__MedicalR__FBDF78C979AD22BB");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.Diagnoza)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PacientiId).HasColumnName("PacientiID");
            entity.Property(e => e.Pershkrimi)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Rezultati)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Simptomat)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Pacienti).WithMany(p => p.MedicalRecords)
                .HasForeignKey(d => d.PacientiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MedicalRe__Pacie__5629CD9C");
        });

        modelBuilder.Entity<PacientNote>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasName("PK__PacientN__EACE357F51446B04");

            entity.Property(e => e.NoteId).HasColumnName("NoteID");
            entity.Property(e => e.PacientiId).HasColumnName("PacientiID");
            entity.Property(e => e.Pershkrimi)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Pacienti).WithMany(p => p.PacientNotes)
                .HasForeignKey(d => d.PacientiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PacientNo__Pacie__5165187F");
        });

        modelBuilder.Entity<Pacienti>(entity =>
        {
            entity.HasKey(e => e.PacientiId).HasName("PK__Pacienti__924B0339492FDD79");

            entity.ToTable("Pacienti");

            entity.Property(e => e.PacientiId).HasColumnName("PacientiID");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmriMbiemri)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Gjinia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pass)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.PartnerId).HasName("PK__Partners__39FD6332A640B7B5");

            entity.Property(e => e.PartnerId).HasColumnName("PartnerID");
            entity.Property(e => e.Emri)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Pershkrimi)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasMany(d => d.Knowledges).WithMany(p => p.Partners)
                .UsingEntity<Dictionary<string, object>>(
                    "KnowledgePartner",
                    r => r.HasOne<Knowledge>().WithMany()
                        .HasForeignKey("KnowledgeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Knowledge__Knowl__6C190EBB"),
                    l => l.HasOne<Partner>().WithMany()
                        .HasForeignKey("PartnerId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Knowledge__Partn__6B24EA82"),
                    j =>
                    {
                        j.HasKey("PartnerId", "KnowledgeId").HasName("PK__Knowledg__B60FECB4181C76A5");
                        j.ToTable("Knowledge_Partners");
                        j.IndexerProperty<int>("PartnerId").HasColumnName("PartnerID");
                        j.IndexerProperty<int>("KnowledgeId").HasColumnName("KnowledgeID");
                    });
        });

        modelBuilder.Entity<Prescription>(entity =>
        {
            entity.HasKey(e => e.PrescriptionId).HasName("PK__Prescrip__4013081262B37C45");

            entity.ToTable("Prescription");

            entity.Property(e => e.PrescriptionId).HasColumnName("PrescriptionID");
            entity.Property(e => e.Diagnoza)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Medicina)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PacientiId).HasColumnName("PacientiID");

            entity.HasOne(d => d.Pacienti).WithMany(p => p.Prescriptions)
                .HasForeignKey(d => d.PacientiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Prescript__Pacie__5CD6CB2B");
        });

        modelBuilder.Entity<SherbimiShtese>(entity =>
        {
            entity.HasKey(e => e.SherbimiId).HasName("PK__Sherbimi__B22B16F9C24FBFF2");

            entity.ToTable("SherbimiShtese");

            entity.Property(e => e.SherbimiId).HasColumnName("SherbimiID");
            entity.Property(e => e.Cmimi).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Emri)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Pershkrimi)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasMany(d => d.Marketings).WithMany(p => p.Sherbimis)
                .UsingEntity<Dictionary<string, object>>(
                    "MarketingSherbime",
                    r => r.HasOne<Marketing>().WithMany()
                        .HasForeignKey("MarketingId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Marketing__Marke__778AC167"),
                    l => l.HasOne<SherbimiShtese>().WithMany()
                        .HasForeignKey("SherbimiId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Marketing__Sherb__76969D2E"),
                    j =>
                    {
                        j.HasKey("SherbimiId", "MarketingId").HasName("PK__Marketin__56E7F35D4AD19DE1");
                        j.ToTable("Marketing_Sherbime");
                        j.IndexerProperty<int>("SherbimiId").HasColumnName("SherbimiID");
                        j.IndexerProperty<int>("MarketingId").HasColumnName("MarketingID");
                    });
        });

        modelBuilder.Entity<Stafi>(entity =>
        {
            entity.HasKey(e => e.StafiId).HasName("PK__Stafi__979A23F0ED334B91");

            entity.ToTable("Stafi");

            entity.Property(e => e.StafiId).HasColumnName("StafiID");
            entity.Property(e => e.Degree)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");
            entity.Property(e => e.EmriMbiemri)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Paga).HasColumnType("decimal(6, 2)");

            entity.HasOne(d => d.Department).WithMany(p => p.Stafis)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Stafi__Departmen__3D5E1FD2");

            entity.HasMany(d => d.Knowledges).WithMany(p => p.Stafis)
                .UsingEntity<Dictionary<string, object>>(
                    "StafiKnowledge",
                    r => r.HasOne<Knowledge>().WithMany()
                        .HasForeignKey("KnowledgeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Stafi_Kno__Knowl__66603565"),
                    l => l.HasOne<Stafi>().WithMany()
                        .HasForeignKey("StafiId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Stafi_Kno__Stafi__656C112C"),
                    j =>
                    {
                        j.HasKey("StafiId", "KnowledgeId").HasName("PK__Stafi_Kn__1868AC76B8CF93CC");
                        j.ToTable("Stafi_Knowledge");
                        j.IndexerProperty<int>("StafiId").HasColumnName("StafiID");
                        j.IndexerProperty<int>("KnowledgeId").HasColumnName("KnowledgeID");
                    });

            entity.HasMany(d => d.Marketings).WithMany(p => p.Stafis)
                .UsingEntity<Dictionary<string, object>>(
                    "StafiMarketing",
                    r => r.HasOne<Marketing>().WithMany()
                        .HasForeignKey("MarketingId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Stafi_Mar__Marke__71D1E811"),
                    l => l.HasOne<Stafi>().WithMany()
                        .HasForeignKey("StafiId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Stafi_Mar__Stafi__70DDC3D8"),
                    j =>
                    {
                        j.HasKey("StafiId", "MarketingId").HasName("PK__Stafi_Ma__7356C6540A58D2C4");
                        j.ToTable("Stafi_Marketing");
                        j.IndexerProperty<int>("StafiId").HasColumnName("StafiID");
                        j.IndexerProperty<int>("MarketingId").HasColumnName("MarketingID");
                    });
        });

        modelBuilder.Entity<Terapium>(entity =>
        {
            entity.HasKey(e => e.TerapiaId).HasName("PK__Terapia__44F8DDC7F30F4C97");

            entity.Property(e => e.TerapiaId).HasColumnName("TerapiaID");
            entity.Property(e => e.Emri)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Pershkrimi)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasMany(d => d.Prescriptions).WithMany(p => p.Terapia)
                .UsingEntity<Dictionary<string, object>>(
                    "TerapiaPrescription",
                    r => r.HasOne<Prescription>().WithMany()
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Terapia_P__Presc__60A75C0F"),
                    l => l.HasOne<Terapium>().WithMany()
                        .HasForeignKey("TerapiaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Terapia_P__Terap__5FB337D6"),
                    j =>
                    {
                        j.HasKey("TerapiaId", "PrescriptionId").HasName("PK__Terapia___70F9ED46EF5B7246");
                        j.ToTable("Terapia_Prescription");
                        j.IndexerProperty<int>("TerapiaId").HasColumnName("TerapiaID");
                        j.IndexerProperty<int>("PrescriptionId").HasColumnName("PrescriptionID");
                    });

            entity.HasMany(d => d.Records).WithMany(p => p.Terapia)
                .UsingEntity<Dictionary<string, object>>(
                    "TerapiaMedicalRecord",
                    r => r.HasOne<MedicalRecord>().WithMany()
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Terapia_M__Recor__59FA5E80"),
                    l => l.HasOne<Terapium>().WithMany()
                        .HasForeignKey("TerapiaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Terapia_M__Terap__59063A47"),
                    j =>
                    {
                        j.HasKey("TerapiaId", "RecordId").HasName("PK__Terapia___CB452A4B2683290B");
                        j.ToTable("Terapia_MedicalRecord");
                        j.IndexerProperty<int>("TerapiaId").HasColumnName("TerapiaID");
                        j.IndexerProperty<int>("RecordId").HasColumnName("RecordID");
                    });
        });

        modelBuilder.Entity<Terminet>(entity =>
        {
            entity.HasKey(e => e.TerminiId).HasName("PK__Terminet__BDD5CEF0B2E0417E");

            entity.ToTable("Terminet");

            entity.Property(e => e.TerminiId).HasColumnName("TerminiID");
            entity.Property(e => e.Ceshtja)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PacientiId).HasColumnName("PacientiID");
            entity.Property(e => e.StafiId).HasColumnName("StafiID");

            entity.HasOne(d => d.Pacienti).WithMany(p => p.Terminets)
                .HasForeignKey(d => d.PacientiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Terminet__Pacien__44FF419A");

            entity.HasOne(d => d.Stafi).WithMany(p => p.Terminets)
                .HasForeignKey(d => d.StafiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Terminet__StafiI__440B1D61");
        });

        modelBuilder.Entity<Vlersimet>(entity =>
        {
            entity.HasKey(e => e.VlersimiId).HasName("PK__Vlersime__49DCD2F5F2CA39E9");

            entity.ToTable("Vlersimet");

            entity.Property(e => e.VlersimiId).HasColumnName("VlersimiID");
            entity.Property(e => e.PacientiId).HasColumnName("PacientiID");
            entity.Property(e => e.StafiId).HasColumnName("StafiID");

            entity.HasOne(d => d.Pacienti).WithMany(p => p.Vlersimets)
                .HasForeignKey(d => d.PacientiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vlersimet__Pacie__48CFD27E");

            entity.HasOne(d => d.Stafi).WithMany(p => p.Vlersimets)
                .HasForeignKey(d => d.StafiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vlersimet__Stafi__47DBAE45");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
