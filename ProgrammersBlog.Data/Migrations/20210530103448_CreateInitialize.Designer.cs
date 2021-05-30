﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;

namespace ProgrammersBlog.Data.Migrations
{
    [DbContext(typeof(ProgrammersBlogContext))]
    [Migration("20210530103448_CreateInitialize")]
    partial class CreateInitialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CommentCount")
                        .HasColumnType("int");

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoAuthor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("SeoTags")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CommentCount = 1,
                            CommentId = 0,
                            Content = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. \r\n                             Suspendisse sagittis blandit faucibus. Praesent mollis posuere vulputate. \r\n                             Pellentesque mollis risus varius nisl facilisis venenatis. \r\n                             Sed varius ante lorem, tristique varius mauris mollis eget. \r\n                             Ut dictum velit ut iaculis placerat. Donec dignissim tortor non orci dapibus lobortis. \r\n                             Proin vitae convallis metus, ut fermentum lacus. Etiam condimentum tristique finibus. \r\n                             Fusce convallis, ligula eget cursus imperdiet, turpis ante iaculis turpis, at fermentum purus risus non ante. \r\n                             Nunc sagittis nulla mattis metus interdum tempor.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 220, DateTimeKind.Local).AddTicks(8651),
                            Date = new DateTime(2021, 5, 30, 13, 34, 47, 220, DateTimeKind.Local).AddTicks(5774),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 221, DateTimeKind.Local).AddTicks(78),
                            Note = "C# 9.0 ve .NET5 Yenilikleri",
                            SeoAuthor = "Fatih Aydin",
                            SeoDescription = "C# 9.0 ve .NET5 Yenilikleri",
                            SeoTags = "C#, C# 9.0, .NET5, .NET Core, .NET Framework",
                            Thumbnail = "default.jpg",
                            Title = "C# 9.0 ve .NET5 Yenilikleri",
                            UserId = 1,
                            ViewsCount = 80
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CommentCount = 1,
                            CommentId = 0,
                            Content = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. \r\n                             Suspendisse sagittis blandit faucibus. Praesent mollis posuere vulputate. \r\n                             Pellentesque mollis risus varius nisl facilisis venenatis. \r\n                             Sed varius ante lorem, tristique varius mauris mollis eget. \r\n                             Ut dictum velit ut iaculis placerat. Donec dignissim tortor non orci dapibus lobortis. \r\n                             Proin vitae convallis metus, ut fermentum lacus. Etiam condimentum tristique finibus. \r\n                             Fusce convallis, ligula eget cursus imperdiet, turpis ante iaculis turpis, at fermentum purus risus non ante. \r\n                             Nunc sagittis nulla mattis metus interdum tempor.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 221, DateTimeKind.Local).AddTicks(2881),
                            Date = new DateTime(2021, 5, 30, 13, 34, 47, 221, DateTimeKind.Local).AddTicks(2879),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 221, DateTimeKind.Local).AddTicks(2882),
                            Note = "C++ 11 ve 19 Yenilikleri",
                            SeoAuthor = "Fatih Aydin",
                            SeoDescription = "C++ 11 ve 19 Yenilikleri",
                            SeoTags = "C++, Object Oriented Programming, C++ 11, QT",
                            Thumbnail = "default.jpg",
                            Title = "C++ 11 ve 19 Yenilikleri",
                            UserId = 1,
                            ViewsCount = 100
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CommentCount = 1,
                            CommentId = 0,
                            Content = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. \r\n                             Suspendisse sagittis blandit faucibus. Praesent mollis posuere vulputate. \r\n                             Pellentesque mollis risus varius nisl facilisis venenatis. \r\n                             Sed varius ante lorem, tristique varius mauris mollis eget. \r\n                             Ut dictum velit ut iaculis placerat. Donec dignissim tortor non orci dapibus lobortis. \r\n                             Proin vitae convallis metus, ut fermentum lacus. Etiam condimentum tristique finibus. \r\n                             Fusce convallis, ligula eget cursus imperdiet, turpis ante iaculis turpis, at fermentum purus risus non ante. \r\n                             Nunc sagittis nulla mattis metus interdum tempor.",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 221, DateTimeKind.Local).AddTicks(2890),
                            Date = new DateTime(2021, 5, 30, 13, 34, 47, 221, DateTimeKind.Local).AddTicks(2888),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 221, DateTimeKind.Local).AddTicks(2892),
                            Note = "ECMASCRIPT ve JavaScript ES6",
                            SeoAuthor = "Fatih Aydin",
                            SeoDescription = "ECMASCRIPT ve JavaScript ES6",
                            SeoTags = "JavScript, ES6, ECMAScript",
                            Thumbnail = "default.jpg",
                            Title = "JavaScipt ES6 Nedir?",
                            UserId = 1,
                            ViewsCount = 2940
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(480)
                        .HasColumnType("nvarchar(480)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 225, DateTimeKind.Local).AddTicks(7730),
                            Description = "C# Programlama Dili İle İlgili En Güncel Bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 225, DateTimeKind.Local).AddTicks(7745),
                            Name = "C#",
                            Note = "C# Blog Kategorisi"
                        },
                        new
                        {
                            Id = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 225, DateTimeKind.Local).AddTicks(7765),
                            Description = "C++ Programlama Dili İle İlgili En Güncel Bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 225, DateTimeKind.Local).AddTicks(7766),
                            Name = "C++",
                            Note = "C++ Blog Kategorisi"
                        },
                        new
                        {
                            Id = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 225, DateTimeKind.Local).AddTicks(7771),
                            Description = "JavaScript Programlama Dili İle İlgili En Güncel Bilgiler",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 225, DateTimeKind.Local).AddTicks(7773),
                            Name = "JavaScript",
                            Note = "JavaScript Blog Kategorisi"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1200)
                        .HasColumnType("nvarchar(1200)");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 228, DateTimeKind.Local).AddTicks(8748),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 228, DateTimeKind.Local).AddTicks(8768),
                            Note = "C# Makale Yorumu",
                            Text = "Yorum satırı - 1"
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 2,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 228, DateTimeKind.Local).AddTicks(8785),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 228, DateTimeKind.Local).AddTicks(8787),
                            Note = "C++ Makale Yorumu",
                            Text = "Yorum satırı - 2"
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 3,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 228, DateTimeKind.Local).AddTicks(8793),
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 228, DateTimeKind.Local).AddTicks(8795),
                            Note = "JavaScript Makale Yorumu",
                            Text = "Yorum satırı - 3"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 232, DateTimeKind.Local).AddTicks(353),
                            Description = "Admin Rolü, tüm yetkilere sahiptir.",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 232, DateTimeKind.Local).AddTicks(526),
                            Name = "Admin",
                            Note = "Admin Rolüdür."
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(480)
                        .HasColumnType("nvarchar(480)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(480)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 5, 30, 13, 34, 47, 251, DateTimeKind.Local).AddTicks(9411),
                            Description = "Admin Kullanıcısı",
                            Email = "fataycomputers@gmail.com",
                            FirstName = "Fatih",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Aydin",
                            ModifiedByName = "InitialModify",
                            ModifiedDate = new DateTime(2021, 5, 30, 13, 34, 47, 251, DateTimeKind.Local).AddTicks(9429),
                            Note = "Admin kullanıcısıdır.",
                            PasswordHash = new byte[] { 48, 49, 57, 50, 48, 50, 51, 97, 55, 98, 98, 100, 55, 51, 50, 53, 48, 53, 49, 54, 102, 48, 54, 57, 100, 102, 49, 56, 98, 53, 48, 48 },
                            Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU",
                            RoleId = 1,
                            Username = "fatay"
                        });
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProgrammersBlog.Entities.Concrete.User", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Article", "Article")
                        .WithMany("Comments")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.HasOne("ProgrammersBlog.Entities.Concrete.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Article", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ProgrammersBlog.Entities.Concrete.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
