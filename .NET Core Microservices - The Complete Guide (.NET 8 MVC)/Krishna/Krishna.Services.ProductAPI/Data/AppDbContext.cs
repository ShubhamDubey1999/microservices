using Krishna.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Krishna.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "ईशोपनिषद्",
                Price = 15,
                Description = "ईशोपनिषद् शुक्ल यजुर्वेदीय शाखा के अन्तर्गत एक उपनिषद है। यह उपनिषद् अपने नन्हें कलेवर के कारण अन्य उपनिषदों के बीच बेहद महत्त्वपूर्ण स्थान रखता है। इसमें कोई कथा-कहानी नहीं है केवल आत्म वर्णन है। ",
                ImageUrl = "https://placehold.co/603x403",
                CategoryName = "उपनिषद्"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "कठोपनिषद",
                Price = 13.99,
                Description = "कठ उपनिषद् या कठोपनिषद कृष्ण यजुर्वेदीय शाखा के अन्तर्गत एक उपनिषद है। 'कठ' नाम पाणिनि के अष्टाध्यायी में प्राप्त होता है। एक मुनिविशेष का भी नाम 'कठ' था। यह वेद की कठ शाखा के प्रवर्तक थे। पतंजलि के महाभाष्य के अनुसार कठ, वैशंपायन के शिष्य थे। ",
                ImageUrl = "https://placehold.co/602x402",
                CategoryName = "उपनिषद्"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "विष्णु पुराण",
                Price = 10.99,
                Description = "दिव्य हिंदू त्रिमूर्ति के एक अंग, भगवान विष्णु अपने 10 अवतारों के माध्यम से गहरा आध्यात्मिक संदेश बताते हैं जो कई महाकाव्यों और किंवदंतियों का हिस्सा है।",
                ImageUrl = "https://placehold.co/601x401",
                CategoryName = "पुराण"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "शिव पुराण",
                Price = 15,
                Description = "शिव पुराण सभी पुराणों में सर्वाधिक महत्त्वपूर्ण व सबसे ज्यादा पढ़ी जाने वाली पुराणों में से एक है। भगवान शिव के विविध रूपों, अवतारों, ज्योतिर्लिंगों, भक्तों और भक्ति का विशद् वर्णन किया गया है। इसमें शिव के कल्याणकारी स्वरूप का तात्त्विक विवेचन, रहस्य, महिमा और उपासना का विस्तृत वर्णन है। ।",
                ImageUrl = "https://placehold.co/600x400",
                CategoryName = "पुराण"
            });
        }

        //public DbSet<Coupon> Coupons => Set<Coupon>();
        public DbSet<Product> Products { get; set; }
    }
}
