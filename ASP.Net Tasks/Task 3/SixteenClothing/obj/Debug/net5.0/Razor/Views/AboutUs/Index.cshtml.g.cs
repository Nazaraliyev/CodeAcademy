#pragma checksum "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "512f8b3037376604be11f312f75f76232c59aa84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AboutUs_Index), @"mvc.1.0.view", @"/Views/AboutUs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"512f8b3037376604be11f312f75f76232c59aa84", @"/Views/AboutUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2851285615f377e4971faae23e9d21f7829d1f99", @"/Views/_ViewImports.cshtml")]
    public class Views_AboutUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmAboutUs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!-- Page Content -->\r\n    <div class=\"page-heading about-heading header-text\">\r\n      <div class=\"container\">\r\n        <div class=\"row\">\r\n          <div class=\"col-md-12\">\r\n            <div class=\"text-content\">\r\n              <h4>");
#nullable restore
#line 10 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
             Write(Model.settings.AboutUsSubHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n              <h2>");
#nullable restore
#line 11 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
             Write(Model.settings.AboutUsHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
            </div>
          </div>
        </div>
      </div>
    </div>


    <div class=""best-features about-features"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-12"">
            <div class=""section-heading"">
              <h2>Our Background</h2>
            </div>
          </div>
          <div class=""col-md-6"">
            <div class=""right-image"">
              <img");
            BeginWriteAttribute("src", " src=\"", 783, "\"", 830, 2);
            WriteAttributeValue("", 789, "/assets/images/", 789, 15, true);
#nullable restore
#line 29 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
WriteAttributeValue("", 804, Model.settings.AboutUsImg, 804, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 831, "\"", 837, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n          </div>\r\n          <div class=\"col-md-6\">\r\n            <div class=\"left-content\">\r\n              <h4>Who we are &amp; What we do?</h4>\r\n              <p>");
#nullable restore
#line 35 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
            Write(Model.settings.AboutUsContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
              <ul class=""social-icons"">
                <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                <li><a href=""#""><i class=""fa fa-behance""></i></a></li>
              </ul>
            </div>
          </div>
        </div>
      </div>
    </div>

    
    <div class=""team-members"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-12"">
            <div class=""section-heading"">
              <h2>Our Team Members</h2>
            </div>
          </div>
");
#nullable restore
#line 57 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
           for (var i = 0; i < 6; i++)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"col-md-4\">\r\n            <div class=\"team-member\">\r\n              <div class=\"thumb-container\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1936, "\"", 1976, 2);
            WriteAttributeValue("", 1942, "/assets/images/", 1942, 15, true);
#nullable restore
#line 62 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
WriteAttributeValue("", 1957, Model.teams[i].Img, 1957, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1977, "\"", 1983, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""hover-effect"">
                  <div class=""hover-content"">
                    <ul class=""social-icons"">
                      <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                      <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                      <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                      <li><a href=""#""><i class=""fa fa-behance""></i></a></li>
                    </ul>
                  </div>
                </div>
              </div>
              <div class=""down-content"">
                <h4>");
#nullable restore
#line 75 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
                Write(Model.teams[i].Name + " " + Model.teams[i].Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <span>");
#nullable restore
#line 76 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
                 Write(Model.teams[i].Speciality.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <p>");
#nullable restore
#line 77 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
              Write(Model.teams[i].Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              </div>\r\n            </div>\r\n          </div>   \n");
#nullable restore
#line 81 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n      </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"services\">\r\n      <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 90 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
             foreach (var item in Model.qualities)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"col-md-4\">\r\n            <div class=\"service-item\">\r\n              <div class=\"icon\">\r\n                <i class=\"fa fa-gear\"></i>\r\n              </div>\r\n              <div class=\"down-content\">\r\n                <h4>");
#nullable restore
#line 98 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
               Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>");
#nullable restore
#line 99 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
              Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a href=\"#\" class=\"filled-button\">Read More</a>\r\n              </div>\r\n            </div>\r\n          </div>\n");
#nullable restore
#line 104 "N:\Codes\Back\CodeAcademy\ASP.Net Tasks\Task 3\SixteenClothing\Views\AboutUs\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
      </div>
    </div>


    <div class=""happy-clients"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-12"">
            <div class=""section-heading"">
              <h2>Happy Partners</h2>
            </div>
          </div>
          <div class=""col-md-12"">
            <div class=""owl-clients owl-carousel"">
              <div class=""client-item"">
                <img src=""/assets/images/client-01.png"" alt=""1"">
              </div>
              
              <div class=""client-item"">
                <img src=""/assets/images/client-01.png"" alt=""2"">
              </div>
              
              <div class=""client-item"">
                <img src=""/assets/images/client-01.png"" alt=""3"">
              </div>
              
              <div class=""client-item"">
                <img src=""/assets/images/client-01.png"" alt=""4"">
              </div>
              
              <div class=""client-item"">
                <img src");
            WriteLiteral(@"=""/assets/images/client-01.png"" alt=""5"">
              </div>
              
              <div class=""client-item"">
                <img src=""/assets/images/client-01.png"" alt=""6"">
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmAboutUs> Html { get; private set; }
    }
}
#pragma warning restore 1591
