#pragma checksum "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbbebc758d0436c7d38bbfc2c1d4b981a422c5a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DisplayCardRowPartial), @"mvc.1.0.view", @"/Views/Shared/_DisplayCardRowPartial.cshtml")]
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
#line 1 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\_ViewImports.cshtml"
using TechTreeMVCWebApplication.Comparers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbbebc758d0436c7d38bbfc2c1d4b981a422c5a0", @"/Views/Shared/_DisplayCardRowPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5104202132c3d08d714c5a5c0170eff128c2f18d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DisplayCardRowPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-3\">\n");
#nullable restore
#line 6 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml"
         foreach (Category item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3 mt-3\">\n            <a href=\"#\" class=\"RegisterLink text-dark\" data-categoryId=\"");
#nullable restore
#line 9 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml"
                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                <div class=\"card\">\n                    <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 335, "\"", 365, 1);
#nullable restore
#line 11 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml"
WriteAttributeValue("", 341, item.ThumbnailImagePath, 341, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 366, "\"", 383, 1);
#nullable restore
#line 11 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml"
WriteAttributeValue("", 372, item.Title, 372, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <div class=\"card-body\">\n                        <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml"
                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml"
                                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                    <a href=\"#\" class=\"RegisterLink btn btn-outline-info\">Enroll</a>\n                </div>\n                \n            </a>\n            \n        </div>\n");
#nullable restore
#line 22 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n");
#nullable restore
#line 24 "C:\Users\Cheptoo\Downloads\Online-Learning-Platform\Online-Learning-Platform\Views\Shared\_DisplayCardRowPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
