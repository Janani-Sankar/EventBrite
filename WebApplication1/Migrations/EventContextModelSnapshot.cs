﻿// <auto-generated />
using EventAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventAPI.Migrations
{
    [DbContext(typeof(EventContext))]
    partial class EventContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.category_hilo", "'category_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.events_hilo", "'events_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.eventtype_hilo", "'eventtype_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.price_hilo", "'price_hilo', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventAPI.Domain.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "events_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<int>("DateTime")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("EventCategoryID");

                    b.Property<int>("EventTypeID");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("EventCategoryID");

                    b.HasIndex("EventTypeID");

                    b.ToTable("event");
                });

            modelBuilder.Entity("EventAPI.Domain.EventCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "category_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("EventAPI.Domain.EventPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "price_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("EventAPI.Domain.EventType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:HiLoSequenceName", "eventtype_hilo")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Typename")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("EventAPI.Domain.Event", b =>
                {
                    b.HasOne("EventAPI.Domain.EventCategory", "EventCategory")
                        .WithMany()
                        .HasForeignKey("EventCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EventAPI.Domain.EventType", "EventType")
                        .WithMany()
                        .HasForeignKey("EventTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
