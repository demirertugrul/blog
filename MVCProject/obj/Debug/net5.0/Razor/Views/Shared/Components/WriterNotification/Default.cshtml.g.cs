#pragma checksum "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "318d3d18770f5cb2e723b81a40267819df15c2ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
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
#line 1 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"318d3d18770f5cb2e723b81a40267819df15c2ff", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b164ba05e44095d836e96f9aeb340abce95017dd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Bildirimler</h6>\r\n");
#nullable restore
#line 5 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterNotification\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\r\n        <a class=\"dropdown-item preview-item\">\r\n            <div class=\"preview-thumbnail\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 416, "\"", 435, 1);
#nullable restore
#line 10 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 424, item.Color, 424, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 461, "\"", 485, 1);
#nullable restore
#line 11 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 469, item.TypeSembol, 469, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                </div>\r\n            </div>\r\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                <h6 class=\"preview-subject font-weight-normal mb-1\">");
#nullable restore
#line 15 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                               Write(item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"text-gray ellipsis mb-0\"> ");
#nullable restore
#line 16 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterNotification\Default.cshtml"
                                               Write(item.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 19 "D:\Lesson\Tech_Projects\Dev_Project\CSHARP\MVCNET5Murat\DOTNET50MVC\MVCProject\MVCProject\Views\Shared\Components\WriterNotification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"dropdown-divider\"></div>\r\n    <h6 class=\"p-3 mb-0 text-center\">Tüm Bildirimleri Gör <h6>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
