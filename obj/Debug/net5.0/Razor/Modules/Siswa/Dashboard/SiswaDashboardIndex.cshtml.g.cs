#pragma checksum "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7de74bed290c01659d39645e4585b9ce9909e290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Siswa_Dashboard_SiswaDashboardIndex), @"mvc.1.0.view", @"/Modules/Siswa/Dashboard/SiswaDashboardIndex.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\_ViewImports.cshtml"
using SeAdminSiswa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7de74bed290c01659d39645e4585b9ce9909e290", @"/Modules/Siswa/Dashboard/SiswaDashboardIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa22dfec6cdaa6bda62011e915ffce04a91f226", @"/Modules/_ViewImports.cshtml")]
    #nullable restore
    public class Modules_Siswa_Dashboard_SiswaDashboardIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeAdminSiswa.Siswa.SiswaDashboardPageModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
  
    ViewData["Title"] = "Dashboard";
    ViewData["PageId"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
Write(Html.StyleBundle("Pages/Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
Write(Html.ScriptBundle("Pages/Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n<h1>");
#nullable restore
#line 14 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
Write(Localizer.Get("Navigation.Dashboard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n");
            }
            );
            WriteLiteral(@"
<style>
    .s-dashboard-card,
    .s-dashboard-card-sm {
        margin-bottom: var(--bs-gutter-x);
    }

    .s-dashboard-card .card-header {
        padding: 1rem;
        border-bottom: none;
        background-color: transparent;
    }

    .s-dashboard-card .card-body {
        border-radius: 0 0 4px 4px;
        padding: 1rem;
    }

    .s-dashboard-card .card-footer {
        border-top-color: transparent;
        background-color: transparent;
        padding: 1rem;
    }

    .s-dashboard-card .card-title {
        margin: 0;
        font-size: 1.4rem;
        color: var(--s-table-title);
    }

    .s-dashboard-card-sm .card-body {
        padding: 1rem;
        border-radius: 4px 4px 0 0;
        margin: 1px;
    }

    .s-dashboard-card-sm .card-footer {
        color: rgba(var(--s-bright-rgb), 0.8);
        background-color: var(--bs-body-bg);
        border-radius: 0 0 4px 4px;
        border-top: none;
        margin: 0 1px 1px 1px;
        padding:");
            WriteLiteral(@" 3px 0;
        text-align: center;
        text-decoration: none;
    }

    .s-dashboard-card-sm h3 {
        font-size: 38px;
        font-weight: bold;
        margin: 0 0 10px 0;
        white-space: nowrap;
        padding: 0;
    }

    .s-dashboard-card-sm p {
        font-size: 15px;
    }

    .s-dashboard-card-sm p>small {
        display: block;
        font-size: 13px;
        margin-top: 5px;
    }

    .s-dashboard-card-sm .icon {
        transition: all 0.3s linear;
        position: absolute;
        top: 13px;
        color: #fff;
        opacity: 0.9;
        right: 10px;
        font-size: 64px;
    }

    .gridbase {
        height: 650px;
    }

    .bg-world-map {
        background: #3c8dbc;
    }

    .s-dashboard-card-sm:hover .icon {
        font-size: 70px;
    }

    .male {
        background-color: #4dc9f6;
    }

    .female {
        background-color: #f78af3;
    }

    .person {
        background-color: #a997fc;
    }
");
            WriteLiteral("</style>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4 col-sm-6\">\r\n        <div class=\"card s-dashboard-card-sm bg-opacity-50 person\">\r\n            <div class=\"card-body\">\r\n                <h3>");
#nullable restore
#line 121 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
               Write(Model.Murid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p>Total Siswa</p>
            </div>
            <div class=""icon"">
                <i class=""fa fa-users""></i>
            </div>
        </div>
    </div>
    <div class=""col-lg-4 col-sm-6"">
        <div class=""card s-dashboard-card-sm s-alt bg-opacity-50 male"">
            <div class=""card-body"">
                <h3>");
#nullable restore
#line 132 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
               Write(Model.MuridLk);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p>Siswa Laki Laki</p>
            </div>
            <div class=""icon"">
                <i class=""fa fa-male""></i>
            </div>
        </div>
    </div>
    <div class=""col-lg-4 col-sm-6"">
        <div class=""card s-dashboard-card-sm bg-opacity-50 female"">
            <div class=""card-body"">
                <h3>");
#nullable restore
#line 143 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
               Write(Model.MuridPr);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <p>Siswa Perempuan</p>
            </div>
            <div class=""icon"">
                <i class=""fa fa-female""></i>
            </div>
        </div>
    </div>
</div>

<div class=""row mb-lg-5 mb-sm-1"">
    <div class=""col-lg-6 col-md-12"">
        <h2 class=""m-sm-1 m-lg-2 text-center mb-3"">Presentase murid berdasarkan jenis kelamin</h2>
        <div>
            <canvas id=""presentase-jenis-kelamin-chart"" style=""height: 400px; width: auto; margin: 0 auto;""></canvas>
        </div>
    </div>
    <div class=""col-lg-6 col-md-12"">
        <h2 class=""m-sm-1 m-lg-2 text-center mb-3"">Asal Kota Siswa</h2>
        <div>
            <canvas id=""asal-kota-chart"" style=""height: 400px; width: auto; margin: 0 auto;""></canvas>
        </div>
    </div>
</div>

<div class=""row mt-lg-5 mt-sm-1"">
    <div class=""card row mt-lg-3 mt-sm-1"">
        <div class="" m-sm-1 m-lg-2 text-center"">
            <h3>Jumlah siswa bedasarkan tahun kelahiran</h3>
        </div>
        <di");
            WriteLiteral(@"v class=""card-body"">
            <canvas id=""kelahiran-chart"" style=""height: 400px;""></canvas>
        </div>
    </div>
</div>

<script>
    onload = function () {
        var jenkelChart = new Chart(document.getElementById('presentase-jenis-kelamin-chart'), {
            type: 'doughnut',
            data: {
                labels: [""Laki Laki"", ""Perempuan"",],
                datasets: [{
                    label: 'Presentase Murid',
                    data: [");
#nullable restore
#line 187 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
                      Write(Model.MuridLk.ToJson());

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 187 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
                                                Write(Model.MuridPr.ToJson());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"],
                    backgroundColor: [
                        'rgba(39, 125, 245, 0.3)',
                        'rgba(245, 39, 145, 0.3)'
                    ],
                    borderColor: [
                        'rgba(39, 125, 245, 1)',
                        'rgba(245, 39, 145, 1)'
                    ],
                    borderWidth: 1
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false
            }
        });
        var asalKotaChart = new Chart(document.getElementById('asal-kota-chart'), {
            type: 'polarArea',
            data: {
                labels: ");
#nullable restore
#line 207 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
                   Write(Html.Raw(Model.KotaKota));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                datasets: [{\r\n                    label: \'Asal Kota\',\r\n                    data: ");
#nullable restore
#line 210 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
                     Write(Model.KotaCount.ToJson());

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                    backgroundColor: [
                        'rgba(255, 99, 132, 0.3)',
                        'rgba(255, 159, 64, 0.3)',
                        'rgba(255, 205, 86, 0.3)',
                        'rgba(75, 192, 192, 0.3)',
                        'rgba(54, 162, 235, 0.3)',
                        'rgba(153, 102, 255, 0.3)'
                    ],
                    borderColor: [
                        'rgb(255, 99, 132)',
                        'rgb(255, 159, 64)',
                        'rgb(255, 205, 86)',
                        'rgb(75, 192, 192)',
                        'rgb(54, 162, 235)',
                        'rgb(153, 102, 255)',
                    ],
                    borderWidth: 1
                }]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false
            }
        });
        var kelahiranChart = new Chart(document.getElementById('kelahiran-chart'), {
            type: '");
            WriteLiteral("bar\',\r\n            data:\r\n            {\r\n                labels: ");
#nullable restore
#line 239 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
                   Write(Model.Years.ToJson());

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
                datasets: [
                    {
                        label: 'Siswa',
                        backgroundColor: [
                            'rgba(255, 99, 132, 0.3)',
                            'rgba(255, 159, 64, 0.3)',
                            'rgba(255, 205, 86, 0.3)',
                            'rgba(75, 192, 192, 0.3)',
                            'rgba(54, 162, 235, 0.3)',
                            'rgba(153, 102, 255, 0.3)'
                        ],
                        borderColor: [
                            'rgb(255, 99, 132)',
                            'rgb(255, 159, 64)',
                            'rgb(255, 205, 86)',
                            'rgb(75, 192, 192)',
                            'rgb(54, 162, 235)',
                            'rgb(153, 102, 255)',
                        ],
                        borderWidth: 1,
                        barPercentage: 0.7,
                        data: ");
#nullable restore
#line 261 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Modules\Siswa\Dashboard\SiswaDashboardIndex.cshtml"
                         Write(Model.YearsCount.ToJson());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    }
                ]
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
                    legend: {
                        display: false
                    }
                },
                scales: {
                    x: {
                        stacked: true,
                        ticks: {
                            callback: function (val, index) {
                                return index % 4 === 0 ? this.getLabelForValue(val) : '';
                            },
                            color: 'rgb(140, 142, 150)'
                        },
                        grid: {
                            color: 'rgba(140, 142, 150, 0.15)',
                            borderDash: [8, 4]
                        }
                    },
                    y: {
                        stacked: true,
                        ticks: {
                       ");
            WriteLiteral(@"     color: 'rgb(140, 142, 150)'
                        },
                        grid: {
                            color: 'rgba(140, 142, 150, 0.15)',
                            borderDash: [8, 4]
                        }
                    }
                },
                indexAxis: 'y'
            }
        });
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeAdminSiswa.Siswa.SiswaDashboardPageModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
