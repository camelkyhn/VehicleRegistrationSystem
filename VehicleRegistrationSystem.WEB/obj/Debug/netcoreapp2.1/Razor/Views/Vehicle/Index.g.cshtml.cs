#pragma checksum "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f5b6fbaded2295c965ed07081e7d15ab6334948"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_Index), @"mvc.1.0.view", @"/Views/Vehicle/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/Index.cshtml", typeof(AspNetCore.Views_Vehicle_Index))]
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
#line 1 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/_ViewImports.cshtml"
using VehicleRegistrationSystem.WEB;

#line default
#line hidden
#line 2 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/_ViewImports.cshtml"
using VehicleRegistrationSystem.WEB.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f5b6fbaded2295c965ed07081e7d15ab6334948", @"/Views/Vehicle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9f187a9a272ad0a0ba5875e29a2f01bbbb88092", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VehicleRegistrationSystem.Common.Entities.Vehicle>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(70, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(129, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(155, 39, false);
#line 11 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(194, 63, true);
            WriteLiteral("\n</p>\n\n<table class=\"table\">\n    <tr>\n        <th>\n            ");
            EndContext();
            BeginContext(258, 41, false);
#line 17 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(299, 49, true);
            WriteLiteral("\n        </th>\n        \n        <th>\n            ");
            EndContext();
            BeginContext(349, 41, false);
#line 21 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(390, 49, true);
            WriteLiteral("\n        </th>\n        \n        <th>\n            ");
            EndContext();
            BeginContext(440, 40, false);
#line 25 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(480, 49, true);
            WriteLiteral("\n        </th>\n        \n        <th>\n            ");
            EndContext();
            BeginContext(530, 45, false);
#line 29 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.ModelYear));

#line default
#line hidden
            EndContext();
            BeginContext(575, 49, true);
            WriteLiteral("\n        </th>\n        \n        <th>\n            ");
            EndContext();
            BeginContext(625, 44, false);
#line 33 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.NickName));

#line default
#line hidden
            EndContext();
            BeginContext(669, 49, true);
            WriteLiteral("\n        </th>\n        \n        <th>\n            ");
            EndContext();
            BeginContext(719, 41, false);
#line 37 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Plate));

#line default
#line hidden
            EndContext();
            BeginContext(760, 49, true);
            WriteLiteral("\n        </th>\n        \n        <th>\n            ");
            EndContext();
            BeginContext(810, 41, false);
#line 41 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(851, 49, true);
            WriteLiteral("\n        </th>\n        \n        <th>\n            ");
            EndContext();
            BeginContext(901, 44, false);
#line 45 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(945, 30, true);
            WriteLiteral("\n        </th>\n    </tr>\n    \n");
            EndContext();
#line 49 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(1014, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(1061, 36, false);
#line 53 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.DisplayFor(model => item.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 61, true);
            WriteLiteral("\n            </td>\n        \n            <td>\n                ");
            EndContext();
            BeginContext(1159, 36, false);
#line 57 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.DisplayFor(model => item.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 61, true);
            WriteLiteral("\n            </td>\n        \n            <td>\n                ");
            EndContext();
            BeginContext(1257, 35, false);
#line 61 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.DisplayFor(model => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 61, true);
            WriteLiteral("\n            </td>\n        \n            <td>\n                ");
            EndContext();
            BeginContext(1354, 40, false);
#line 65 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.DisplayFor(model => item.ModelYear));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 61, true);
            WriteLiteral("\n            </td>\n        \n            <td>\n                ");
            EndContext();
            BeginContext(1456, 39, false);
#line 69 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.DisplayFor(model => item.NickName));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 61, true);
            WriteLiteral("\n            </td>\n        \n            <td>\n                ");
            EndContext();
            BeginContext(1557, 36, false);
#line 73 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.DisplayFor(model => item.Plate));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 61, true);
            WriteLiteral("\n            </td>\n        \n            <td>\n                ");
            EndContext();
            BeginContext(1655, 36, false);
#line 77 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.DisplayFor(model => item.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 61, true);
            WriteLiteral("\n            </td>\n        \n            <td>\n                ");
            EndContext();
            BeginContext(1753, 39, false);
#line 81 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.DisplayFor(model => item.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1792, 65, true);
            WriteLiteral("\n            </td>\n            \n            <td>\n                ");
            EndContext();
            BeginContext(1858, 53, false);
#line 85 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1911, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(1931, 59, false);
#line 86 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1990, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(2010, 57, false);
#line 87 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2067, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 90 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2106, 9, true);
            WriteLiteral("</table>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VehicleRegistrationSystem.Common.Entities.Vehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
