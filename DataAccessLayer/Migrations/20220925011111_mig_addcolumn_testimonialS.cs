using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_addcolumn_testimonialS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TestimonialS",
                table: "TestimonialS");

            migrationBuilder.RenameTable(
                name: "TestimonialS",
                newName: "Testimonials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "TestimonialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.RenameTable(
                name: "Testimonials",
                newName: "TestimonialS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestimonialS",
                table: "TestimonialS",
                column: "TestimonialID");
        }
    }
}
