
using System.ComponentModel.DataAnnotations;

namespace CombiSystems.Web.ViewModels;

public class RegisterViewModel
{

    [Display(Name = "Ad")]
    [Required(ErrorMessage = "Ad alanı gereklidir.")]
    [StringLength(50)]
    public string Name { get; set; }

    [Display(Name = "Soyad")]
    [Required(ErrorMessage = "Soyad alanı gereklidir.")]
    [StringLength(50)]
    public string Surname { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "E-Posta alanı gereklidir.")]
    public string Email { get; set; }

    [Display(Name = "Şifre")]
    [Required(ErrorMessage = "Şifre alanı gereklidir.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifreniz minimum 6 karakterli olmalıdır!")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Şifre Tekrar")]
    [Required(ErrorMessage = "Şifre tekrar alanı gereklidir.")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
    public string ConfirmPassword { get; set; }


    [Display(Name = "Telefon Numarası")]
    [Required(ErrorMessage = "Telefon numarası alanı gereklidir.")]
    [StringLength(10, MinimumLength = 10, ErrorMessage = "Başında 0 olmadan giriniz.")]
    [DataType(DataType.EmailAddress)]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Adress alanı gereklidir")]
    [Display(Name = "Adress")]
    public string Adress { get; set; }
}