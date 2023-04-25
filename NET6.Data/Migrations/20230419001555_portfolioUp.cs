using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NET6.Data.Migrations
{
    public partial class portfolioUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: new Guid("105d7d77-6656-4e4f-80e9-d22ac3062884"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6d66f6b8-d88e-4aae-99ee-31fa139a50cd"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e5673b2e-3c28-4d60-a222-86b6a0692f2f"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("8014481a-87d3-4c76-a5d0-415a82b0aae1"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("fac9b7f9-0d7a-4dc7-b82c-cb2571e28d83"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("2e762510-0d0b-4c9e-89ac-01132090442a"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("a2f4ed81-0b96-4029-8de4-146f9dd3e3de"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "Id",
                keyValue: new Guid("5429c4fb-afa6-4532-b3d3-30b38d87f876"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("962b35a1-1050-4369-b6c0-f9e92daf3853"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("c50cc9c1-17af-4a69-af56-6926627cb3c0"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("7c2908ce-88a4-41c6-ad9d-6b98a3f49ee2"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("f774d480-cf57-4edc-a5cc-05cee3b0bc3b"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("3c29a7d2-5505-4990-a948-3385cd03c5e8"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("cace728e-a115-49b1-b67b-b90a9f9d4823"));

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Job", "LinkId", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId" },
                values: new object[] { new Guid("1aabbb2b-36e3-4ef3-b49c-8ab837a2eb66"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(3890), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, "Web Developer", null, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4bc26aac-ec76-48e1-89d2-4fb03cf52523"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(4571), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("c158e20a-ba4e-4a7d-9154-bfdda75d8249"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(4612), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "8eeb840f-1108-4fe7-909e-d185d51ae8c6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "54f2b524-161d-4c6c-a182-919ef8c9080d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "e4496645-abb6-44b4-8f53-e2ec1baeafa6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9316e0d7-8c6b-4ea6-818e-8c915d86a77e", "AQAAAAEAACcQAAAAEFvzIdEZObHgdyKzgjd6DAiHH/E3z7d/iTzXGXWsWZLxeH8edWLjQdv1oNapXOXLvg==", "9fa06ff1-9d0e-4adf-a05c-dfba06b9ef2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d6926f2-efdd-422a-a609-28dde2da8394", "AQAAAAEAACcQAAAAEMbxX2m90CnPsyJRS/D1Obcjb6o/ZuBu02C27OkxLJhEkqiIyrghpBpNOdHvdL/eWw==", "53c63811-5a78-45f4-a4b1-96ea6ad4dc70" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2864cc7d-73fe-47b9-a5b1-bb58f6046d5c"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53bb0f44-9f0d-447b-9a18-84722b1abde5"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.InsertData(
                table: "Histories",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SFDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("252db136-f1cd-468e-8dd1-8415cf68f47e"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(9328), null, null, false, null, null, "Resume", "December 24", "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("cc9c27e8-1f5a-4359-9215-42cb79c34526"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(9340), null, null, false, null, null, "Educatıon", "December 24", "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 748, DateTimeKind.Local).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 749, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 749, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("95d8c43d-d9db-4e4d-a091-0153caeead76"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 749, DateTimeKind.Local).AddTicks(3098), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("ffd09bae-6ea2-43ef-a482-14ad5dc4a4bd"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 749, DateTimeKind.Local).AddTicks(3040), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[] { new Guid("86509d6f-6dc4-4fb4-a2b3-3f49db7e2c04"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Nulla porttitor accumsan tincidunt.", "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 749, DateTimeKind.Local).AddTicks(8412), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("59d9a438-3e21-4163-a42d-a13003d76831"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 751, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 19, 3, 15, 52, 751, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Percent", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("57788611-154f-4881-9641-610501ee953f"), new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"), "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 751, DateTimeKind.Local).AddTicks(2905), null, null, false, null, null, "90", "Designer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("9eae1fdf-860d-4627-8952-174c6ce343d8"), new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"), "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 751, DateTimeKind.Local).AddTicks(2896), null, null, false, null, null, "90", "Coder", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Icon", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("8b5dbf9a-6330-4b26-b61d-ebb0094d031e"), "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 751, DateTimeKind.Local).AddTicks(3278), null, null, "google", false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, "Google" },
                    { new Guid("e79a3dae-33a9-492c-aa54-0a5395b040a5"), "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 751, DateTimeKind.Local).AddTicks(3266), null, null, "instagram", false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "Instagram" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("87d4d71b-b449-4135-aa34-6c70828d2171"), "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 751, DateTimeKind.Local).AddTicks(3542), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "A Firması", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("c13e5203-efc9-4e5e-a1d0-3c7feb856be2"), "Admin Test", new DateTime(2023, 4, 19, 3, 15, 52, 751, DateTimeKind.Local).AddTicks(3559), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "B Firması", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: new Guid("1aabbb2b-36e3-4ef3-b49c-8ab837a2eb66"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4bc26aac-ec76-48e1-89d2-4fb03cf52523"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c158e20a-ba4e-4a7d-9154-bfdda75d8249"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("252db136-f1cd-468e-8dd1-8415cf68f47e"));

            migrationBuilder.DeleteData(
                table: "Histories",
                keyColumn: "Id",
                keyValue: new Guid("cc9c27e8-1f5a-4359-9215-42cb79c34526"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("95d8c43d-d9db-4e4d-a091-0153caeead76"));

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: new Guid("ffd09bae-6ea2-43ef-a482-14ad5dc4a4bd"));

            migrationBuilder.DeleteData(
                table: "Processes",
                keyColumn: "Id",
                keyValue: new Guid("86509d6f-6dc4-4fb4-a2b3-3f49db7e2c04"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("57788611-154f-4881-9641-610501ee953f"));

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: new Guid("9eae1fdf-860d-4627-8952-174c6ce343d8"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("8b5dbf9a-6330-4b26-b61d-ebb0094d031e"));

            migrationBuilder.DeleteData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: new Guid("e79a3dae-33a9-492c-aa54-0a5395b040a5"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("87d4d71b-b449-4135-aa34-6c70828d2171"));

            migrationBuilder.DeleteData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: new Guid("c13e5203-efc9-4e5e-a1d0-3c7feb856be2"));

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "Job", "LinkId", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId" },
                values: new object[] { new Guid("105d7d77-6656-4e4f-80e9-d22ac3062884"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 759, DateTimeKind.Local).AddTicks(3459), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, "Web Developer", null, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("6d66f6b8-d88e-4aae-99ee-31fa139a50cd"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 759, DateTimeKind.Local).AddTicks(4334), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("e5673b2e-3c28-4d60-a222-86b6a0692f2f"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 759, DateTimeKind.Local).AddTicks(4316), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "734b22aa-7523-4ed9-a83e-d1bfb109bcb2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "4e28bd29-7954-423c-a0d8-83bbd411f114");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "c0bcffe9-b12c-402c-b84c-05c4f53576a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37fe698c-b4a7-4450-a278-830f0807e75a", "AQAAAAEAACcQAAAAEJwE5+cLncptzHW9xr11zEfcpDh7Evh15m4KAlD0CDEv2q4OyHLZBG3PLnM6r/JVqw==", "a65dd848-81a8-4f60-ab94-9f835fd55c50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "233a29cb-cbda-4254-b9a2-89dd2807b4b2", "AQAAAAEAACcQAAAAEL+ybgwgw4BvhIiupnogRpwJsK5JI7R5RxfxtC+JRdLV3nikOEbhkrMQfyCvCYd0Kw==", "55ef8db3-9b10-4f49-8306-069df76438c2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2864cc7d-73fe-47b9-a5b1-bb58f6046d5c"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 759, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("53bb0f44-9f0d-447b-9a18-84722b1abde5"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Histories",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name", "SFDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("8014481a-87d3-4c76-a5d0-415a82b0aae1"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(672), null, null, false, null, null, "Educatıon", "December 24", "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("fac9b7f9-0d7a-4dc7-b82c-cb2571e28d83"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(654), null, null, false, null, null, "Resume", "December 24", "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "SeoId", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2e762510-0d0b-4c9e-89ac-01132090442a"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(2223), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, null, new Guid("59d9a438-3e21-4163-a42d-a13003d76831"), "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("a2f4ed81-0b96-4029-8de4-146f9dd3e3de"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(2239), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, null, new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"), "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.InsertData(
                table: "Processes",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[] { new Guid("5429c4fb-afa6-4532-b3d3-30b38d87f876"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 760, DateTimeKind.Local).AddTicks(7670), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Batuhan Ulukan", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") });

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("59d9a438-3e21-4163-a42d-a13003d76831"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 762, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Seos",
                keyColumn: "Id",
                keyValue: new Guid("a7f5670d-31eb-4eea-ba51-a5e924135542"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 17, 18, 41, 45, 762, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Percent", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("962b35a1-1050-4369-b6c0-f9e92daf3853"), new Guid("1bd1d873-a5ff-43e1-aa04-f86dd78495ee"), "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 762, DateTimeKind.Local).AddTicks(5546), null, null, false, null, null, "90", "Coder", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("c50cc9c1-17af-4a69-af56-6926627cb3c0"), new Guid("1266ee22-b956-4fd2-bcd1-fa55d33a77da"), "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 762, DateTimeKind.Local).AddTicks(5559), null, null, false, null, null, "90", "Designer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Icon", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("7c2908ce-88a4-41c6-ad9d-6b98a3f49ee2"), "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 762, DateTimeKind.Local).AddTicks(6139), null, null, "instagram", false, new Guid("8c68d329-a387-4e55-b04e-17fcad8cab47"), null, null, "Instagram" },
                    { new Guid("f774d480-cf57-4edc-a5cc-05cee3b0bc3b"), "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 762, DateTimeKind.Local).AddTicks(6163), null, null, "google", false, new Guid("49f708bf-48b1-4513-b8b0-0c087f6252af"), null, null, "Google" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "LinkId", "ModifiedBy", "ModifiedDate", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("3c29a7d2-5505-4990-a948-3385cd03c5e8"), "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 762, DateTimeKind.Local).AddTicks(7078), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, null, "A Firması", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("cace728e-a115-49b1-b67b-b90a9f9d4823"), "Admin Test", new DateTime(2023, 4, 17, 18, 41, 45, 762, DateTimeKind.Local).AddTicks(7094), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, null, "B Firması", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }
    }
}
