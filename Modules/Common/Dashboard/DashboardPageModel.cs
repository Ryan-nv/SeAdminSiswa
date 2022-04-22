using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using Serenity;

namespace SeAdminSiswa.Common
{
    public class DashboardPageModel
    {   
        //Atribut untuk menampilkan data ke card (kotak total murid, murid laki laki , murid perempuan )
        public int Murid { get; set; }
        public int MuridLk { get; set; }
        public int MuridPr { get; set; }

        //list tahun kelahiran siswa
        private int[] years;
        private int[] yearsCount;
        
        //Atribut Chart Kota
        public string KotaKota { get; set; } //nama nama kota
        public int[] KotaCount { get; set; } //jumlah siswa yang berasal dari tiap kota

        public int[] Years // properti tahun lahir siswa
        {
            get { return years; }
        }
        public int[] YearsCount // properti jumlah siswa di setiap tahun lahir 
        {
            get { return yearsCount; }
        }
        
        public DashboardPageModel() // konstruktor, dipanggil saat pertama kali class di load
        {
            FetchYearProperty();// fungsi untuk mengambil data tahun siswa dan siswa yang lahir di tahun tersebut
            FetchCityProperty();// fungsi untul mengambil data kota dan siswa yang berasal dari kota tersebut
        }

        public void FetchYearProperty()//fungsi pencari data tahun dll
        {
            years = generateYearsBetween(2010, 2000); //[2000 - 2010]

            string connectionString = "Server=localhost;Port=3306;Database=AdminSiswa;Username=root;Password=";

            string yearString = "SELECT YEAR(TanggalLahir), COUNT(*) FROM Siswa GROUP BY YEAR(TanggalLahir) ORDER BY COUNT(*) DESC;";

            //membuat dictionary tahun untuk menyimpan data lalu mengolahnya menjadi nilai integer
            var con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand request = new MySqlCommand(yearString, con);

            using MySqlDataReader rdr = request.ExecuteReader();
            List<int> yearList = new List<int>();
            List<int> yearCount = new List<int>();
            while (rdr.Read())
            {
                yearList.Add(rdr.GetInt32(0)); 
                yearCount.Add(rdr.GetInt32(1));  
            }
            years = yearList.ToArray<int>();
            yearsCount = yearCount.ToArray<int>();
            con.Close();
        }

        public void FetchCityProperty()// fungsi pencarian data kota dll
        {
            string connectionString = "Server=localhost;Port=3306;Database=AdminSiswa;Username=root;Password=";

            List<string> kotaKota = new List<string>();
            List<int> kotaCount = new List<int>();

            string yearString = "SELECT KotaId, kota.NamaKota, COUNT(*) FROM siswa INNER JOIN kota ON siswa.KotaId=kota.IdKota GROUP BY KotaId ORDER BY COUNT(*) ASC;";
            var con = new MySqlConnection(connectionString);
            con.Open();

            MySqlCommand request = new MySqlCommand(yearString, con);

            using MySqlDataReader rdr = request.ExecuteReader();
            
            while (rdr.Read())
            {
                
                kotaKota.Add(rdr.GetString(1));
                kotaCount.Add(rdr.GetInt32(2));
            }

            KotaKota = kotaKota.ToJson();
            KotaCount = kotaCount.ToArray<int>();
            foreach(int n in KotaCount) Console.WriteLine(n); 
            con.Close();
        }
        public static int[] generateYearsBetween(int endYear, int startYear = 2000)
        {

            int[] newYears = new int[endYear - startYear + 1];
            int x = 0;

            while (startYear <= endYear)
            {

                newYears[x] = startYear;

                startYear++;
                x++;
            }

            return newYears;
        }

    }

}