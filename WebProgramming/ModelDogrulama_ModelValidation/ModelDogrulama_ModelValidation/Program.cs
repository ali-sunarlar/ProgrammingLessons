using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ogrenci}/{action=Index}/{id?}");

app.Run();

//[Compare] Bu öznitelik, model sýnýfýndaki iki özelliðin birbiri ile eþleþip eþleþmediðini tanýmlar. (örneðin
//parola oluþtururken parolanýn iki kere girilmesi ve bunlarýn eþlenip eþlenmediðinin kontrolü)

//public string Sifre { get; set; }
//[Compare("Sifre", ErrorMessage = "Sifreler eslesmiyor")] 
//public string SifreDogrulama { get; set; }


//[EmailAddress] Özelliðin e-posta adresi biçimine sahip olup olmadýðýný doðrular.

//[EmailAddress (ErrorMessage ="Ge¢erli bir mail adres giriniz")]
//public string Email { get; set; } 

// [Phone]Özelliðin geçerli bir telefon numarasý biçimine sahip olup olmadýðýný doðrular. Eðer “-” vb gibi
//karakterle ayrýlmýþ olarak özelleþtirilmiþ bir þekilde gösterilmek istenirse uygun bir regular expression ifadesi
//tanýmlanmalýdýr.

//[Phone(ErrorMessage - "Lütfen Geçerli bir telefon giriniz")]
//public string Telefon { get; set; }

//[Phone(ErrorMessage - "Lütfen Geçerli bir telefon giriniz")] 
//public string Telefon { get; set; }

//[Range(min, max)] Özellik deðerinin belirtilen aralýk deðerlerinde olup olmadýðýný doðrular.

//[Range(1, 120, ErrorMessage = "Yas aralýðý 1-120 olmalidir.")]
//public int Yas { get; set; }

//[RegularExpression]Özelliðn verilen Regular Expression ifadesine uyup uymadýðýný doðrular.

//[RegularExpression("~(2!0+$) (\\+\\d{1,3}[- 1?)?(?!0+$)\\d{10,15}%",
//ErrorMessage = "Telefon numarasini uygun formatta giriniz.")] 
//public string Telefon { get; set; }

//[Required] Özelliðin boþ veya NULL hariç bir deðere sahip olup olmadýðýný doðrular.

//[Required(ErrorMessage = "Kullanýcý Adi Alani Zorunludur™)]
//public string KullaniciAdi { get; set; } 

//[MinLength] Özellik deðeri uzunluðunun belirtilen uzunluk deðerinden daha küçük olmamasý gerektiðini denetler.

//[MinLength(10)]
//public string KullanciAdi { get; set; } 

//[MaxLength] Özellik deðeri uzunluðunun belirtilen uzunluðu aþmamasý gerektiðini denetler. Enitity
//Framework’te de kullanýlýr. Veritabanýndaki sütunun maksimum uzunluðunun ne olacaðýný da belirler.

//[MaxLength(50)]
//public string KullanciAdi { get; set; } 

// [StringLength] Özellik deðeri uzunluðunun belirtilen uzunluðu aþmamasý gerektiðini denetler.

//[StringLength(10)]
//public string KullanciAdi { get; set; } 

//[CreditCard] Özellik deðerinin kredi kartý numarasýna uygunluðunu denetler.

//[CreditCard]
//public string CreditCardNumber { get; set; } 




//ASP.NET Core MVC framework’ü kullanýcýlara ihtiyaçlarý çerçevesinde kendi doðrulama özniteliklerini oluþturmaya da imkan verir.

//public class Kullanici

//{

//    [Required(ErrorMessage = "Kullanici Adi Alani Zorunludur")][StringlLength(50)]

//    public string KullaniciAdi { get; set; }

//    [Required]

//    [EmailAddress(ErrorMessage = "Gecerli bir mail adres giriniz")] 

//    public string Email { get; set; }

//}








