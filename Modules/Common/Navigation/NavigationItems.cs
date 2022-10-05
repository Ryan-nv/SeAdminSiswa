using Serenity.Navigation;
using MyPages = SeAdminSiswa.Siswa.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-pie-chart")]

[assembly: NavigationMenu(1000, "Data Siswa", icon: "fa-th-list")]
[assembly: NavigationLink(int.MaxValue, "Data Siswa/SiswaDashboard", typeof(MyPages.SiswaDashboardController), icon: "fa-pie-chart")]
[assembly: NavigationLink(int.MaxValue, "Data Siswa/Siswa", typeof(MyPages.SiswaController), icon: "fa-users")]
[assembly: NavigationLink(int.MaxValue, "Data Siswa/Kota", typeof(MyPages.KotaController), icon: "fa-building-o")]
[assembly: NavigationLink(int.MaxValue, "Data Siswa/Jurusan", typeof(MyPages.JurusanController), icon: "fa fa-list")]
[assembly: NavigationLink(int.MaxValue, "Data Siswa/Kelas", typeof(MyPages.KelasController), icon: "fa fa-list")]
