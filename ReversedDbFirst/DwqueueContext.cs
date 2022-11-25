using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReversedDbFirst;

public partial class DwqueueContext : DbContext
{
    public DwqueueContext()
    {
    }

    public DwqueueContext(DbContextOptions<DwqueueContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MessageQueue> MessageQueues { get; set; }

    public virtual DbSet<TransactionState> TransactionStates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=AKOMS_PRO;   Initial Catalog=DWQueue;Integrated Security=false;MultipleActiveResultSets=True ;User ID=sa;Password=Ranti;Pooling=False ;encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_100_CI_AS_KS_WS");

        modelBuilder.Entity<MessageQueue>(entity =>
        {
            entity.HasKey(e => new { e.MessageId, e.QueueName });

            entity.ToTable("MessageQueue");

            entity.HasIndex(e => new { e.QueueName, e.IsActive, e.Priority, e.DateActive, e.Sequence, e.MessageId }, "IX_ActiveMessages").IsUnique();

            entity.HasIndex(e => e.LookupField1, "IX_MessageQueue_LookupField1");

            entity.HasIndex(e => e.LookupField2, "IX_MessageQueue_LookupField2");

            entity.HasIndex(e => e.LookupField3, "IX_MessageQueue_LookupField3");

            entity.Property(e => e.QueueName).HasMaxLength(255);
            entity.Property(e => e.DateActive).HasColumnType("datetime");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateRequestExpires).HasColumnType("datetime");
            entity.Property(e => e.LookupField1).HasMaxLength(255);
            entity.Property(e => e.LookupField2).HasMaxLength(255);
            entity.Property(e => e.LookupField3).HasMaxLength(255);
            entity.Property(e => e.Sequence).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TransactionState>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransactionState");

            entity.HasIndex(e => e.OperationId, "PK_TransactionState")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
