using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET6.Data.Migrations
{
    public partial class aboutseo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: new Guid("c4446e6f-eb75-4173-a47c-f211232d0f78"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("166564c4-adfc-46e1-bfaf-887956ad8a52"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5d754625-08a7-4730-88c7-dcb2bf7c1cc4"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("99235e5c-cac0-4245-ab4e-7b1c7eb9cdb8"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("a7e97a38-d284-4a58-a890-78d78d19756c"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("8b1e41d1-db2e-4e28-996b-85e69d011a7f"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("9e0bd45a-bf6c-4e1f-add5-cd9b8330f38f"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "Id",
                keyValue: new Guid("3cfa5501-88ea-4e8b-80ba-f9c28f23b867"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("eb7deb38-ebff-4779-9282-b4983928e082"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("f510711d-de46-4db0-8f78-964db0ce399a"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("dcbdb25b-ee2d-4ae7-884d-9d0a51193bf5"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("fb292565-0bb9-42fc-9dd7-9300dd2262f3"));

            migrationBuilder.AddColumn<Guid>(
                name: "SeoId",
                table: "Abouts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Job", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId" },
                values: new object[] { new Guid("3ece6043-1098-4873-b2a6-081395e652fe"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(1446), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, "Web Developer", null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("98fbd47d-7c22-471f-b190-9b4f9d453c84"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(1955), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("ced84ede-a738-49dc-b681-b4cdab36a376"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(1975), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "4d1deb3a-cabc-4125-b9a8-64ed45622c7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "e9d87413-ef5a-4fae-aced-85ddf698b2d1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "1d7d6eef-4978-47a5-badd-c12c2e31955a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef217f6-462a-4851-b13d-e018983635f0", "AQAAAAEAACcQAAAAEMWYRtmcQj+ai/lMrIPh8ir8gQQXYZTnX6bzEowYg8jUgR5o+gRr9CreeGr7BV+Vzw==", "502323c4-ab0a-4cee-b25e-2616527931ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15f565c5-8092-4e3c-b4f5-35ee8ffea5c0", "AQAAAAEAACcQAAAAEJhNdjriF48Kkc4iRj/GvFqyXqE7G9qhkNTaviKvq/ImC5uoB0zUqxXGPl6KjjjLxQ==", "1c4aff95-297d-4d50-ab8f-597d46466bd4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(5434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.InsertData(
                table: "Histories",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SFDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("023a4b67-83cc-45f3-b97d-80965bad1b24"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(5882), null, null, false, null, null, "Resume", "December 24", "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("d857e6c4-a1dd-4e09-9189-274d38710836"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(5892), null, null, false, null, null, "Educatıon", "December 24", "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("23c04655-f516-4261-b88c-29a60a244102"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(6580), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("40e46ff5-4a53-49bd-8bea-2e68fec0b6d2"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(6558), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[] { new Guid("2043b7c9-535e-4b75-b03f-c9843d5d5c8a"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 16, 2, 10, 20, 999, DateTimeKind.Local).AddTicks(9811), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("59d9a438-3e21-4163-a42d-a13003d76831"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 2, 10, 21, 1, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 16, 2, 10, 21, 1, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Percent", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f7f83ea-dbe0-4b71-8495-7e64c4b0810f"), new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"), "Admin Test", new DateTime(2023, 4, 16, 2, 10, 21, 1, DateTimeKind.Local).AddTicks(4268), null, null, false, null, null, "90", "Designer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("7dd274f9-a3fb-4971-ae63-6ac3342ab97d"), new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"), "Admin Test", new DateTime(2023, 4, 16, 2, 10, 21, 1, DateTimeKind.Local).AddTicks(4228), null, null, false, null, null, "90", "Coder", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("34fbcd05-98c3-4d32-95aa-77206938cc9f"), "Admin Test", new DateTime(2023, 4, 16, 2, 10, 21, 1, DateTimeKind.Local).AddTicks(4634), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "B Firması", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("6b88002b-766a-46fa-9b7f-667b94ee16b2"), "Admin Test", new DateTime(2023, 4, 16, 2, 10, 21, 1, DateTimeKind.Local).AddTicks(4620), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "A Firması", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_SeoId",
                table: "Abouts",
                column: "SeoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Seos_SeoId",
                table: "Abouts",
                column: "SeoId",
                principalTable: "Seos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Seos_SeoId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_SeoId",
                table: "Abouts");

            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: new Guid("3ece6043-1098-4873-b2a6-081395e652fe"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("98fbd47d-7c22-471f-b190-9b4f9d453c84"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ced84ede-a738-49dc-b681-b4cdab36a376"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("023a4b67-83cc-45f3-b97d-80965bad1b24"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("d857e6c4-a1dd-4e09-9189-274d38710836"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("23c04655-f516-4261-b88c-29a60a244102"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("40e46ff5-4a53-49bd-8bea-2e68fec0b6d2"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "Id",
                keyValue: new Guid("2043b7c9-535e-4b75-b03f-c9843d5d5c8a"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("0f7f83ea-dbe0-4b71-8495-7e64c4b0810f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("7dd274f9-a3fb-4971-ae63-6ac3342ab97d"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("34fbcd05-98c3-4d32-95aa-77206938cc9f"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("6b88002b-766a-46fa-9b7f-667b94ee16b2"));

            migrationBuilder.DropColumn(
                name: "SeoId",
                table: "Abouts");

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Job", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[] { new Guid("c4446e6f-eb75-4173-a47c-f211232d0f78"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(3389), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, "Web Developer", null, null, "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("166564c4-adfc-46e1-bfaf-887956ad8a52"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(3782), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("5d754625-08a7-4730-88c7-dcb2bf7c1cc4"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(3771), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "658e4cde-799d-474f-a312-8520de0410d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "8802a0e6-55dc-44f3-9188-d435c44b4212");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "fa82d90f-1a34-498d-b00d-2c8682eacd68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a1b90e2-c38a-47d7-9431-a1ce46434689", "AQAAAAEAACcQAAAAEFM084Lf69chVs8H9QOLnVCUs5g1zb3NxN8fgdd3A0MIqmhIK7ThrEnk6u7ydz/hSw==", "6ae55250-e25b-4684-9dba-e76f11f05a49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "566cfb34-7c06-4bca-95af-a59e04491604", "AQAAAAEAACcQAAAAEJsZAa87ukw/cznRp0WmOp2U5Ra2Rv6qIZ3QfqpZTNtMYUdJpGvzSStMxBF8JpB90g==", "56573ff2-626c-45c5-9249-4de0af7e40b2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.InsertData(
                table: "Histories",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SFDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("99235e5c-cac0-4245-ab4e-7b1c7eb9cdb8"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(5957), null, null, false, null, null, "Resume", "December 24", "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("a7e97a38-d284-4a58-a890-78d78d19756c"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(5966), null, null, false, null, null, "Educatıon", "December 24", "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("8b1e41d1-db2e-4e28-996b-85e69d011a7f"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(6407), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("9e0bd45a-bf6c-4e1f-add5-cd9b8330f38f"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(6393), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[] { new Guid("3cfa5501-88ea-4e8b-80ba-f9c28f23b867"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 717, DateTimeKind.Local).AddTicks(8109), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("59d9a438-3e21-4163-a42d-a13003d76831"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 14, 21, 26, 17, 718, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 14, 21, 26, 17, 718, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Percent", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("eb7deb38-ebff-4779-9282-b4983928e082"), new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"), "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 718, DateTimeKind.Local).AddTicks(6074), null, null, false, null, null, "90", "Coder", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("f510711d-de46-4db0-8f78-964db0ce399a"), new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"), "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 718, DateTimeKind.Local).AddTicks(6081), null, null, false, null, null, "90", "Designer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("dcbdb25b-ee2d-4ae7-884d-9d0a51193bf5"), "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 718, DateTimeKind.Local).AddTicks(6359), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "A Firması", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("fb292565-0bb9-42fc-9dd7-9300dd2262f3"), "Admin Test", new DateTime(2023, 4, 14, 21, 26, 17, 718, DateTimeKind.Local).AddTicks(6368), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "B Firması", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }
    }
}
