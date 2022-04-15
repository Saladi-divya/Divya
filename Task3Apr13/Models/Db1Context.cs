using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WEBAPI_TASK3.Models
{
    public partial class Db1Context : DbContext
    {
        public Db1Context()
        {
        }

        public Db1Context(DbContextOptions<Db1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Coursedet> Coursedet { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Productdetails> Productdetails { get; set; }
        public virtual DbSet<Regdetails> Regdetails { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=Bhanu😉;Database=Db1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coursedet>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Coursede__D837D05FCA8F8739");

                entity.Property(e => e.Cid)
                    .HasColumnName("cid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cduration)
                    .HasColumnName("cduration")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cfee)
                    .HasColumnName("cfee")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .HasColumnName("cname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Crollno).HasColumnName("crollno");
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Did)
                    .HasName("PK__Dept__D877D216E3EFEDF1");

                entity.Property(e => e.Did)
                    .HasColumnName("did")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dlocation)
                    .HasColumnName("dlocation")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dname)
                    .HasColumnName("dname")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__employee__D9509F6DBB668B41");

                entity.ToTable("employee");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Did).HasColumnName("did");

                entity.Property(e => e.Edesign)
                    .HasColumnName("edesign")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Esal)
                    .HasColumnName("esal")
                    .HasColumnType("money");

                entity.HasOne(d => d.D)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.Did)
                    .HasConstraintName("FK__employee__did__412EB0B6");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__person__DD37D91AC2831328");

                entity.ToTable("person");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.PGender)
                    .HasColumnName("p_gender")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Productdetails>(entity =>
            {
                entity.HasKey(e => e.Pcode)
                    .HasName("PK__productd__293812AAC09081E9");

                entity.ToTable("productdetails");

                entity.Property(e => e.Pcode)
                    .HasColumnName("pcode")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pdesc)
                    .HasColumnName("pdesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pname)
                    .HasColumnName("pname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StockinHand).HasColumnName("stockin_hand");

                entity.Property(e => e.Unitprice).HasColumnName("unitprice");
            });

            modelBuilder.Entity<Regdetails>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__Regdetai__C2B7EDE8E28AFA5A");

                entity.Property(e => e.Rid)
                    .HasColumnName("rid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Contact).HasColumnName("contact");

                entity.Property(e => e.Experience)
                    .HasColumnName("experience")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Mailid)
                    .HasColumnName("mailid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Skillset)
                    .HasColumnName("skillset")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("student");

                entity.Property(e => e.Stmailid)
                    .HasColumnName("stmailid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stname)
                    .HasColumnName("stname")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Strollno).HasColumnName("strollno");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
