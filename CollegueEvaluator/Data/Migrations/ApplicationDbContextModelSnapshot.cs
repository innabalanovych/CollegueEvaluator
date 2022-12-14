// <auto-generated />
using System;
using CollegueEvaluator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CollegueEvaluator.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CollegueEvaluator.Models.Evaluation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EvaluatedUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Performance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("СommunicationSkills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Evaluations");

                    b.HasData(
                        new
                        {
                            Id = "4d032c5e-39fa-4e68-8b37-a9a69f2e131e",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Вище середньої",
                            Qualification = "Низька",
                            Responsibility = "Нижче середнього",
                            UserId = "e5614207-a358-401a-8a49-3e078452f014",
                            СommunicationSkills = "Високе"
                        },
                        new
                        {
                            Id = "b137b02f-a818-4d85-9728-fb7d452883b8",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Дуже низька",
                            Qualification = "Нижче середньої",
                            Responsibility = "Ніколи",
                            UserId = "df2cb449-0517-4b3f-9e6c-46be44cb90bf",
                            СommunicationSkills = "Нижче середнього"
                        },
                        new
                        {
                            Id = "129de955-7aff-407b-a629-66b1098bb197",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Низька",
                            Qualification = "Дуже низька",
                            Responsibility = "Завжди",
                            UserId = "c14aa275-a95a-47fb-b514-4f59d151aaf8",
                            СommunicationSkills = "Низьке"
                        },
                        new
                        {
                            Id = "afdd3191-a081-490e-a5ba-3e8d7f6ceb76",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Низька",
                            Qualification = "Дуже низька",
                            Responsibility = "Завжди",
                            UserId = "d1c67d43-0542-424e-8c7f-be53c19de61e",
                            СommunicationSkills = "Низьке"
                        },
                        new
                        {
                            Id = "aec16cff-d685-49b8-b6fd-3903b07d953d",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Низька",
                            Qualification = "Дуже низька",
                            Responsibility = "Завжди",
                            UserId = "45b6f232-aad0-4dab-b451-becc22f2c3cc",
                            СommunicationSkills = "Низьке"
                        },
                        new
                        {
                            Id = "398b7b58-70b7-463b-ba42-3e12514603a3",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Дуже низька",
                            Responsibility = "Завжди",
                            UserId = "dc17264b-bf7a-4c32-9908-66eaa93db7e0",
                            СommunicationSkills = "Низьке"
                        },
                        new
                        {
                            Id = "70b65a79-4238-4b3d-9747-81d5d0d11355",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Дуже низька",
                            Responsibility = "Завжди",
                            UserId = "2c60ec20-9db0-41f3-8fa2-2aeeb00a0236",
                            СommunicationSkills = "Низьке"
                        },
                        new
                        {
                            Id = "68c3dd6e-dd5b-4081-bf4c-74be844fef34",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Дуже низька",
                            Responsibility = "Завжди",
                            UserId = "c0f4eba4-88b8-465e-99cf-2e1b48cd52f4",
                            СommunicationSkills = "Низьке"
                        },
                        new
                        {
                            Id = "3ccd96e3-2c3f-4364-b7d7-865a4716eee5",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Дуже низька",
                            Responsibility = "Завжди",
                            UserId = "0347d78a-c891-4b98-8386-e3919c5cc9c4",
                            СommunicationSkills = "Низьке"
                        },
                        new
                        {
                            Id = "8d745b9e-df33-46fb-9e1e-c22d620e0fbb",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Низька",
                            Qualification = "Нижче середньої",
                            Responsibility = "Нижче середнього",
                            UserId = "6b5f7196-6017-4375-b73d-6ff3b26bbf42",
                            СommunicationSkills = "Низьке"
                        },
                        new
                        {
                            Id = "b365b499-390f-4717-9252-3d860fdd6657",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Низька",
                            Responsibility = "Майже ніколи",
                            UserId = "1c111e8e-9954-46b0-8eb4-43e0ce05a4fa",
                            СommunicationSkills = "Нижче середнього"
                        },
                        new
                        {
                            Id = "1f1cfa42-0e3c-4ba4-bca4-1faa7a14373c",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Висока",
                            Responsibility = "Дуже часто",
                            UserId = "c34e8e69-bb80-45f1-9e5b-e519b9da0908",
                            СommunicationSkills = "Нижче середнього"
                        },
                        new
                        {
                            Id = "072ee08c-46a8-4728-9455-a1e1e7290042",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Висока",
                            Qualification = "Нижче середньої",
                            Responsibility = "Нижче середнього",
                            UserId = "eb091681-8153-466c-94b7-a7ca35f01ec8",
                            СommunicationSkills = "Високе"
                        },
                        new
                        {
                            Id = "cf0be48c-4723-4fa1-9d33-0a718ebf8fde",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Дуже висока",
                            Responsibility = "Завжди",
                            UserId = "281a7064-80f4-4076-a6ad-ca66a892a070",
                            СommunicationSkills = "Нижче середнього"
                        },
                        new
                        {
                            Id = "e13f4ac5-6a84-4d93-822d-ae9bcb13635b",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Дуже висока",
                            Qualification = "Нижче середньої",
                            Responsibility = "Нижче середнього",
                            UserId = "e213a476-a1de-4140-92e3-da24df33c930",
                            СommunicationSkills = "Дуже високе"
                        },
                        new
                        {
                            Id = "5f7069f1-57c2-4cb8-94d2-cd2be8c4d4ed",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Висока",
                            Qualification = "Висока",
                            Responsibility = "Дуже часто",
                            UserId = "9627361a-1308-4c14-a827-5235be64412e",
                            СommunicationSkills = "Високе"
                        },
                        new
                        {
                            Id = "8ee5fdbe-b41a-41f9-a501-52c635ed78a8",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Вище середньої",
                            Responsibility = "Нижче середнього",
                            UserId = "fa8f6afb-6d5e-4a8b-8b23-f982514bee71",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "42f14adf-68a1-46a9-b371-2ff482beef91",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Вище середньої",
                            Qualification = "Нижче середньої",
                            Responsibility = "Вище середнього",
                            UserId = "a1f9aeea-8813-438c-b2fa-e620adae6662",
                            СommunicationSkills = "Нижче середнього"
                        },
                        new
                        {
                            Id = "28425c75-b270-4abb-b17c-541c3d5ef341",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Низька",
                            Qualification = "Низька",
                            Responsibility = "Майже ніколи",
                            UserId = "fd20492e-52a4-4b59-b97a-ba3c443b0088",
                            СommunicationSkills = "Низьке"
                        },
                        new
                        {
                            Id = "0053ca23-e47d-4388-a06c-4bad96dd3f98",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Вище середньої",
                            Qualification = "Вище середньої",
                            Responsibility = "Вище середнього",
                            UserId = "f9f1461e-4c73-422c-925d-63716df3f4a2",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "04c93bb4-bd4b-4c9a-bc5d-5b72d37b8700",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Вище середньої",
                            Qualification = "Вище середньої",
                            Responsibility = "Вище середнього",
                            UserId = "9e965c8d-3396-4dff-ab29-adc7a76d00b9",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "e5fb9138-a188-4e1b-b23f-aecee08707fa",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Дуже висока",
                            Qualification = "Нижче середньої",
                            Responsibility = "Завжди",
                            UserId = "6e3b12e8-8c2c-4959-8303-a55ea2f4f87b",
                            СommunicationSkills = "Нижче середнього"
                        },
                        new
                        {
                            Id = "ebdfc705-81dc-4ce9-88a9-342aa07d6ebc",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Дуже висока",
                            Responsibility = "Нижче середнього",
                            UserId = "d4d13c22-7996-4fdb-acd1-0e369560545b",
                            СommunicationSkills = "Дуже високе"
                        },
                        new
                        {
                            Id = "b6a01e15-e7e4-454c-b131-944280315dd9",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Дуже висока",
                            Qualification = "Вище середньої",
                            Responsibility = "Завжди",
                            UserId = "1a44ec87-b909-4889-a758-4529ba21cbd1",
                            СommunicationSkills = "Високе"
                        },
                        new
                        {
                            Id = "25d9eeeb-f18c-4dae-b098-135e591ee222",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Вище середньої",
                            Qualification = "Висока",
                            Responsibility = "Дуже часто",
                            UserId = "640c6d4c-3c82-43f5-af0e-5da12b7ca56b",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "0cc36674-e680-42b9-92ba-ed699184fd5a",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Висока",
                            Qualification = "Вище середньої",
                            Responsibility = "Дуже часто",
                            UserId = "6d25c9fd-a65d-492a-84da-a40c915b1bb3",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "d9bf4736-9e9d-471d-9677-6efa4542569b",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Вище середньої",
                            Qualification = "Вище середньої",
                            Responsibility = "Вище середнього",
                            UserId = "5590cddb-be86-46f1-ad34-08a32a2bde2c",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "a5c21bbb-2773-4a16-a12b-64bda1c5866b",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Дуже висока",
                            Qualification = "Дуже висока",
                            Responsibility = "Завжди",
                            UserId = "f426e379-8148-4d20-9637-96cb34cb6b3f",
                            СommunicationSkills = "Дуже високе"
                        },
                        new
                        {
                            Id = "3658459a-8c0f-4495-9522-245185488a00",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Вище середньої",
                            Responsibility = "Нижче середнього",
                            UserId = "efc6ea69-3394-4d00-a733-104964b2ca6f",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "3001490b-999a-4a6a-89b7-375787245119",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Вище середньої",
                            Qualification = "Нижче середньої",
                            Responsibility = "Вище середнього",
                            UserId = "93b5fec0-bab2-4221-bd18-e8b3736cb9a3",
                            СommunicationSkills = "Нижче середнього"
                        },
                        new
                        {
                            Id = "b4dcb2e7-5de0-43ef-8efa-70b16f2b811c",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Дуже низька",
                            Qualification = "Дуже низька",
                            Responsibility = "Ніколи",
                            UserId = "d01baff7-d8f5-40f9-8798-b25b1549c890",
                            СommunicationSkills = "Дуже низьке"
                        },
                        new
                        {
                            Id = "3819186d-6895-43a5-83fc-1d6eb7265291",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Нижче середньої",
                            Responsibility = "Нижче середнього",
                            UserId = "7e56449f-a598-471d-9666-c0ac017319d7",
                            СommunicationSkills = "Нижче середнього"
                        },
                        new
                        {
                            Id = "a7e08b2a-ecc1-4a98-bf2a-75cf6d66e936",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Дуже висока",
                            Qualification = "Вище середньої",
                            Responsibility = "Завжди",
                            UserId = "27fa3bc7-616b-4af5-9cbe-aac818e638da",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "9d264910-9f91-4373-a577-7ebeb2848232",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Вище середньої",
                            Qualification = "Вище середньої",
                            Responsibility = "Вище середнього",
                            UserId = "7f5f5479-93e1-4948-9dfa-b597488019b5",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "cec5fc2d-fd23-4aa3-8256-235fda6c6a46",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Нижче середньої",
                            Qualification = "Нижче середньої",
                            Responsibility = "Нижче середнього",
                            UserId = "116cd90a-de19-45c1-8719-0f7e7fa2e16c",
                            СommunicationSkills = "Нижче середнього"
                        },
                        new
                        {
                            Id = "356374b2-17be-4ab6-af8f-bb2b3c309c90",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Висока",
                            Qualification = "Висока",
                            Responsibility = "Дуже часто",
                            UserId = "ad4a4c05-9ae1-49ac-a117-d1015ae478cc",
                            СommunicationSkills = "Високе"
                        },
                        new
                        {
                            Id = "cc853e51-111a-4dea-9b02-32d984091f9a",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Висока",
                            Qualification = "Низька",
                            Responsibility = "Нижче середнього",
                            UserId = "99a639c6-5dfa-411a-8997-505be7698b48",
                            СommunicationSkills = "Високе"
                        },
                        new
                        {
                            Id = "f393f673-779f-4b1d-b03a-7b7d3a6c8cc2",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Висока",
                            Qualification = "Нижче середньої",
                            Responsibility = "Вище середнього",
                            UserId = "9feb3ed4-1176-44a9-aea0-5cefdf77b9b4",
                            СommunicationSkills = "Високе"
                        },
                        new
                        {
                            Id = "774d243e-4772-4d76-b98b-c9ff733bbd3d",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Вище середньої",
                            Qualification = "Висока",
                            Responsibility = "Завжди",
                            UserId = "9a6532d3-5d7a-4c5a-a088-211c4dc40648",
                            СommunicationSkills = "Вище середнього"
                        },
                        new
                        {
                            Id = "4a2a9d9b-a31a-46d2-97ab-c574289f11ce",
                            EvaluatedUserName = "Rick_Sanchez",
                            Performance = "Висока",
                            Qualification = "Вище середньої",
                            Responsibility = "Дуже часто",
                            UserId = "d9de3f01-c253-4130-875b-c9d527c9ab0d",
                            СommunicationSkills = "Дуже високе"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
