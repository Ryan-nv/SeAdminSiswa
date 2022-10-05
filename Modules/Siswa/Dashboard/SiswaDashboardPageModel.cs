using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using Serenity;

namespace SeAdminSiswa.Siswa
{
    public class SiswaDashboardPageModel
    {   
        //Atribut untuk menampilkan data ke card (kotak total murid, murid laki laki , murid perempuan )
        public int Murid { get; set; }
        public int MuridLk { get; set; }
        public int MuridPr { get; set; }
        string connectionString = "Server=localhost;Port=3306;Database=AdminSiswa;Username=root;Password=";
        //list tahun kelahiran siswa
        public int[] Years { get; set; }
        public int[] YearsCount { get; set; }
        
        //Atribut Chart Kota
        public string KotaKota { get; set; } //nama nama kota
        public int[] KotaCount { get; set; } //jumlah siswa yang berasal dari tiap kota

        public SiswaDashboardPageModel() // konstruktor, dipanggil saat pertama kali class di load
        {
            FetchYearProperty();// fungsi untuk mengambil data tahun siswa dan siswa yang lahir di tahun tersebut
            FetchCityProperty();// fungsi untul mengambil data kota dan siswa yang berasal dari kota tersebut
        }

        public void FetchYearProperty()//fungsi pencari data tahun dll
        {
            string query = "SELECT YEAR(TanggalLahir), COUNT(*) FROM Siswa GROUP BY YEAR(TanggalLahir) ORDER BY COUNT(*) DESC LIMIT 6;";

            //membuat dictionary tahun untuk menyimpan data lalu mengolahnya menjadi nilai integer
            var con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand request = new MySqlCommand(query, con);

            using MySqlDataReader rdr = request.ExecuteReader();
            List<int> yearList = new List<int>();
            List<int> yearCount = new List<int>();
            while (rdr.Read())
            {
                yearList.Add(rdr.GetInt32(0)); 
                yearCount.Add(rdr.GetInt32(1));  
            }
            Years = yearList.ToArray<int>();
            YearsCount = yearCount.ToArray<int>();
            con.Close();
        }

        public void FetchCityProperty()// fungsi pencarian data kota dll
        {
            List<string> kotaKota = new List<string>();
            List<int> kotaCount = new List<int>();

            string query = "SELECT kota.NamaKota, COUNT(*) FROM siswa INNER JOIN kota ON siswa.KotaId=kota.IdKota GROUP BY KotaId ORDER BY COUNT(*) DESC LIMIT 6;";
            var con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand request = new MySqlCommand(query, con);

            using MySqlDataReader rdr = request.ExecuteReader();
            
            while (rdr.Read())
            {   
                kotaKota.Add(rdr.GetString(0));
                kotaCount.Add(rdr.GetInt32(1));
            }

            KotaKota = kotaKota.ToJson();
            KotaCount = kotaCount.ToArray<int>();
            con.Close();
        }
    }
}