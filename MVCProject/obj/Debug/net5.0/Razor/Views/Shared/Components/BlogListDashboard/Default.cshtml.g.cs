#pragma checksum "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a43bb8ad4078095d31f0c2be33ddde3534b3513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
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
#line 1 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\_ViewImports.cshtml"
using MVCProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\BlogListDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a43bb8ad4078095d31f0c2be33ddde3534b3513", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b164ba05e44095d836e96f9aeb340abce95017dd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Son 10 Blog</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Ba??l??k </th>
                                <th> Kategori </th>
                                <th> Last Update </th>
                                <th> Detaylar </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 20 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 961, "\"", 978, 1);
#nullable restore
#line 25 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 967, item.Image, 967, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\">\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 28 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td> <label class=\"badge badge-gradient-success\">");
#nullable restore
#line 30 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                                Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></td>\r\n                                    <td> ");
#nullable restore
#line 31 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                     Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1452, "\"", 1485, 2);
            WriteAttributeValue("", 1459, "/Blog/BlogReadAll/", 1459, 18, true);
#nullable restore
#line 32 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 1477, item.ID, 1477, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn btn-primary\">Detaylar</a></td>\r\n                                </tr>\r\n");
#nullable restore
#line 34 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
