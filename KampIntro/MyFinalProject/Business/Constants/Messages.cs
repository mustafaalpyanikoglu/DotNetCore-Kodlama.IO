using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir!";
        public static string ProductNameAlreadyExists = "Bu isimde bir ürün zaten var!";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor!";
        public static string AuthorizationDenied = "Yetkiniz yok!";

        public static string UserRegistered = "Kayıt oldu!";
        public static string UserNotFound = "Kullanıcı bulunamadı!";
        public static string PasswordError = "Parola hatas!";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut!";
        public static string AccessTokenCreated = "Tokun oluşturuldu";
    }
}
