#pragma checksum "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f175f8ab23f73182cf08bf7994ce6fc9ecc6b24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_Index), @"mvc.1.0.view", @"/Views/Manager/Index.cshtml")]
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
#line 1 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/_ViewImports.cshtml"
using health_declaration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/_ViewImports.cshtml"
using health_declaration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/_ViewImports.cshtml"
using health_declaration.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f175f8ab23f73182cf08bf7994ce6fc9ecc6b24", @"/Views/Manager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bfc5ae56fc49c67953bb003de83267f0c52242d", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical_Declaration>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
  
    ViewBag.Title = "Managerment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<table class=""table table-bordered table-hover mt2"">
    <thead class=""thead-dark"">
        <tr>
            <th>Id</th>
            <th>User Name</th>
            <th>GateId</th>
            <th>Phone</th>
            <th>Address</th>
            <th>Symptom</th>
            <th>Description</th>
            <th>Dob</th>
            <th>Gender</th>
            <th>Start_Place</th>
            <th>Destination</th>
            <th>Departure_Day</th>
            <th>Entry_Date</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
         if (Model != null && Model.Any())
        {
            foreach (var md in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 31 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.GateId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.SymptonId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.Dob);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.start_place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.Departure_day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
           Write(md.Entry_date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "/Users/phanbaphap/Desktop/git/health_declaration/health_declaration/Views/Manager/Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical_Declaration>> Html { get; private set; }
    }
}
#pragma warning restore 1591
