#pragma checksum "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4a2f0feb13a5712f79b06586609fa3d058cb328"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Sidebar), @"mvc.1.0.view", @"/Views/Shared/_Sidebar.cshtml")]
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
#line 1 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\_ViewImports.cshtml"
using SeAdminSiswa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a2f0feb13a5712f79b06586609fa3d058cb328", @"/Views/Shared/_Sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb05732d2ebce9693b306b4a0931165ed66d619", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Serenity.Navigation.INavigationModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("s-sidebar-header-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/site/images/serenity-logo-w-128.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/ChangePassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/Signout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
  
    void renderItem(Serenity.Navigation.NavigationItem item, string parentId, int index) {
        var isActive = Model.ActivePath.Contains(item);
        var hasChildren = item.Children.Any();
        var klass = "s-sidebar-item" + (isActive ? " active" : "") + (hasChildren ? " has-children" : "") +
            (!string.IsNullOrEmpty(item.ItemClass) ? (" " + item.ItemClass) : "");
        var icon = item.IconClass ?? "";
        var title = Localizer.TryGet("Navigation." + item.FullPath) ?? item.Title;
        var ulId = parentId + "_" + index;
        var url = item.Url ?? (hasChildren ? ("#" + ulId) : "javascript:;");
        var target = Html.Raw(item.Target != null ? (" target=" + item.Target) : "");
        var bsToggle = Html.Raw(hasChildren ? " data-bs-toggle=\"collapse\"" : "");
        var ariaExpanded = Html.Raw(hasChildren && isActive ? " aria-expanded=\"true\"" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li");
            BeginWriteAttribute("class", " class=\"", 1009, "\"", 1023, 1);
#nullable restore
#line 16 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
WriteAttributeValue("", 1017, klass, 1017, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <a class=\"s-sidebar-link\"");
            BeginWriteAttribute("href", " href=\"", 1064, "\"", 1075, 1);
#nullable restore
#line 17 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
WriteAttributeValue("", 1071, url, 1071, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
#nullable restore
#line 17 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                                            Write(target);

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                                                   Write(bsToggle);

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                                                            Write(ariaExpanded);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 1126, "\"", 1157, 3);
            WriteAttributeValue("", 1134, "s-sidebar-icon", 1134, 14, true);
            WriteAttributeValue(" ", 1148, "fa", 1149, 3, true);
#nullable restore
#line 18 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
WriteAttributeValue(" ", 1151, icon, 1152, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                <span class=\"s-sidebar-link-text\">");
#nullable restore
#line 19 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                                             Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 20 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                 if (hasChildren)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<em class=\"s-sidebar-menu-toggle fa fa-angle-right\"></em>");
#nullable restore
#line 21 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </a>\r\n");
#nullable restore
#line 23 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
             if (hasChildren)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul");
            BeginWriteAttribute("id", " id=\"", 1425, "\"", 1435, 1);
#nullable restore
#line 25 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
WriteAttributeValue("", 1430, ulId, 1430, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1436, "\"", 1493, 3);
            WriteAttributeValue("", 1444, "s-sidebar-menu", 1444, 14, true);
            WriteAttributeValue(" ", 1458, "collapse", 1459, 9, true);
#nullable restore
#line 25 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
WriteAttributeValue("", 1467, isActive ? " show" : "", 1467, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-parent=\"#");
#nullable restore
#line 25 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                                                                                                     Write(parentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 26 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                  var idx = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                 foreach (var child in item.Children)
                {
                    renderItem(child, ulId, ++idx);
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n");
#nullable restore
#line 32 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </li>\r\n");
#nullable restore
#line 34 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<aside class=""s-sidebar"" id=""s-sidebar"">
    <div class=""s-sidebar-pane"">
        <div id=""s-sidebar-search"" class=""s-sidebar-search m-3"">
            <i class=""fa fa-search fa-flip-horizontal s-sidebar-search-icon""></i>
            <input type=""text"" class=""w-100 s-sidebar-search-input""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2061, "\"", 2125, 1);
#nullable restore
#line 41 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
WriteAttributeValue("", 2075, Localizer.Get("Controls.QuickSearch.Placeholder"), 2075, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <ul id=\"s-sidebar-menu\" class=\"s-sidebar-menu\">\r\n");
#nullable restore
#line 44 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
              var itm = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
             foreach (var item in Model.Items)
            {
                renderItem(item, "s-sidebar-menus", ++itm);
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>
</aside>

<header class=""navbar sticky-top s-sidebar-header"">
    <button class=""s-sidebar-toggler"" type=""button"" id=""s-sidebar-toggler""
        aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <i class=""fa fa-bars""></i>
    </button>
    <div class=""s-sidebar-header-branding"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4a2f0feb13a5712f79b06586609fa3d058cb32813465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <ul class=""s-sidebar-header-actions"">
        <li>
            <div class=""dropdown"">
                <a href=""javascript:;"" class=""s-sidebar-header-link s-language-selection-link"" 
                    data-bs-toggle=""dropdown"" title=""switch language"">
                    <i class=""fa fa-language""></i>
                </a>
                <ul class=""dropdown-menu dropdown-menu-end s-language-selection-menu"">
                </ul>
            </div>
        </li>
");
#nullable restore
#line 72 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
         if (User.IsLoggedIn())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <div class=\"dropdown\">\r\n                <a href=\"javascript:;\" class=\"s-sidebar-header-link s-user-profile-link\" \r\n                    data-bs-toggle=\"dropdown\"");
            BeginWriteAttribute("title", " title=\"", 3553, "\"", 3582, 1);
#nullable restore
#line 77 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
WriteAttributeValue("", 3561, User?.Identity?.Name, 3561, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <i class=""fa fa-user""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-md dropdown-menu-end s-user-profile-menu"">
                    <div class=""s-user-card p-1 mb-2 text-center border-bottom"">
                        <h2 class=""s-user-avatar fs-1 mb-0"">
                            <i class=""fa fa-user""></i>
                        </h2>
                        <p class=""s-user-info fs-6 mb-1"">
                            ");
#nullable restore
#line 86 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                       Write(Context.User?.Identity?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4a2f0feb13a5712f79b06586609fa3d058cb32816741", async() => {
                WriteLiteral("\r\n                        <em class=\"icon fa fa-key\"></em><span> ");
#nullable restore
#line 90 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                                                          Write(Texts.Forms.Membership.ChangePassword.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4a2f0feb13a5712f79b06586609fa3d058cb32818345", async() => {
                WriteLiteral("\r\n                        <em class=\"icon fa fa-sign-out-alt\"></em><span> ");
#nullable restore
#line 93 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
                                                                   Write(Localizer.Get("Navigation.LogoutLink"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 98 "C:\Magang\Pra_Magang_Util\serenesiswa\SeAdminSiswa\Views\Shared\_Sidebar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Serenity.Navigation.INavigationModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
