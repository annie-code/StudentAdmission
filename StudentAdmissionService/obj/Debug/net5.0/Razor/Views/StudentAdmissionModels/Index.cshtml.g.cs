#pragma checksum "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7604a0dbc2d43278fbda5269c017e2f706a1ce33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentAdmissionModels_Index), @"mvc.1.0.view", @"/Views/StudentAdmissionModels/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7604a0dbc2d43278fbda5269c017e2f706a1ce33", @"/Views/StudentAdmissionModels/Index.cshtml")]
    public class Views_StudentAdmissionModels_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentAdmissionService.Models.StudentAdmissionModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateofJoining));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateofJoining));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1027, "\"", 1057, 1);
#nullable restore
#line 40 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
WriteAttributeValue("", 1042, item.StudentID, 1042, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1110, "\"", 1140, 1);
#nullable restore
#line 41 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
WriteAttributeValue("", 1125, item.StudentID, 1125, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1195, "\"", 1225, 1);
#nullable restore
#line 42 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
WriteAttributeValue("", 1210, item.StudentID, 1210, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "F:\ContentDevelopment\IIHT\MicroServices\Demo\StudentAdmissionService\StudentAdmissionService\Views\StudentAdmissionModels\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentAdmissionService.Models.StudentAdmissionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
