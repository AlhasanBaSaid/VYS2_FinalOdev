using BaSaidEDU.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaSaidEDU.BL
{
    public static class BLogic
    {


        public static bool EgitmenEkle(Egitmenler e)
        {
            try
            {
                int res = DataLayer.EgitmenEkle(e);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet EgitmenGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.EgitmenGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool EgitmenGuncelle(Egitmenler e)
        {
            try
            {
                int res = DataLayer.EgitmenGuncelle(e);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool EgitmenSil(string kimlik)
        {
            try
            {
                int res = DataLayer.EgitmenSil(kimlik);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }



        internal static bool OgrenciEkle(Ogrenciler o)
        {
            try
            {
                int res = DataLayer.OgrenciEkle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }

        }

        internal static DataSet OgrenciGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.OgrenciGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool OgrenciGuncelle(Ogrenciler o)
        {
            try
            {
                int res = DataLayer.OgrenciGuncelle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool OgrenciSil(string kimlik)
        {
            try
            {
                int res = DataLayer.OgrenciSil(kimlik);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }



        internal static bool KursEkle(Kurslar k)
        {
            try
            {
                int res = DataLayer.KursEkle(k);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet KursGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.KursGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool KursGuncelle(Kurslar k)
        {
            try
            {
                int res = DataLayer.KursGuncelle(k);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool KursSil(string kimlik)
        {
            try
            {
                int res = DataLayer.KursSil(kimlik);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }



        internal static bool IlerlemeEkle(IlerlemeTakipcisi i)
        {
            try
            {
                int res = DataLayer.IlerlemeEkle(i);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet IlerlemeGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.IlerlemeGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool IlerlemeGuncelle(IlerlemeTakipcisi i)
        {
            try
            {
                int res = DataLayer.IlerlemeGuncelle(i);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool IlerlemeSil(string kimlik)
        {
            try
            {
                int res = DataLayer.IlerlemeSil(kimlik);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }



        internal static bool KayitEkle(Kayitlar kay)
        {
            try
            {
                int res = DataLayer.KayitEkle(kay);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet KayitGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.KayitGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool KayitGuncelle(Kayitlar kay)
        {
            try
            {
                int res = DataLayer.KayitGuncelle(kay);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool KayitSil(string kimlik)
        {
            try
            {
                int res = DataLayer.KayitSil(kimlik);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }
        
        internal static DataSet KayitDetay()
        {
            try
            {
                DataSet ds = DataLayer.KayitDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }



        internal static bool OdemeEkle(Odemeler od)
        {
            try
            {
                int res = DataLayer.OdemeEkle(od);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet OdemeGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.OdemeGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }

        internal static bool OdemeGuncelle(Odemeler od)
        {
            try
            {
                int res = DataLayer.OdemeGuncelle(od);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool OdemeSil(string kimlik)
        {
            try
            {
                int res = DataLayer.OdemeSil(kimlik);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                DataSet ds = DataLayer.OdemeDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return null;
            }
        }
    }
}
