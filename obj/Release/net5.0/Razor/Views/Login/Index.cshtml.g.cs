#pragma checksum "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "029ca2d07e10c16634f3a8fe73e430fc38bada4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\_ViewImports.cshtml"
using CRUDPRACTICAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\_ViewImports.cshtml"
using CRUDPRACTICAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"029ca2d07e10c16634f3a8fe73e430fc38bada4f", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"144d35a9e067b57d2958d05a0aeb6c32c0014f6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<CRUDPRACTICAL.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
   
    var employeeLogin = (bool)TempData["Issuccess-Login"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Employee Listing</h4>\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
 if (employeeLogin == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""btn-close"" class=""alert alert-success alert-dismissible fade show"" role=""alert"">
        <strong>Congratulation!</strong> Your Employees has been Login....
        <button type=""button"" id=""btn"" class=""btn-close"" data-bs-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
");
#nullable restore
#line 65 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            $(\"#btn\").click(function () {\r\n                $(\"#btn-close\").toggle();\r\n            });\r\n        });\r\n\r\n        function PagerClick(index) {\r\n");
                WriteLiteral("            document.getElementById(\"hfPageIndex\").value = index;\r\n            document.forms[0].submit();\r\n        }\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<div style=\"text-align:center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029ca2d07e10c16634f3a8fe73e430fc38bada4f7991", async() => {
                WriteLiteral("<i class=\"far fa-plus-square\"></i>Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029ca2d07e10c16634f3a8fe73e430fc38bada4f9295", async() => {
                WriteLiteral("\r\n    <p>\r\n        <input type=\"search\" placeholder=\"Enter Fullname or Position...\"");
                BeginWriteAttribute("value", " value=\"", 2802, "\"", 2841, 1);
#nullable restore
#line 91 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
WriteAttributeValue("", 2810, ViewData["Getemployeedetails"], 2810, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Empsearch"" style=""width:500px;"" />
        <input type=""submit"" value=""Search"" class=""btn btn-primary"" />
    </p>


    <table class=""table table-hover"" border=""1"">
        <thead>
            <tr>
                <th>
                    ");
#nullable restore
#line 100 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 103 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().EmpCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 106 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Position));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 109 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().OfficeLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 112 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 115 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.First().Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n");
                WriteLiteral("                <th>\r\n                    Action\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n            \r\n");
#nullable restore
#line 128 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 132 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 135 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EmpCode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 138 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 141 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OfficeLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 144 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 147 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n");
                WriteLiteral("                    <td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029ca2d07e10c16634f3a8fe73e430fc38bada4f14972", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                                                                    WriteLiteral(item.EmployeeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "029ca2d07e10c16634f3a8fe73e430fc38bada4f17363", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 154 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                                                                        WriteLiteral(item.EmployeeId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 157 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n    <input type=\"hidden\" id=\"hfPageIndex\" name=\"currentPageIndex\" />\r\n\r\n    <table cellpadding=\"5\" cellspacing=\"10\" border=\"1\">\r\n        <tr>\r\n");
#nullable restore
#line 167 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
             for (int i = 1; i <= Model.PageCount; i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td>\r\n");
#nullable restore
#line 170 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                     if (i != Model.PageIndex)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 5693, "\"", 5728, 3);
                WriteAttributeValue("", 5700, "javascript:PagerClick(\'", 5700, 23, true);
#nullable restore
#line 172 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
WriteAttributeValue("", 5723, i, 5723, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5725, "\');", 5725, 3, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 172 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                                                          Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 173 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span>");
#nullable restore
#line 176 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                         Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 177 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </td>\r\n");
#nullable restore
#line 179 "D:\Dhanraj\MVC\MVCCRUD\CRUDPRACTICAL\CRUDPRACTICAL\Views\Login\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tr>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<CRUDPRACTICAL.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
