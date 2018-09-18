﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iQuarc.DataLocalization.Tests.DataBase;

namespace iQuarc.DataLocalization.Tests.Migrations
{
    [DbContext(typeof(TranslationContext))]
    partial class TranslationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("iQuarc.DataLocalization.Tests.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Description = "Selection of craft beers", Name = "Beers" },
                        new { Id = 2, Description = "Local and international wines", Name = "Wines" },
                        new { Id = 3, Description = "Bistro foods and snacks", Name = "Foods" }
                    );
                });

            modelBuilder.Entity("iQuarc.DataLocalization.Tests.Model.CategoryLocalization", b =>
                {
                    b.Property<int>("CategoryId");

                    b.Property<int>("LanguageId");

                    b.Property<string>("CommercialName")
                        .HasMaxLength(128);

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(512);

                    b.HasKey("CategoryId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CategoryLocalizations");

                    b.HasData(
                        new { CategoryId = 1, LanguageId = 1, Description = "Sélection de bières artisanales", Name = "Bières" },
                        new { CategoryId = 1, LanguageId = 2, Description = "Selecţie de bere artizanalã", Name = "Beri" },
                        new { CategoryId = 2, LanguageId = 1, Description = "Vins locaux et internationaux", Name = "Vins" },
                        new { CategoryId = 2, LanguageId = 2, Description = "Mâncãruri bistro și gustări", Name = "Vinuri" },
                        new { CategoryId = 3, LanguageId = 1, Description = "Mets et collations Bistro", Name = "Aliments" }
                    );
                });

            modelBuilder.Entity("iQuarc.DataLocalization.Tests.Model.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IsoCode");

                    b.Property<int>("LCID");

                    b.Property<string>("Name");

                    b.Property<string>("ThreeLetterIsoCode");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new { Id = 1, IsoCode = "fr", LCID = 12, Name = "French", ThreeLetterIsoCode = "fra" },
                        new { Id = 2, IsoCode = "ro", LCID = 24, Name = "Romanian", ThreeLetterIsoCode = "ron" }
                    );
                });

            modelBuilder.Entity("iQuarc.DataLocalization.Tests.Model.CategoryLocalization", b =>
                {
                    b.HasOne("iQuarc.DataLocalization.Tests.Model.Category", "Category")
                        .WithMany("Localizations")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("iQuarc.DataLocalization.Tests.Model.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
