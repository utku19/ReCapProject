using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Businesss.Constants
{
    public static class Messages
    {
        public static string BrandAdded = "Araba markası eklendi.";
        public static string BrandDeleted = "Araba markası silindi.";
        public static string BrandUpdated = "Araba markası güncellendi.";
        public static string BrandInvalid = "Marka ismi geçersiz. En az iki karakter olmalı.";
        public static string BrandsListed = "Araba markaları listelendi.";

        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarsListed = "Arabalar Listelendi.";
        public static string CarNameInvalid = "Araba ismi geçersiz. En az iki karakter olmalı.";
        public static string CarPriceInvalid = "Araba fiyatı geçersiz. Sıfırdan büyük olmalı.";
        public static string MaintenanceTime = "Sistem bakımda.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorsListed = "Araba Renkleri listelendi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";

        public static string RentalAdded = "Araba kiralama işlemi gerçekleşti.";
        public static string RentalDeleted = "Araba kiralama işlemi iptal edildi.";
        public static string RentalUpdated = "Araba kiralama işlemi güncellendi.";
        public static string FailedRentalAdd = "Bu araba henüz teslim edilmediği için kiralayamazsınız!";
        public static string ReturnedRental = "Kiraladığınız araç teslim edildi.";
        public static string RentalsListed = "Kiralanan Araçlar istelendi.";

        public static string AddedCarImage = "Araba resmi başarıyla eklendi.";
        public static string DeletedCarImage = "Arabanın resmi başarıyla silindi.";
        public static string UpdatedCarImage = "Araba resmi başarıyla güncellendi.";
        public static string FailedCarImageAdd = "Bir araba 5'ten fazla resme sahip olamaz.";

        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi.";
        public static string CarImageUpdated = "Araba resmi güncellendi.";
        public static string CarImageCountOfCarError = "Araba resmi maksimum sayıda.";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
