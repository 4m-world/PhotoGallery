using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using PhotoGallery.Infrastructure;

namespace PhotoGallery.Migrations
{
    [DbContext(typeof(PhotoGalleryContext))]
    [Migration("20160506104805_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PhotoGallery.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 512);

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 128);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PhotoGallery.Entities.Error", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Message");

                    b.Property<string>("StackTrace");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PhotoGallery.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AlbumId");

                    b.Property<DateTime>("DateUploaded");

                    b.Property<string>("Title")
                        .HasAnnotation("MaxLength", 128);

                    b.Property<string>("Uri");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PhotoGallery.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 64);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PhotoGallery.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("IsLocked");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 128);

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PhotoGallery.Entities.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("PhotoGallery.Entities.Photo", b =>
                {
                    b.HasOne("PhotoGallery.Entities.Album")
                        .WithMany()
                        .HasForeignKey("AlbumId");
                });

            modelBuilder.Entity("PhotoGallery.Entities.UserRole", b =>
                {
                    b.HasOne("PhotoGallery.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("PhotoGallery.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
