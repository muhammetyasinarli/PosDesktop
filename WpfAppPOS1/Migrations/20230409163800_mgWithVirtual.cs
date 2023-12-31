﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfAppPOS1.Migrations
{
    /// <inheritdoc />
    public partial class mgWithVirtual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 60, 32, 60, 237, 252, 57, 206, 252, 52, 166, 107, 74, 247, 61, 125, 216, 49, 219, 18, 194, 144, 62, 220, 215, 27, 37, 213, 88, 152, 49, 243, 92, 55, 238, 179, 251, 49, 115, 156, 93, 147, 146, 131, 2, 114, 113, 240, 212, 61, 229, 226, 96, 100, 86, 193, 2, 219, 233, 61, 235, 200, 143, 197, 110 }, new byte[] { 5, 48, 253, 200, 50, 177, 133, 56, 150, 20, 90, 107, 205, 254, 191, 37, 186, 40, 183, 213, 182, 157, 136, 111, 231, 118, 160, 241, 215, 138, 82, 154, 137, 42, 215, 230, 53, 221, 74, 229, 66, 224, 233, 241, 150, 20, 167, 44, 109, 253, 142, 246, 133, 127, 226, 200, 144, 135, 106, 246, 155, 29, 44, 160, 123, 169, 190, 224, 170, 64, 55, 106, 173, 29, 31, 76, 213, 122, 163, 187, 193, 164, 139, 166, 192, 241, 7, 41, 110, 213, 57, 221, 151, 6, 21, 208, 22, 179, 70, 94, 92, 184, 245, 196, 146, 78, 118, 47, 63, 230, 245, 238, 247, 233, 198, 113, 59, 59, 84, 83, 20, 137, 49, 177, 190, 237, 237, 50 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 11, 94, 97, 108, 133, 48, 129, 218, 92, 116, 223, 127, 178, 82, 181, 141, 134, 154, 0, 56, 244, 214, 117, 164, 253, 183, 226, 106, 172, 195, 123, 141, 243, 172, 218, 32, 155, 253, 127, 140, 252, 128, 44, 220, 221, 129, 88, 245, 181, 247, 219, 119, 40, 102, 226, 47, 255, 61, 133, 9, 194, 19, 117 }, new byte[] { 102, 45, 104, 6, 0, 244, 199, 195, 88, 35, 22, 222, 248, 110, 3, 138, 214, 181, 128, 86, 162, 111, 144, 146, 77, 195, 226, 220, 191, 71, 205, 248, 18, 164, 68, 45, 138, 14, 188, 76, 203, 72, 243, 33, 64, 239, 165, 85, 255, 134, 9, 106, 95, 91, 48, 232, 144, 36, 171, 22, 157, 240, 73, 150, 242, 90, 222, 142, 171, 74, 134, 89, 139, 234, 229, 170, 10, 134, 36, 157, 195, 230, 138, 194, 6, 58, 173, 211, 187, 237, 107, 195, 237, 118, 166, 177, 35, 218, 168, 54, 146, 116, 180, 81, 39, 59, 89, 16, 29, 53, 242, 165, 1, 109, 157, 61, 163, 7, 11, 154, 242, 175, 247, 29, 194, 253, 237, 151 } });
        }
    }
}
