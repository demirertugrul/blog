#pragma checksum "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b032c7446565fbdf23d17d30c0e9ecc2f44f034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterAboutOnDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
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
#line 1 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b032c7446565fbdf23d17d30c0e9ecc2f44f034", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b164ba05e44095d836e96f9aeb340abce95017dd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterAboutOnDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Yazar Hakkında</h4>\r\n                <h1>Selam ");
#nullable restore
#line 8 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                     Write(ViewBag.v);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div class=\"d-flex mt-5 align-items-top\">\r\n");
#nullable restore
#line 10 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                     foreach (var item in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 450, "\"", 467, 1);
#nullable restore
#line 13 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
WriteAttributeValue("", 456, item.Image, 456, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-sm rounded-circle mr-3\" alt=\"image\">\r\n                        <div class=\"mb-0 flex-grow\">\r\n                            <h5 class=\"mr-2 mb-2\">");
#nullable restore
#line 15 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 15 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                                          Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"mb-0 font-weight-light\">");
#nullable restore
#line 16 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                                         Write(item.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 18 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"ml-auto\">\r\n                            <i class=\"mdi mdi-heart-outline text-muted\"></i>\r\n                        </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591