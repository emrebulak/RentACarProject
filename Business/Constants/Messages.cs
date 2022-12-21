using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarInvalidName = "Araba ismi minimum 2 karakterden oluşmalıdır ve günlük fiyatı 0'dan büyük olmalıdır";
        public static string CarListed = "Araba listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string ColorAdded = "Renk eklendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string RentalAdded = "Araba kiralama eklendi";
        public static string RentalDeleted = "Araba kiralama silindi";
        public static string RentalUpdated = "Araba kiralama güncellendi";
        public static string RentalInvalidRequest = "Araba teslim edilmeden kiralanamaz";
    }
}
