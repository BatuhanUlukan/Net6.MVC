using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET6.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Links_LinkId",
                table: "Abouts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_LinkId",
                table: "Abouts");

            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: new Guid("ce340844-a263-401e-99d1-a96ab5d32c14"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4fabec1b-7e8d-45a3-a705-d2a7dcd81b1c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("aeb44c6a-4f42-4698-bd30-db391f9d403d"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("19bd7841-b26b-429b-82e6-32066c43fa5c"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("6ef081e6-83c0-4383-a95f-ee82389e8448"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("e4794cd9-d3c4-4d11-af0d-c4966c0ccdb7"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("f6ae5dda-0ac7-4b6c-ad4a-80bf58418eb9"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "Id",
                keyValue: new Guid("5a28373e-c1b2-4541-a435-047acd3f2423"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("6fb7e9fc-12ee-492f-8c52-feb0345e90d6"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("80ccd016-1a46-4bec-af73-2d52134bb9b7"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("d3ea1bbe-286f-4b10-b83c-4e0308d20a23"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("d5f87828-aa19-4d32-bba8-66a7ba4fb65d"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("4316d668-9d78-4bcd-80aa-f7bcbcd1d5e1"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("6d051a0e-e91e-4d54-91c1-dc4542419337"));

            migrationBuilder.DropColumn(
                name: "LinkId",
                table: "Abouts");

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Job", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId" },
                values: new object[] { new Guid("0fcadb1c-cb86-4e4c-80e2-2229c5d1fa93"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(4322), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, "Web Developer", null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("6da0a5f4-fc6a-41af-840c-c17ed3f5b7e6"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(4690), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("ea48aef8-48c3-4af1-b96d-538c890d88d6"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(4701), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "f47b103a-492b-491b-ab6d-5a531ef1891c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "d8e32f47-83b2-4642-b7a1-5ee9aadf1485");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "ea47f103-edf3-40d4-9308-98035440e939");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4daf745c-ba6a-4611-9476-8c2ab60568a3", "AQAAAAEAACcQAAAAEFsr39cdU9ivEfsk4mojAqaVylXYbLFGofV807vZ+Yvje1MWaKtw2RU6kOez3U3FfA==", "8893c164-9dfd-4fff-9ee7-3e803776f135" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f19f6a5f-2724-474d-a7a6-1596e7ca3bcd", "AQAAAAEAACcQAAAAEIRvuuAUlBWL1iieZqNUXoqFrhdTO0a9zr3mbBSG7XzbKtM/f38pmMKxSkBS6gNAqg==", "aa2896f8-5fcd-4507-bd3c-84d360dbc46f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2864cc7d-73fe-47b9-a5b1-bb58f6046d5c"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53bb0f44-9f0d-447b-9a18-84722b1abde5"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.InsertData(
                table: "Histories",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SFDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("cf96783a-69cb-42cb-bf08-8913c96cc609"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(7182), null, null, false, null, null, "Resume", "December 24", "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("e8267e9f-45a6-46fd-b7b9-438f692382d4"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(7196), null, null, false, null, null, "Educatıon", "December 24", "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("bc318ed5-f314-445a-8031-cd7525f039db"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(7786), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("ccab2cab-4441-4503-b9f5-f2c9847dfff4"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 574, DateTimeKind.Local).AddTicks(7802), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[] { new Guid("1d3a40ba-001d-4051-9e37-aa844cb13f49"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Nulla porttitor accumsan tincidunt.", "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 575, DateTimeKind.Local).AddTicks(114), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("59d9a438-3e21-4163-a42d-a13003d76831"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 575, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 27, 21, 0, 50, 575, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Percent", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("4c241bcd-061e-4899-ba83-0356e6517ecc"), new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"), "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 575, DateTimeKind.Local).AddTicks(9047), null, null, false, null, null, "90", "Designer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("fd827fb1-40bb-4a9f-8646-ea2630374dae"), new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"), "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 575, DateTimeKind.Local).AddTicks(9040), null, null, false, null, null, "90", "Coder", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Icon", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("918646c9-da37-4a8f-a5ec-b7d159bae8e7"), "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 575, DateTimeKind.Local).AddTicks(9253), null, null, "google", false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, "Google" },
                    { new Guid("9a0abf3b-6223-44d3-997d-be07e3f89a38"), "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 575, DateTimeKind.Local).AddTicks(9245), null, null, "instagram", false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "Instagram" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("14f70762-396c-4028-998e-31ec58142502"), "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 575, DateTimeKind.Local).AddTicks(9437), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "A Firması", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("7d4a9e1a-9998-450a-8091-8329deacbc62"), "Admin Test", new DateTime(2023, 4, 27, 21, 0, 50, 575, DateTimeKind.Local).AddTicks(9445), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "B Firması", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: new Guid("0fcadb1c-cb86-4e4c-80e2-2229c5d1fa93"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6da0a5f4-fc6a-41af-840c-c17ed3f5b7e6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ea48aef8-48c3-4af1-b96d-538c890d88d6"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("cf96783a-69cb-42cb-bf08-8913c96cc609"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("e8267e9f-45a6-46fd-b7b9-438f692382d4"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("bc318ed5-f314-445a-8031-cd7525f039db"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("ccab2cab-4441-4503-b9f5-f2c9847dfff4"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "Id",
                keyValue: new Guid("1d3a40ba-001d-4051-9e37-aa844cb13f49"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("4c241bcd-061e-4899-ba83-0356e6517ecc"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("fd827fb1-40bb-4a9f-8646-ea2630374dae"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("918646c9-da37-4a8f-a5ec-b7d159bae8e7"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("9a0abf3b-6223-44d3-997d-be07e3f89a38"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("14f70762-396c-4028-998e-31ec58142502"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("7d4a9e1a-9998-450a-8091-8329deacbc62"));

            migrationBuilder.AddColumn<Guid>(
                name: "LinkId",
                table: "Abouts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Job", "LinkId", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId" },
                values: new object[] { new Guid("ce340844-a263-401e-99d1-a96ab5d32c14"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 911, DateTimeKind.Local).AddTicks(9149), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, "Web Developer", null, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4fabec1b-7e8d-45a3-a705-d2a7dcd81b1c"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(774), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("aeb44c6a-4f42-4698-bd30-db391f9d403d"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(728), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "c9a7ac14-3db2-4e90-9043-095edbc854f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "26f0b8f5-e0e2-4e77-b718-d8e05de7ec87");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "2c7b7f12-2ac7-4cba-bc1b-ae8cfdf3cf2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4cd3e05-b05e-4286-86fd-979584fb4aed", "AQAAAAEAACcQAAAAECVrB1VdohCMrhs/KA0/b+Fi0sYwuzVXFMSABcDHMpcYJGHaXat+HsoKSQPyKmMEjQ==", "17e14fea-f35f-4b8b-ba18-8ef0dfbd8d56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc28061-d36e-4e63-a4bf-c6a6c55fe6aa", "AQAAAAEAACcQAAAAEFdOqgSh+9pCeurw63mlkM2NquJ0S69lcbxnStJW2RW7lJJaVESYq070LckWTKWTaA==", "deeb99dd-1bd4-49f9-a532-eb15600f07af" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2864cc7d-73fe-47b9-a5b1-bb58f6046d5c"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53bb0f44-9f0d-447b-9a18-84722b1abde5"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.InsertData(
                table: "Histories",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SFDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("19bd7841-b26b-429b-82e6-32066c43fa5c"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6601), null, null, false, null, null, "Educatıon", "December 24", "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("6ef081e6-83c0-4383-a95f-ee82389e8448"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6588), null, null, false, null, null, "Resume", "December 24", "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("e4794cd9-d3c4-4d11-af0d-c4966c0ccdb7"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(7608), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("f6ae5dda-0ac7-4b6c-ad4a-80bf58418eb9"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 912, DateTimeKind.Local).AddTicks(7564), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[] { new Guid("5a28373e-c1b2-4541-a435-047acd3f2423"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Nulla porttitor accumsan tincidunt.", "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 913, DateTimeKind.Local).AddTicks(1718), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("59d9a438-3e21-4163-a42d-a13003d76831"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 915, DateTimeKind.Local).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 25, 22, 29, 39, 915, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Percent", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("6fb7e9fc-12ee-492f-8c52-feb0345e90d6"), new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"), "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 915, DateTimeKind.Local).AddTicks(1885), null, null, false, null, null, "90", "Designer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("80ccd016-1a46-4bec-af73-2d52134bb9b7"), new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"), "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 915, DateTimeKind.Local).AddTicks(1863), null, null, false, null, null, "90", "Coder", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Icon", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("d3ea1bbe-286f-4b10-b83c-4e0308d20a23"), "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 915, DateTimeKind.Local).AddTicks(2236), null, null, "google", false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, "Google" },
                    { new Guid("d5f87828-aa19-4d32-bba8-66a7ba4fb65d"), "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 915, DateTimeKind.Local).AddTicks(2223), null, null, "instagram", false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "Instagram" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("4316d668-9d78-4bcd-80aa-f7bcbcd1d5e1"), "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 915, DateTimeKind.Local).AddTicks(2568), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "B Firması", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("6d051a0e-e91e-4d54-91c1-dc4542419337"), "Admin Test", new DateTime(2023, 4, 25, 22, 29, 39, 915, DateTimeKind.Local).AddTicks(2546), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "A Firması", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_LinkId",
                table: "Abouts",
                column: "LinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Links_LinkId",
                table: "Abouts",
                column: "LinkId",
                principalTable: "Links",
                principalColumn: "Id");
        }
    }
}
