﻿// <auto-generated />
using System;
using EFCoreMovies;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#nullable disable

namespace EFCoreMovies.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220302130436_PeopleAndMessages")]
    partial class PeopleAndMessages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CinemaHallMovie", b =>
                {
                    b.Property<int>("CinemaHallsId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("CinemaHallsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CinemaHallMovie");

                    b.HasData(
                        new
                        {
                            CinemaHallsId = 3,
                            MoviesId = 5
                        },
                        new
                        {
                            CinemaHallsId = 4,
                            MoviesId = 5
                        },
                        new
                        {
                            CinemaHallsId = 1,
                            MoviesId = 5
                        },
                        new
                        {
                            CinemaHallsId = 2,
                            MoviesId = 5
                        },
                        new
                        {
                            CinemaHallsId = 5,
                            MoviesId = 5
                        },
                        new
                        {
                            CinemaHallsId = 6,
                            MoviesId = 5
                        },
                        new
                        {
                            CinemaHallsId = 7,
                            MoviesId = 5
                        });
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Biography")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "Thomas Stanley Holland (born 1 June 1996) is an English actor. He is recipient of several accolades, including the 2017 BAFTA Rising Star Award. Holland began his acting career as a child actor on the West End stage in Billy Elliot the Musical at the Victoria Palace Theatre in 2008, playing a supporting part",
                            DateOfBirth = new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tom Holland"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Samuel Leroy Jackson (born December 21, 1948) is an American actor and producer. One of the most widely recognized actors of his generation, the films in which he has appeared have collectively grossed over $27 billion worldwide, making him the highest-grossing actor of all time (excluding cameo appearances and voice roles).",
                            DateOfBirth = new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "Robert John Downey Jr. (born April 4, 1965) is an American actor and producer. His career has been characterized by critical and popular success in his youth, followed by a period of substance abuse and legal troubles, before a resurgence of commercial success later in his career.",
                            DateOfBirth = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Robert Downey Jr."
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1981, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Chris Evans"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1972, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dwayne Johnson"
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(2000, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Auli'i Cravalho"
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Scarlett Johansson"
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Keanu Reeves"
                        });
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Point>("Location")
                        .HasColumnType("geography");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.9388777 18.4839233)"),
                            Name = "Agora Mall"
                        },
                        new
                        {
                            Id = 2,
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.911582 18.482455)"),
                            Name = "Sambil"
                        },
                        new
                        {
                            Id = 3,
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.856309 18.506662)"),
                            Name = "Megacentro"
                        },
                        new
                        {
                            Id = 4,
                            Location = (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-69.939248 18.469649)"),
                            Name = "Acropolis"
                        });
                });

            modelBuilder.Entity("EFCoreMovies.Entities.CinemaHall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CinemaHallType")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("TwoDimensions");

                    b.Property<decimal>("Cost")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TheCinemaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TheCinemaId");

                    b.ToTable("CinemaHalls");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            CinemaHallType = "TwoDimensions",
                            Cost = 250m,
                            Currency = "",
                            TheCinemaId = 3
                        },
                        new
                        {
                            Id = 6,
                            CinemaHallType = "ThreeDimensions",
                            Cost = 330m,
                            Currency = "",
                            TheCinemaId = 3
                        },
                        new
                        {
                            Id = 7,
                            CinemaHallType = "CXC",
                            Cost = 450m,
                            Currency = "",
                            TheCinemaId = 3
                        },
                        new
                        {
                            Id = 8,
                            CinemaHallType = "TwoDimensions",
                            Cost = 250m,
                            Currency = "",
                            TheCinemaId = 4
                        },
                        new
                        {
                            Id = 1,
                            CinemaHallType = "TwoDimensions",
                            Cost = 220m,
                            Currency = "",
                            TheCinemaId = 1
                        },
                        new
                        {
                            Id = 2,
                            CinemaHallType = "ThreeDimensions",
                            Cost = 320m,
                            Currency = "",
                            TheCinemaId = 1
                        },
                        new
                        {
                            Id = 3,
                            CinemaHallType = "TwoDimensions",
                            Cost = 200m,
                            Currency = "",
                            TheCinemaId = 2
                        },
                        new
                        {
                            Id = 4,
                            CinemaHallType = "ThreeDimensions",
                            Cost = 290m,
                            Currency = "",
                            TheCinemaId = 2
                        });
                });

            modelBuilder.Entity("EFCoreMovies.Entities.CinemaOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Begin")
                        .HasColumnType("date");

                    b.Property<int>("CinemaId")
                        .HasColumnType("int");

                    b.Property<decimal>("DiscountPercentage")
                        .HasPrecision(5, 2)
                        .HasColumnType("decimal(5,2)");

                    b.Property<DateTime>("End")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId")
                        .IsUnique();

                    b.ToTable("CinemaOffers");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Begin = new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CinemaId = 4,
                            DiscountPercentage = 15m,
                            End = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 1,
                            Begin = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CinemaId = 1,
                            DiscountPercentage = 10m,
                            End = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("IsDeleted = 'false'");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Keyless.CinemaWithoutLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToView(null);

                    b.ToSqlQuery("Select Id, Name FROM Cinemas");
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Keyless.MovieWithCounts", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmountActors")
                        .HasColumnType("int");

                    b.Property<int>("AmountCinemas")
                        .HasColumnType("int");

                    b.Property<int>("AmountGenres")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToView("MoviesWithCounts");
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Message")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Hello, Claudia!",
                            ReceiverId = 2,
                            SenderId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Hello, Felipe, how are you?",
                            ReceiverId = 1,
                            SenderId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "All good, and you?",
                            ReceiverId = 2,
                            SenderId = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "Very good :)",
                            ReceiverId = 1,
                            SenderId = 2
                        });
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("InCinemas")
                        .HasColumnType("bit");

                    b.Property<string>("PosterURL")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InCinemas = false,
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg",
                            ReleaseDate = new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Avengers"
                        },
                        new
                        {
                            Id = 2,
                            InCinemas = false,
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/9/98/Coco_%282017_film%29_poster.jpg",
                            ReleaseDate = new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Coco"
                        },
                        new
                        {
                            Id = 3,
                            InCinemas = false,
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            ReleaseDate = new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: No way home"
                        },
                        new
                        {
                            Id = 4,
                            InCinemas = false,
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            ReleaseDate = new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: Far From Home"
                        },
                        new
                        {
                            Id = 5,
                            InCinemas = true,
                            PosterURL = "https://upload.wikimedia.org/wikipedia/en/5/50/The_Matrix_Resurrections.jpg",
                            ReleaseDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix Resurrections"
                        });
                });

            modelBuilder.Entity("EFCoreMovies.Entities.MovieActor", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("Character")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MoviesActors");

                    b.HasData(
                        new
                        {
                            MovieId = 4,
                            ActorId = 2,
                            Character = "Samuel L. Jackson",
                            Order = 2
                        },
                        new
                        {
                            MovieId = 4,
                            ActorId = 1,
                            Character = "Peter Parker",
                            Order = 1
                        },
                        new
                        {
                            MovieId = 3,
                            ActorId = 1,
                            Character = "Peter Parker",
                            Order = 1
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 3,
                            Character = "Iron Man",
                            Order = 2
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 7,
                            Character = "Black Widow",
                            Order = 3
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 4,
                            Character = "Capitán América",
                            Order = 1
                        },
                        new
                        {
                            MovieId = 5,
                            ActorId = 8,
                            Character = "Neo",
                            Order = 1
                        });
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Felipe"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Claudia"
                        });
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("int");

                    b.Property<int>("MoviesId")
                        .HasColumnType("int");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");

                    b.HasData(
                        new
                        {
                            GenresId = 1,
                            MoviesId = 1
                        },
                        new
                        {
                            GenresId = 4,
                            MoviesId = 1
                        },
                        new
                        {
                            GenresId = 2,
                            MoviesId = 2
                        },
                        new
                        {
                            GenresId = 4,
                            MoviesId = 3
                        },
                        new
                        {
                            GenresId = 1,
                            MoviesId = 3
                        },
                        new
                        {
                            GenresId = 3,
                            MoviesId = 3
                        },
                        new
                        {
                            GenresId = 4,
                            MoviesId = 4
                        },
                        new
                        {
                            GenresId = 1,
                            MoviesId = 4
                        },
                        new
                        {
                            GenresId = 3,
                            MoviesId = 4
                        },
                        new
                        {
                            GenresId = 4,
                            MoviesId = 5
                        },
                        new
                        {
                            GenresId = 1,
                            MoviesId = 5
                        },
                        new
                        {
                            GenresId = 5,
                            MoviesId = 5
                        });
                });

            modelBuilder.Entity("CinemaHallMovie", b =>
                {
                    b.HasOne("EFCoreMovies.Entities.CinemaHall", null)
                        .WithMany()
                        .HasForeignKey("CinemaHallsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreMovies.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreMovies.Entities.CinemaHall", b =>
                {
                    b.HasOne("EFCoreMovies.Entities.Cinema", "Cinema")
                        .WithMany("CinemaHalls")
                        .HasForeignKey("TheCinemaId");

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("EFCoreMovies.Entities.CinemaOffer", b =>
                {
                    b.HasOne("EFCoreMovies.Entities.Cinema", null)
                        .WithOne("CinemaOffer")
                        .HasForeignKey("EFCoreMovies.Entities.CinemaOffer", "CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Message", b =>
                {
                    b.HasOne("EFCoreMovies.Entities.Person", "Receiver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreMovies.Entities.Person", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("EFCoreMovies.Entities.MovieActor", b =>
                {
                    b.HasOne("EFCoreMovies.Entities.Actor", "Actor")
                        .WithMany("MoviesActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreMovies.Entities.Movie", "Movie")
                        .WithMany("MoviesActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("EFCoreMovies.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreMovies.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Actor", b =>
                {
                    b.Navigation("MoviesActors");
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Cinema", b =>
                {
                    b.Navigation("CinemaHalls");

                    b.Navigation("CinemaOffer");
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Movie", b =>
                {
                    b.Navigation("MoviesActors");
                });

            modelBuilder.Entity("EFCoreMovies.Entities.Person", b =>
                {
                    b.Navigation("ReceivedMessages");

                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
