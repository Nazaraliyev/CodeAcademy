#pragma checksum "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef9acc547eab35c66a38c7342b304d3789452e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__cardPartial), @"mvc.1.0.view", @"/Views/Shared/_cardPartial.cshtml")]
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
#line 1 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\_ViewImports.cshtml"
using SixteenClothing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\_ViewImports.cshtml"
using SixteenClothing.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\_ViewImports.cshtml"
using SixteenClothing.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ef9acc547eab35c66a38c7342b304d3789452e0", @"/Views/Shared/_cardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2851285615f377e4971faae23e9d21f7829d1f99", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__cardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmCardPartial>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 42, "\"", 88, 4);
            WriteAttributeValue("", 50, "col-lg-4", 50, 8, true);
            WriteAttributeValue(" ", 58, "col-md-4", 59, 9, true);
            WriteAttributeValue(" ", 67, "all", 68, 4, true);
#nullable restore
#line 4 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml"
WriteAttributeValue(" ", 71, Model.ClassName, 72, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"product-item\">\r\n              <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 162, "\"", 193, 2);
            WriteAttributeValue("", 168, "/assets/images/", 168, 15, true);
#nullable restore
#line 6 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml"
WriteAttributeValue("", 183, Model.Img, 183, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 194, "\"", 200, 0);
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n              <div class=\"down-content\">\r\n                <a href=\"#\"><h4> ");
#nullable restore
#line 8 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml"
                            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\r\n                <h6>$");
#nullable restore
#line 9 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml"
                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p>");
#nullable restore
#line 10 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml"
              Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class = \"product-details d-flex justify-content-between\">\r\n                <ul");
            BeginWriteAttribute("class", " class=\"", 482, "\"", 490, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 13 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml"
                     for (var i = 0; i < 5; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <li><i");
            BeginWriteAttribute("class", " class=\"", 590, "\"", 637, 2);
#nullable restore
#line 15 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml"
WriteAttributeValue("", 598, i<Model.Star ? "fas" : "far", 598, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 629, "fa-star", 630, 8, true);
            EndWriteAttribute();
            WriteLiteral("></i></li>\r\n");
#nullable restore
#line 16 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <span>Reviews (");
#nullable restore
#line 18 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\Shared\_cardPartial.cshtml"
                          Write(Model.Preview);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</span>
                </div>


                <div>
                    <button class = ""btn btn-danger"">Add to Cart</button>
                    <button class = ""btn btn-danger"">Add to Fav</button>

                </div>
              </div>
            </div>
          </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmCardPartial> Html { get; private set; }
    }
}
#pragma warning restore 1591
