#pragma checksum "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f35f86aad01b98c23d8678eaabc629f21fcddb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__UsersListViewPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
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
#line 1 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
using TechTreeMVCWebApplication.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f35f86aad01b98c23d8678eaabc629f21fcddb7", @"/Areas/Admin/Views/Shared/_UsersListViewPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"361a3446c64f44fca2926f31ae7521de9128e74e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__UsersListViewPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TechTreeMVCWebApplication.Areas.Admin.Models.UsersCategoryListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table class=\"table table-hover\">\n    <thead>\n        <tr>\n            <th></th>\n            <th>First Name</th>\n            <th>Last Name</th>\n            <th>Email</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 14 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
         if(Model.Users != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             foreach(var user in Model.Users)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td style=\"text-align:center\">\n");
#nullable restore
#line 20 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                 if (Model.UsersSelected != null && Model.UsersSelected.Contains(user, new CompareUsers()))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\" checked");
            BeginWriteAttribute("value", " value=\"", 729, "\"", 745, 1);
#nullable restore
#line 22 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 737, user.Id, 737, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 23 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"checkbox\" id=\"UsersSelected\" class=\"form-check-input\" name=\"UsersSelected\"");
            BeginWriteAttribute("value", " value=\"", 914, "\"", 930, 1);
#nullable restore
#line 26 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
WriteAttributeValue("", 922, user.Id, 922, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 27 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>");
#nullable restore
#line 29 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 30 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 31 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
           Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 33 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Areas\Admin\Views\Shared\_UsersListViewPartial.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TechTreeMVCWebApplication.Areas.Admin.Models.UsersCategoryListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
