using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Kategoride ki ürün limitini aştınız.";
        public static string ProductNameAlreadyExists = "Ürün ismi kullanılamaz.";
        public static string CheckIfCategoryLimitExceded = "Kategori limiti aşıldı.";
        public static string AuthorizationDenied = "Kayıt reddedildi.";
        public static string AccessTokenCreated ="Token oluşturuldu.";
        public static string UserAlreadyExists="Kullanıcı mevcut.";
        public static string SuccessfulLogin="Giriş başarılı.";
        public static string PasswordError ="Parola hatası.";
        public static string UserNotFound ="Kullanıcı bulunamadı.";
        public static string UserRegistered="Kayıt oldu.";
    }
}
