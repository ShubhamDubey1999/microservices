using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Krishna.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class ProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "उपनिषद्", "ईशोपनिषद् शुक्ल यजुर्वेदीय शाखा के अन्तर्गत एक उपनिषद है। यह उपनिषद् अपने नन्हें कलेवर के कारण अन्य उपनिषदों के बीच बेहद महत्त्वपूर्ण स्थान रखता है। इसमें कोई कथा-कहानी नहीं है केवल आत्म वर्णन है। ", "https://placehold.co/603x403", "ईशोपनिषद्", 15.0 },
                    { 2, "उपनिषद्", "कठ उपनिषद् या कठोपनिषद कृष्ण यजुर्वेदीय शाखा के अन्तर्गत एक उपनिषद है। 'कठ' नाम पाणिनि के अष्टाध्यायी में प्राप्त होता है। एक मुनिविशेष का भी नाम 'कठ' था। यह वेद की कठ शाखा के प्रवर्तक थे। पतंजलि के महाभाष्य के अनुसार कठ, वैशंपायन के शिष्य थे। ", "https://placehold.co/602x402", "कठोपनिषद", 13.99 },
                    { 3, "पुराण", "दिव्य हिंदू त्रिमूर्ति के एक अंग, भगवान विष्णु अपने 10 अवतारों के माध्यम से गहरा आध्यात्मिक संदेश बताते हैं जो कई महाकाव्यों और किंवदंतियों का हिस्सा है।", "https://placehold.co/601x401", "विष्णु पुराण", 10.99 },
                    { 4, "पुराण", "शिव पुराण सभी पुराणों में सर्वाधिक महत्त्वपूर्ण व सबसे ज्यादा पढ़ी जाने वाली पुराणों में से एक है। भगवान शिव के विविध रूपों, अवतारों, ज्योतिर्लिंगों, भक्तों और भक्ति का विशद् वर्णन किया गया है। इसमें शिव के कल्याणकारी स्वरूप का तात्त्विक विवेचन, रहस्य, महिमा और उपासना का विस्तृत वर्णन है। ।", "https://placehold.co/600x400", "शिव पुराण", 15.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
