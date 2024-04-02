﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Subscribers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DailyNewsletter = table.Column<bool>(type: "INTEGER", nullable: false),
                    AdvertisingUpdates = table.Column<bool>(type: "INTEGER", nullable: false),
                    WeekinReview = table.Column<bool>(type: "INTEGER", nullable: false),
                    EventUpdates = table.Column<bool>(type: "INTEGER", nullable: false),
                    StartupsWeekly = table.Column<bool>(type: "INTEGER", nullable: false),
                    Podcasts = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribers");
        }
    }
}
