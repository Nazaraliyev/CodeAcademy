#pragma checksum "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 12\ClassTesk\Views\Shared\Components\Header\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faa066b2f8da6b235293cf4d686d999324288656"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Header_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Header/Default.cshtml")]
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
#line 1 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 12\ClassTesk\Views\_ViewImports.cshtml"
using ClassTesk;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 12\ClassTesk\Views\_ViewImports.cshtml"
using ClassTesk.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 12\ClassTesk\Views\_ViewImports.cshtml"
using ClassTesk.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faa066b2f8da6b235293cf4d686d999324288656", @"/Views/Shared/Components/Header/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96707abebe2ab362a26b00808c8d5bbd6cf4b66b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Header_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmSetting>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<!-- ======= Top Bar ======= -->
<section id=""topbar"" class=""d-flex align-items-center"">
    <div class=""container d-flex justify-content-center justify-content-md-between"">
        <div class=""contact-info d-flex align-items-center"">
            <i class=""bi bi-envelope d-flex align-items-center""><a href=""mailto:contact@example.com"">contact@example.com</a></i>
            <i class=""bi bi-phone d-flex align-items-center ms-4""><span>+1 5589 55488 55</span></i>
        </div>
        <div class=""social-links d-none d-md-flex align-items-center"">
            
            <a href=""#"" class=""twitter""><i class=""bi bi-twitter""></i></a>
            <a href=""#"" class=""facebook""><i class=""bi bi-facebook""></i></a>
            <a href=""#"" class=""instagram""><i class=""bi bi-instagram""></i></a>
            <a href=""#"" class=""linkedin""><i class=""bi bi-linkedin""></i></i></a>
        </div>
    </div>
</section>

<!-- ======= Header ======= -->
<header id=""header"" class=""d-flex align-items-center"">
    <");
            WriteLiteral(@"div class=""container d-flex align-items-center justify-content-between"">

        <h1 class=""logo""><a href=""index.html"">BizLand<span>.</span></a></h1>
        <!-- Uncomment below if you prefer to use an image logo -->
        <!-- <a href=""index.html"" class=""logo""><img src=""assets/img/logo.png"" alt=""""></a>-->

        <nav id=""navbar"" class=""navbar"">
            <ul>
                <li><a class=""nav-link scrollto active"" href=""#hero"">Home</a></li>
                <li><a class=""nav-link scrollto"" href=""#about"">About</a></li>
                <li><a class=""nav-link scrollto"" href=""#services"">Services</a></li>
                <li><a class=""nav-link scrollto "" href=""#portfolio"">Portfolio</a></li>
                <li><a class=""nav-link scrollto"" href=""#team"">Team</a></li>
                <li class=""dropdown"">
                    <a href=""#""><span>Drop Down</span> <i class=""bi bi-chevron-down""></i></a>
                    <ul>
                        <li><a href=""#"">Drop Down 1</a></li>
          ");
            WriteLiteral(@"              <li class=""dropdown"">
                            <a href=""#""><span>Deep Drop Down</span> <i class=""bi bi-chevron-right""></i></a>
                            <ul>
                                <li><a href=""#"">Deep Drop Down 1</a></li>
                                <li><a href=""#"">Deep Drop Down 2</a></li>
                                <li><a href=""#"">Deep Drop Down 3</a></li>
                                <li><a href=""#"">Deep Drop Down 4</a></li>
                                <li><a href=""#"">Deep Drop Down 5</a></li>
                            </ul>
                        </li>
                        <li><a href=""#"">Drop Down 2</a></li>
                        <li><a href=""#"">Drop Down 3</a></li>
                        <li><a href=""#"">Drop Down 4</a></li>
                    </ul>
                </li>
                <li><a class=""nav-link scrollto"" href=""#contact"">Contact</a></li>
            </ul>
            <i class=""bi bi-list mobile-nav-toggle""></i>
       ");
            WriteLiteral(" </nav><!-- .navbar -->\r\n\r\n    </div>\r\n</header><!-- End Header -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmSetting> Html { get; private set; }
    }
}
#pragma warning restore 1591
