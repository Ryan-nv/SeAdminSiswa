#pragma checksum "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "518b1eb6a7a7be545d4ac75174e4cd2ea871436b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_AccountLogin), @"mvc.1.0.view", @"/Modules/Membership/Account/AccountLogin.cshtml")]
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
#line 1 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\_ViewImports.cshtml"
using SeAdminSiswa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"518b1eb6a7a7be545d4ac75174e4cd2ea871436b", @"/Modules/Membership/Account/AccountLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6aa22dfec6cdaa6bda62011e915ffce04a91f226", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_AccountLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.Login.LoginToYourAccount.ToString(Localizer);
    ViewData["PageId"] = "Login";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    a { text-decoration: none; }\r\n</style>\r\n\r\n");
#nullable restore
#line 14 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
 if (DataMigrations.SkippedMigrations)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-error alert-dismissible"">
        <button type=""button"" class=""close btn-close"" data-dismiss=""alert"" data-bs-dismiss=""alert"" aria-hidden=""true"">×</button>
        <h4><i class=""icon fa fa-warning""></i> Warning!</h4>
        SeAdminSiswa skipped running migrations to avoid modifying an arbitrary database.
        If you'd like to run migrations on this database, remove the safety check
        in SiteInitialization.RunMigrations method.
    </div>
");
#nullable restore
#line 23 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
 if (ViewData["Activated"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info alert-dismissible\">\r\n        <button type=\"button\" class=\"close btn-close\" data-dismiss=\"alert\" data-bs-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n        <h4><i class=\"icon fa fa-info\"></i>");
#nullable restore
#line 29 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
                                      Write(Localizer.Get("Dialogs.InformationTitle"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        ");
#nullable restore
#line 30 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
   Write(Texts.Forms.Membership.SignUp.ActivationCompleteMessage.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""s-full-page justify-content-center"">
    <div id=""LoginPanel"" class=""s-container-tight s-Form flex-layout"">

    </div>
</div>

<script type=""text/javascript"">

jQuery(function() {
    var loginPanel = new SeAdminSiswa.Membership.LoginPanel($('#LoginPanel')).init();
    loginPanel.element.find('.forgot-password').appendTo('.field.Password');

");
#nullable restore
#line 46 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
     if (EnvironmentOptions.Value.IsPublicDemo)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        loginPanel.byId(\'Username\').val(\'admin\').attr(\'placeholder\', \'admin\')\r\n        loginPanel.byId(\'Password\').val(\'serenity\').attr(\'placeholder\', \'serenity\');\r\n        ");
#nullable restore
#line 51 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
               
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
     if (ViewData["Activated"] != null)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        $(function() {\r\n            loginPanel.byId(\'Username\').val(");
#nullable restore
#line 58 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
                                       Write(Html.Raw(Serenity.JSON.Stringify(ViewData["Activated"])));

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n            loginPanel.byId(\'Password\').focus();\r\n        });\r\n        ");
#nullable restore
#line 61 "C:\Projects\WebApp\Serenity\SeAdminSiswa\SeAdminSiswa.Web\Modules\Membership\Account\AccountLogin.cshtml"
               
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Options.IOptions<Serenity.Extensions.EnvironmentSettings> EnvironmentOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IDataMigrations DataMigrations { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
