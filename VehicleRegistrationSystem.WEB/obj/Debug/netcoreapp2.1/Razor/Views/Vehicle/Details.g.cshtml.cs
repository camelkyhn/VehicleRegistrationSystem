#pragma checksum "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92da9734dbd9133065a1162e2911e76e8c903395"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicle_Details), @"mvc.1.0.view", @"/Views/Vehicle/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehicle/Details.cshtml", typeof(AspNetCore.Views_Vehicle_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92da9734dbd9133065a1162e2911e76e8c903395", @"/Views/Vehicle/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9f187a9a272ad0a0ba5875e29a2f01bbbb88092", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VehicleRegistrationSystem.Common.Entities.Vehicle>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(118, 122, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Vehicle</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        \n        <dt>\n            ");
            EndContext();
            BeginContext(241, 41, false);
#line 16 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(282, 49, true);
            WriteLiteral("\n        </dt>\n        \n        <dd>\n            ");
            EndContext();
            BeginContext(332, 37, false);
#line 20 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayFor(model => model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(369, 49, true);
            WriteLiteral("\n        </dd>\n        \n        <dt>\n            ");
            EndContext();
            BeginContext(419, 41, false);
#line 24 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(460, 49, true);
            WriteLiteral("\n        </dt>\n        \n        <dd>\n            ");
            EndContext();
            BeginContext(510, 37, false);
#line 28 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
            EndContext();
            BeginContext(547, 49, true);
            WriteLiteral("\n        </dd>\n        \n        <dt>\n            ");
            EndContext();
            BeginContext(597, 40, false);
#line 32 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(637, 49, true);
            WriteLiteral("\n        </dt>\n        \n        <dd>\n            ");
            EndContext();
            BeginContext(687, 36, false);
#line 36 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(723, 49, true);
            WriteLiteral("\n        </dd>\n        \n        <dt>\n            ");
            EndContext();
            BeginContext(773, 45, false);
#line 40 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModelYear));

#line default
#line hidden
            EndContext();
            BeginContext(818, 49, true);
            WriteLiteral("\n        </dt>\n        \n        <dd>\n            ");
            EndContext();
            BeginContext(868, 41, false);
#line 44 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayFor(model => model.ModelYear));

#line default
#line hidden
            EndContext();
            BeginContext(909, 49, true);
            WriteLiteral("\n        </dd>\n        \n        <dt>\n            ");
            EndContext();
            BeginContext(959, 44, false);
#line 48 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NickName));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 41, true);
            WriteLiteral("\n        </dt>\n\n        <dd>\n            ");
            EndContext();
            BeginContext(1045, 40, false);
#line 52 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayFor(model => model.NickName));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 49, true);
            WriteLiteral("\n        </dd>\n        \n        <dt>\n            ");
            EndContext();
            BeginContext(1135, 41, false);
#line 56 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Plate));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 49, true);
            WriteLiteral("\n        </dt>\n        \n        <dd>\n            ");
            EndContext();
            BeginContext(1226, 37, false);
#line 60 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayFor(model => model.Plate));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 49, true);
            WriteLiteral("\n        </dd>\n        \n        <dt>\n            ");
            EndContext();
            BeginContext(1313, 41, false);
#line 64 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1354, 49, true);
            WriteLiteral("\n        </dt>\n        \n        <dd>\n            ");
            EndContext();
            BeginContext(1404, 37, false);
#line 68 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 49, true);
            WriteLiteral("\n        </dd>\n        \n        <dt>\n            ");
            EndContext();
            BeginContext(1491, 44, false);
#line 72 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 49, true);
            WriteLiteral("\n        </dt>\n        \n        <dd>\n            ");
            EndContext();
            BeginContext(1585, 40, false);
#line 76 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 49, true);
            WriteLiteral("\n        </dd>\n        \n    </dl>\n</div>\n<p>\n    ");
            EndContext();
            BeginContext(1675, 54, false);
#line 82 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1737, 40, false);
#line 83 "/home/kemal/RiderProjects/VehicleRegistrationSystem/VehicleRegistrationSystem.WEB/Views/Vehicle/Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 6, true);
            WriteLiteral("\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VehicleRegistrationSystem.Common.Entities.Vehicle> Html { get; private set; }
    }
}
#pragma warning restore 1591
