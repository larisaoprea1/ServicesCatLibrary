using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace library1.Migrations
{
    public partial class libraryCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    authorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    author_firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author_lastname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.authorID);
                });

            migrationBuilder.CreateTable(
                name: "genres",
                columns: table => new
                {
                    genreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    genre_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genres", x => x.genreID);
                });

            migrationBuilder.CreateTable(
                name: "mainGenres",
                columns: table => new
                {
                    mainGenreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mainGenre_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mainGenres", x => x.mainGenreID);
                });

            migrationBuilder.CreateTable(
                name: "typeOfBooks",
                columns: table => new
                {
                    typeOfBookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeOfBook_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeOfBooks", x => x.typeOfBookID);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    user_lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    bookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    book_pages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    year = table.Column<int>(type: "int", nullable: false),
                    cover_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placeHolded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    authorID = table.Column<int>(type: "int", nullable: false),
                    genreID = table.Column<int>(type: "int", nullable: false),
                    mainGenreID = table.Column<int>(type: "int", nullable: false),
                    typeOfBookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.bookID);
                    table.ForeignKey(
                        name: "FK_books_authors_authorID",
                        column: x => x.authorID,
                        principalTable: "authors",
                        principalColumn: "authorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_genres_genreID",
                        column: x => x.genreID,
                        principalTable: "genres",
                        principalColumn: "genreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_mainGenres_mainGenreID",
                        column: x => x.mainGenreID,
                        principalTable: "mainGenres",
                        principalColumn: "mainGenreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_typeOfBooks_typeOfBookID",
                        column: x => x.typeOfBookID,
                        principalTable: "typeOfBooks",
                        principalColumn: "typeOfBookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "favoriteBooks",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false),
                    bookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_favoriteBooks", x => new { x.bookID, x.userID });
                    table.ForeignKey(
                        name: "FK_favoriteBooks_books_bookID",
                        column: x => x.bookID,
                        principalTable: "books",
                        principalColumn: "bookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_favoriteBooks_users_userID",
                        column: x => x.userID,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "placeHoldBooks",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false),
                    bookID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_placeHoldBooks", x => new { x.bookID, x.userID });
                    table.ForeignKey(
                        name: "FK_placeHoldBooks_books_bookID",
                        column: x => x.bookID,
                        principalTable: "books",
                        principalColumn: "bookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_placeHoldBooks_users_userID",
                        column: x => x.userID,
                        principalTable: "users",
                        principalColumn: "userID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_authorID",
                table: "books",
                column: "authorID");

            migrationBuilder.CreateIndex(
                name: "IX_books_genreID",
                table: "books",
                column: "genreID");

            migrationBuilder.CreateIndex(
                name: "IX_books_mainGenreID",
                table: "books",
                column: "mainGenreID");

            migrationBuilder.CreateIndex(
                name: "IX_books_typeOfBookID",
                table: "books",
                column: "typeOfBookID");

            migrationBuilder.CreateIndex(
                name: "IX_favoriteBooks_userID",
                table: "favoriteBooks",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_placeHoldBooks_userID",
                table: "placeHoldBooks",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "favoriteBooks");

            migrationBuilder.DropTable(
                name: "placeHoldBooks");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "genres");

            migrationBuilder.DropTable(
                name: "mainGenres");

            migrationBuilder.DropTable(
                name: "typeOfBooks");
        }
    }
}
