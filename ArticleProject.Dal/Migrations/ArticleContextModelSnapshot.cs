﻿// <auto-generated />
using System;
using ArticleProject.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArticleProject.Dal.Migrations
{
    [DbContext(typeof(ArticleContext))]
    partial class ArticleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticleProject.Model.Entities.AppUser", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CommentsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LikeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AppUser");
                });

            modelBuilder.Entity("ArticleProject.Model.Entities.Blog", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AppUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Confirmation")
                        .HasColumnType("bit");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Homepage")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReadNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("UsersID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("ArticleProject.Model.Entities.BlogComment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BlogID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CommentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BlogID");

                    b.HasIndex("CommentID");

                    b.ToTable("BlogComment");
                });

            modelBuilder.Entity("ArticleProject.Model.Entities.Category", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ArticleProject.Model.Entities.Comment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppUsersID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BlogID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AppUsersID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("ArticleProject.Model.Entities.Like", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AppUserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BlogID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedADUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedComputerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedIp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.HasIndex("BlogID");

                    b.ToTable("Like");
                });

            modelBuilder.Entity("ArticleProject.Model.Entities.Blog", b =>
                {
                    b.HasOne("ArticleProject.Model.Entities.AppUser", "AppUser")
                        .WithMany("Blogs")
                        .HasForeignKey("AppUserID");

                    b.HasOne("ArticleProject.Model.Entities.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleProject.Model.Entities.BlogComment", b =>
                {
                    b.HasOne("ArticleProject.Model.Entities.Blog", "Blogs")
                        .WithMany("BlogComments")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArticleProject.Model.Entities.Comment", "Comments")
                        .WithMany("BlogComments")
                        .HasForeignKey("CommentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleProject.Model.Entities.Comment", b =>
                {
                    b.HasOne("ArticleProject.Model.Entities.AppUser", "AppUsers")
                        .WithMany("Comments")
                        .HasForeignKey("AppUsersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleProject.Model.Entities.Like", b =>
                {
                    b.HasOne("ArticleProject.Model.Entities.AppUser", "AppUsers")
                        .WithMany("Likes")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArticleProject.Model.Entities.Blog", "Blogs")
                        .WithMany("Likes")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
