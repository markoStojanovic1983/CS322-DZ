using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DZ13.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Insert Students
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "FirstName", "LastName", "Email", "DateOfBirth", "Major" },
                values: new object[,]
                {
                    { "Marko", "Stojanović", "marko.stojanovic@metropolitan.ac.rs", new DateTime(1994, 2, 11), "Software Engineering" },
                    { "Ana", "Nikolić", "ana.nikolic@metropolitan.ac.rs", new DateTime(1999, 8, 22), "Information Technologies" },
                    { "Stefan", "Jovanović", "stefan.jovanovic@metropolitan.ac.rs", new DateTime(2001, 3, 10), "Software Engineering" }
                });

            // Insert Courses
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseName", "CourseCode", "Credits", "Professor", "Department" },
                values: new object[,]
                {
                    { "C# Programming", "CS323", 6, "Dr. Aleksandar Jovanović", "Computer Science" },
                    { "Algorithms and Data Structures", "CS103", 8, "Dr. Nikola Dimitrijevic", "Computer Science" },
                    { "Mathematics 2", "MA202", 8, "Dr. Rale Nikolic", "Mathematics" },
                    { "Database Systems", "CS301", 6, "Dr. Milan Jovanović", "Computer Science" },
                    { "Web Systems", "IT355", 6, "Dr. Stefan Popović", "Information Technologies" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Email",
                keyValues: new object[]
                {
                    "marko.stojanovic@metropolitan.ac.rs",
                    "ana.nikolic@metropolitan.ac.rs",
                    "stefan.jovanovic@metropolitan.ac.rs"
                });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseCode",
                keyValues: new object[]
                {
                    "CS323", "CS103", "MA202", "CS301", "IT355"
                });
        }
    }
}