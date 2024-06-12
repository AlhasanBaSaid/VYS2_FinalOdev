using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace BaSaidEDU.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server   = "127.0.0.1",
                Database = "basaidedu",
                UserID   = "root",
                Password = "@lH@$@N1530*",
            }.ConnectionString
        );

        

        public static int EgitmenEkle(Egitmenler e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_EgitmenlerEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", e.Kimlik);
                komut.Parameters.AddWithValue("@Ad", e.Ad);
                komut.Parameters.AddWithValue("@Soyad", e.Soyad);
                komut.Parameters.AddWithValue("@Eposta", e.Eposta);
                komut.Parameters.AddWithValue("@Uzmanlik", e.Uzmanlik);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet EgitmenGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("BaSaidEDU_EgitmenlerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("BaSaidEDU_EgitmenlerBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int EgitmenGuncelle(Egitmenler e)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_EgitmenlerGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", e.Kimlik);
                komut.Parameters.AddWithValue("@Ad", e.Ad);
                komut.Parameters.AddWithValue("@Soyad", e.Soyad);
                komut.Parameters.AddWithValue("@Eposta", e.Eposta);
                komut.Parameters.AddWithValue("@Uzmanlik", e.Uzmanlik);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int EgitmenSil(string kimlik)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_EgitmenlerSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", kimlik);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }



        internal static int OgrenciEkle(Ogrenciler o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_OgrencilerEkle", conn);
                komut.CommandType  = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", o.Kimlik);
                komut.Parameters.AddWithValue("@Ad", o.Ad);
                komut.Parameters.AddWithValue("@Soyad", o.Soyad);
                komut.Parameters.AddWithValue("@Eposta", o.Eposta);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
        
        internal static DataSet OgrenciGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut             = new MySqlCommand("BaSaidEDU_OgrencilerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut             = new MySqlCommand("BaSaidEDU_OgrencilerBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                
                DataSet dataSet      = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
            }
        }

        internal static int OgrenciGuncelle(Ogrenciler o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_OgrencilerGuncelle", conn);
                komut.CommandType  = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", o.Kimlik);
                komut.Parameters.AddWithValue("@Ad", o.Ad);
                komut.Parameters.AddWithValue("@Soyad", o.Soyad);
                komut.Parameters.AddWithValue("@Eposta", o.Eposta);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                conn.Close();
            }
        }

        internal static int OgrenciSil(string kimlik)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_OgrencilerSil", conn);
                komut.CommandType  = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", kimlik);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }



        internal static int KursEkle(Kurslar k)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_KurslarEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", k.Kimlik);
                komut.Parameters.AddWithValue("@EgitmenKimlik", k.EgitmenKimlik);
                komut.Parameters.AddWithValue("@Ad", k.Ad);
                komut.Parameters.AddWithValue("@Aciklama", k.Aciklama);
                komut.Parameters.AddWithValue("@Fiyat", k.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet KursGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("BaSaidEDU_KurslarHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("BaSaidEDU_KursLarBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
        
        internal static int KursGuncelle(Kurslar k)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_KurslarGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", k.Kimlik);
                komut.Parameters.AddWithValue("@EgitmenKimlik", k.EgitmenKimlik);
                komut.Parameters.AddWithValue("@Ad", k.Ad);
                komut.Parameters.AddWithValue("@Aciklama", k.Aciklama);
                komut.Parameters.AddWithValue("@Fiyat", k.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int KursSil(string kimlik)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_KurslarSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", kimlik);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }



        internal static int IlerlemeEkle(IlerlemeTakipcisi i)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_Ilerleme_TakipcisiEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", i.Kimlik);
                komut.Parameters.AddWithValue("@OgrenciKimlik", i.OgrenciKimlik);
                komut.Parameters.AddWithValue("@KursKimlik", i.KursKimlik);
                komut.Parameters.AddWithValue("@TamamlanmaYuzdesi", i.TamamlanmaYuzdesi);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet IlerlemeGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("BaSaidEDU_Ilerleme_TakipcisiHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("BaSaidEDU_Ilerleme_TakipcisiBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int IlerlemeGuncelle(IlerlemeTakipcisi i)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_Ilerleme_TakipcisiGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", i.Kimlik);
                komut.Parameters.AddWithValue("@OgrenciKimlik", i.OgrenciKimlik);
                komut.Parameters.AddWithValue("@KursKimlik", i.KursKimlik);
                komut.Parameters.AddWithValue("@TamamlanmaYuzdesi", i.TamamlanmaYuzdesi);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int IlerlemeSil(string kimlik)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_Ilerleme_TakipcisiSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", kimlik);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }



        internal static int KayitEkle(Kayitlar kay)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_KayitlarEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", kay.Kimlik);
                komut.Parameters.AddWithValue("@OgrenciKimlik", kay.OgrenciKimlik);
                komut.Parameters.AddWithValue("@KursKimlik", kay.KursKimlik);
                komut.Parameters.AddWithValue("@Tarih", kay.Tarih);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet KayitGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("BaSaidEDU_KayitlarHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("BaSaidEDU_KayitlarBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int KayitGuncelle(Kayitlar kay)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_KayitlarGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", kay.Kimlik);
                komut.Parameters.AddWithValue("@OgrenciKimlik", kay.OgrenciKimlik);
                komut.Parameters.AddWithValue("@KursKimlik", kay.KursKimlik);
                komut.Parameters.AddWithValue("@Tarih", kay.Tarih);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int KayitSil(string kimlik)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_KayitlarSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", kimlik);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
        
        internal static DataSet KayitDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_KayitlarDetay", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }



        internal static int OdemeEkle(Odemeler od)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_OdemelerEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", od.Kimlik);
                komut.Parameters.AddWithValue("@OgrenciKimlik", od.OgrenciKimlik);
                komut.Parameters.AddWithValue("@KursKimlik", od.KursKimlik);
                komut.Parameters.AddWithValue("@Tutar", od.Tutar);
                komut.Parameters.AddWithValue("@Tarih", od.Tarih);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet OdemeGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("BaSaidEDU_OdemelerHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    komut = new MySqlCommand("BaSaidEDU_OdemelerBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeGuncelle(Odemeler od)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_OdemelerGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", od.Kimlik);
                komut.Parameters.AddWithValue("@OgrenciKimlik", od.OgrenciKimlik);
                komut.Parameters.AddWithValue("@KursKimlik", od.KursKimlik);
                komut.Parameters.AddWithValue("@Tutar", od.Tutar);
                komut.Parameters.AddWithValue("@Tarih", od.Tarih);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeSil(string kimlik)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_OdemelerSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Kimlik", kimlik);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("BaSaidEDU_OdemelerDetay", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
}
