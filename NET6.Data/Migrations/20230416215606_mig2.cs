using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET6.Data.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Job", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId" },
                values: new object[] { new Guid("8d9bdc14-eb22-43c7-85b2-5f83f755cff3"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(3831), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, "Web Developer", null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("65946803-6fe4-4c15-84b7-1604bd4c0b78"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(4124), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("69e27937-d653-493d-8f55-0e7727fae1ef"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(4150), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "a818417c-f933-4582-bcaa-e157ebcda0d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "d06eebdc-30ba-4af2-b0a0-52050996e5f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "b7debde7-4edf-4757-99d8-622b420e26cb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dee55078-0b17-4a76-b492-c05eec9448e7", "AQAAAAEAACcQAAAAEIS43GqnOI2OC54Eaim7hHVIr9Nhq6K8mrk6FRzzTpSnBpDm9bxxGW7U9s7YDVpbPw==", "21de468b-8803-4402-a903-a588b60a74cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c77ce6a9-f969-4c6e-93fd-44aad60d6ba1", "AQAAAAEAACcQAAAAEIyjoiJrHpbJcVkxWggjVoyr4FaljSHb1jMISRJesTvLzO0hpAafkEy+6RkopTOHZw==", "302006a0-ab26-4283-8106-183112417cc4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.InsertData(
                table: "Histories",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SFDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("9c7bfabb-17ff-4859-b6f7-6434cf1b250f"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(6116), null, null, false, null, null, "Educatıon", "December 24", "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("a8953947-82eb-471a-9ba0-ee495c5f6584"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(6103), null, null, false, null, null, "Resume", "December 24", "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1ab11d93-303a-4a21-9b4f-eb4710dfa373"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(6458), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("7d18f908-8b6e-4082-a370-125e5a9c4444"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(6449), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[] { new Guid("f6a9e525-ebc8-4967-b5db-91663ddc0628"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 11, DateTimeKind.Local).AddTicks(8314), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("59d9a438-3e21-4163-a42d-a13003d76831"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 0, 56, 5, 12, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 0, 56, 5, 12, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Percent", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("4f2e1b59-a5cb-42c2-86c1-7970238e77f7"), new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"), "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 12, DateTimeKind.Local).AddTicks(5883), null, null, false, null, null, "90", "Designer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("891d617d-f1df-431a-a636-5b0c5d164d87"), new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"), "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 12, DateTimeKind.Local).AddTicks(5876), null, null, false, null, null, "90", "Coder", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("5b7d640d-123d-4437-8d53-c58f4ce6858f"), "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 12, DateTimeKind.Local).AddTicks(6041), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "A Firması", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("6df40233-998b-4760-baf0-8a5eecf0e9c7"), "Admin Test", new DateTime(2023, 4, 17, 0, 56, 5, 12, DateTimeKind.Local).AddTicks(6053), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "B Firması", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: new Guid("8d9bdc14-eb22-43c7-85b2-5f83f755cff3"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("65946803-6fe4-4c15-84b7-1604bd4c0b78"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("69e27937-d653-493d-8f55-0e7727fae1ef"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("9c7bfabb-17ff-4859-b6f7-6434cf1b250f"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("a8953947-82eb-471a-9ba0-ee495c5f6584"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("1ab11d93-303a-4a21-9b4f-eb4710dfa373"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("7d18f908-8b6e-4082-a370-125e5a9c4444"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "Id",
                keyValue: new Guid("f6a9e525-ebc8-4967-b5db-91663ddc0628"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4f2e1b59-a5cb-42c2-86c1-7970238e77f7"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("891d617d-f1df-431a-a636-5b0c5d164d87"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("5b7d640d-123d-4437-8d53-c58f4ce6858f"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("6df40233-998b-4760-baf0-8a5eecf0e9c7"));

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
        }
    }
}
