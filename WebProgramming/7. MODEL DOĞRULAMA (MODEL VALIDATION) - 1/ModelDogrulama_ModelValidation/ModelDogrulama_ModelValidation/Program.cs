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

//[Compare] Bu �znitelik, model s�n�f�ndaki iki �zelli�in birbiri ile e�le�ip e�le�medi�ini tan�mlar. (�rne�in
//parola olu�tururken parolan�n iki kere girilmesi ve bunlar�n e�lenip e�lenmedi�inin kontrol�)

//public string Sifre { get; set; }
//[Compare("Sifre", ErrorMessage = "Sifreler eslesmiyor")] 
//public string SifreDogrulama { get; set; }


//[EmailAddress] �zelli�in e-posta adresi bi�imine sahip olup olmad���n� do�rular.

//[EmailAddress (ErrorMessage ="Ge�erli bir mail adres giriniz")]
//public string Email { get; set; } 

// [Phone]�zelli�in ge�erli bir telefon numaras� bi�imine sahip olup olmad���n� do�rular. E�er �-� vb gibi
//karakterle ayr�lm�� olarak �zelle�tirilmi� bir �ekilde g�sterilmek istenirse uygun bir regular expression ifadesi
//tan�mlanmal�d�r.

//[Phone(ErrorMessage - "L�tfen Ge�erli bir telefon giriniz")]
//public string Telefon { get; set; }

//[Phone(ErrorMessage - "L�tfen Ge�erli bir telefon giriniz")] 
//public string Telefon { get; set; }

//[Range(min, max)] �zellik de�erinin belirtilen aral�k de�erlerinde olup olmad���n� do�rular.

//[Range(1, 120, ErrorMessage = "Yas aral��� 1-120 olmalidir.")]
//public int Yas { get; set; }

//[RegularExpression]�zelli�n verilen Regular Expression ifadesine uyup uymad���n� do�rular.

//[RegularExpression("~(2!0+$) (\\+\\d{1,3}[- 1?)?(?!0+$)\\d{10,15}%",
//ErrorMessage = "Telefon numarasini uygun formatta giriniz.")] 
//public string Telefon { get; set; }

//[Required] �zelli�in bo� veya NULL hari� bir de�ere sahip olup olmad���n� do�rular.

//[Required(ErrorMessage = "Kullan�c� Adi Alani Zorunludur�)]
//public string KullaniciAdi { get; set; } 

//[MinLength] �zellik de�eri uzunlu�unun belirtilen uzunluk de�erinden daha k���k olmamas� gerekti�ini denetler.

//[MinLength(10)]
//public string KullanciAdi { get; set; } 

//[MaxLength] �zellik de�eri uzunlu�unun belirtilen uzunlu�u a�mamas� gerekti�ini denetler. Enitity
//Framework�te de kullan�l�r. Veritaban�ndaki s�tunun maksimum uzunlu�unun ne olaca��n� da belirler.

//[MaxLength(50)]
//public string KullanciAdi { get; set; } 

// [StringLength] �zellik de�eri uzunlu�unun belirtilen uzunlu�u a�mamas� gerekti�ini denetler.

//[StringLength(10)]
//public string KullanciAdi { get; set; } 

//[CreditCard] �zellik de�erinin kredi kart� numaras�na uygunlu�unu denetler.

//[CreditCard]
//public string CreditCardNumber { get; set; } 




//ASP.NET Core MVC framework�� kullan�c�lara ihtiya�lar� �er�evesinde kendi do�rulama �zniteliklerini olu�turmaya da imkan verir.

//public class Kullanici

//{

//    [Required(ErrorMessage = "Kullanici Adi Alani Zorunludur")][StringlLength(50)]

//    public string KullaniciAdi { get; set; }

//    [Required]

//    [EmailAddress(ErrorMessage = "Gecerli bir mail adres giriniz")] 

//    public string Email { get; set; }

//}








