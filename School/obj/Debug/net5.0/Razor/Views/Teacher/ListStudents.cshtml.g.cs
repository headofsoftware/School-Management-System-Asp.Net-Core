#pragma checksum "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Teacher\ListStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82592161e26c7b7fe01d47358540b720a09b1fec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_ListStudents), @"mvc.1.0.view", @"/Views/Teacher/ListStudents.cshtml")]
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
#line 1 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\_ViewImports.cshtml"
using School;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\_ViewImports.cshtml"
using School.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Teacher\ListStudents.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82592161e26c7b7fe01d47358540b720a09b1fec", @"/Views/Teacher/ListStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4035b931494fa1549d6ea6f2e0dd8aa05ecfb9a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_ListStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LessonStudent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Teacher\ListStudents.cshtml"
  
    ViewData["Title"] = "ListStudents";
    Layout = "~/Views/Shared/_TeacherLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>List Students</h1>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<table class=\"table table-dark col-10  mx-auto\">\r\n    <tr>\r\n        <th>Lesson ID</th>\r\n        <th>Lesson Name</th>\r\n        <th>Student Name</th>\r\n        <th>Student LastName</th>\r\n    </tr>\r\n");
#nullable restore
#line 27 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Teacher\ListStudents.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 30 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Teacher\ListStudents.cshtml"
           Write(item.LessonID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 31 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Teacher\ListStudents.cshtml"
           Write(item.Lesson.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Teacher\ListStudents.cshtml"
           Write(item.Student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Teacher\ListStudents.cshtml"
           Write(item.Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "C:\D\D\çalışmalar\Backend\Yürütülen\School\School\Views\Teacher\ListStudents.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LessonStudent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
