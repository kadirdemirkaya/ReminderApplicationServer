﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReminderApp.Persistence.Data;

#nullable disable

namespace ReminderApp.Persistence.Migrations
{
    [DbContext(typeof(ReminderDbContext))]
    [Migration("20231224121504_meetingTableChanged")]
    partial class meetingTableChanged
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ReminderApp.Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 24, 15, 15, 4, 153, DateTimeKind.Local).AddTicks(8302));

                    b.Property<int>("Star")
                        .HasColumnType("int");

                    b.Property<string>("UserComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.HubConnection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConnectionType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 24, 15, 15, 4, 153, DateTimeKind.Local).AddTicks(8302));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("HubConnections", (string)null);
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ContentType")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 24, 15, 15, 4, 153, DateTimeKind.Local).AddTicks(8302));

                    b.Property<int>("FileType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Images", (string)null);
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.ImageUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("ImageUsers", (string)null);
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.Meeting", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 24, 15, 15, 4, 153, DateTimeKind.Local).AddTicks(8302));

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MeetingName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Meetings", (string)null);
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.MeetingItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 24, 15, 15, 4, 153, DateTimeKind.Local).AddTicks(8302));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MeetingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("MeetingId");

                    b.ToTable("MeetingItems", (string)null);
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 24, 15, 15, 4, 153, DateTimeKind.Local).AddTicks(8302));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("MessageType")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Notifications", (string)null);
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 24, 15, 15, 4, 153, DateTimeKind.Local).AddTicks(8302));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasAnnotation("RegularExpression", "[email_regex]");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenEndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.Comment", b =>
                {
                    b.HasOne("ReminderApp.Domain.Entities.User", "User")
                        .WithOne("Comment")
                        .HasForeignKey("ReminderApp.Domain.Entities.Comment", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.ImageUser", b =>
                {
                    b.HasOne("ReminderApp.Domain.Entities.Image", "Image")
                        .WithMany("ImageUsers")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReminderApp.Domain.Entities.User", "User")
                        .WithMany("ImageUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.MeetingItem", b =>
                {
                    b.HasOne("ReminderApp.Domain.Entities.Meeting", "Meeting")
                        .WithMany("MeetingItems")
                        .HasForeignKey("MeetingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.Image", b =>
                {
                    b.Navigation("ImageUsers");
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.Meeting", b =>
                {
                    b.Navigation("MeetingItems");
                });

            modelBuilder.Entity("ReminderApp.Domain.Entities.User", b =>
                {
                    b.Navigation("Comment")
                        .IsRequired();

                    b.Navigation("ImageUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
