using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaSaidEDU
{
    public class Ogrenciler
    {
        public Guid Kimlik{ get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Eposta { get; set; }
    }

    public class Egitmenler
    {
        public Guid Kimlik { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Eposta { get; set; }

        public string Uzmanlik { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }

    public class Kurslar
    {
        public Guid Kimlik { get; set; }

        public Guid EgitmenKimlik { get; set ; }

        public string Ad { get; set; }

        public string Aciklama { get; set; }

        public double Fiyat { get; set; }

        public override string ToString()
        {
            return $"{Ad}";
        }
    }

    public class Kayitlar
    {
        public Guid Kimlik { get; set; }

        public Guid OgrenciKimlik { get; set; }

        public Guid KursKimlik { get; set; }

        public DateTime Tarih { get; set; }
    }

    public class IlerlemeTakipcisi
    {
        public Guid Kimlik { get; set; }

        public Guid OgrenciKimlik { get; set; }

        public Guid KursKimlik { get; set; }

        public float TamamlanmaYuzdesi { get; set; }

        public string Gecis_Durumu { get; set; }
    }

    public class Odemeler
    {
        public Guid Kimlik { get; set; }

        public Guid OgrenciKimlik { get; set; }

        public Guid KursKimlik { get; set; }

        public double Tutar {  get; set; }

        public DateTime Tarih { get; set; }
    }
}
