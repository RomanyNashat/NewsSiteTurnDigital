using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NewsSiteTurnDigital.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "NewsCategories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "85967485@TurnDigital", "TurnDigital" });

            migrationBuilder.InsertData(
                table: "NewsCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "IsDeleted", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(4087), false, "Health", null, null },
                    { 2, "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(4097), false, "Tech", null, null },
                    { 3, "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(4099), false, "Fashion", null, null },
                    { 4, "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(4101), false, "Sport", null, null }
                });

            migrationBuilder.InsertData(
                table: "NewsItems",
                columns: new[] { "Id", "AdminId", "CategoryId", "Content", "CreatedBy", "CreatedDate", "ImageUrl", "IsDeleted", "IsFirstPage", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3765), "News Item -  (1).jpg", false, true, "The standard Lorem Ipsum passage, used since the 1500s", null, null },
                    { 2, 1, 4, "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3808), "News Item -  (2).jpg", false, true, "Section 1.10.32 of de Finibus Bonorum et Malorum, written by Cicero in 45 BC", null, null },
                    { 3, 1, 2, "But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3811), "News Item -  (3).jpg", false, true, "1914 translation by H. Rackham", null, null },
                    { 4, 1, 3, "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3814), "News Item -  (4).jpg", false, false, "Section 1.10.33 of de Finibus Bonorum et Malorum, written by Cicero in 45 BC", null, null },
                    { 5, 1, 4, "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains.", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3817), "News Item -  (5).jpg", false, false, "1914 translation by H. Rackham", null, null },
                    { 6, 1, 2, "OnLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3820), "News Item -  (6).jpg", false, false, "What is Lorem Ipsum?", null, null },
                    { 7, 1, 4, "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32.", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3823), "News Item -  (7).jpg", false, false, "Where does it come from?", null, null },
                    { 8, 1, 2, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3826), "News Item -  (8).jpg", false, false, "Why do we use it?", null, null },
                    { 9, 1, 3, "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3858), "News Item -  (9).jpg", false, false, "Where can I get some?", null, null },
                    { 10, 1, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris vel magna vitae metus accumsan eleifend nec et mi. Nulla ut ultricies mauris. Mauris porttitor nibh vel gravida laoreet. Nullam cursus enim sit amet magna convallis, eget faucibus tortor viverra. Vestibulum gravida consectetur justo, vitae convallis leo congue et. Praesent eget sem facilisis, lacinia orci at, rutrum magna. Nunc consectetur dolor at odio auctor, eu dapibus est convallis.", "TurnDigital", new DateTime(2023, 5, 24, 20, 49, 27, 51, DateTimeKind.Local).AddTicks(3862), "News Item -  (10).jpg", false, false, "Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NewsItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NewsCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "NewsItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                table: "NewsCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
