#pragma checksum "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd58fe4be8957068fd0b2b284a913b4a6e22eb18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
#line 1 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\_ViewImports.cshtml"
using PhysicalCustomers.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\_ViewImports.cshtml"
using PhysicalCustomers.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
using PhysicalCustomers.Domain.AggregatesModel.CustomerAggregate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd58fe4be8957068fd0b2b284a913b4a6e22eb18", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec6530cbb0248dbd8af9fdf64655aefb02792a3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<PhysicalCustomers.Application.Customers.CustomerViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Customers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>All Customers</h3>\r\n<hr />\r\n<fieldset>\r\n    <h2>Search</h2>\r\n");
#nullable restore
#line 17 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            Please Enter First Name, Last Name or Personal Id\r\n            <input type=\"text\" name=\"keyword\"");
            BeginWriteAttribute("value", " value=\"", 550, "\"", 574, 1);
#nullable restore
#line 21 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 558, ViewBag.keyword, 558, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </p>\r\n");
#nullable restore
#line 23 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input class=\"btn btn-outline-primary\" id=\"detailedSearch\" type=\"button\" name=\"name\" value=\"Detailed Search\" />\r\n    <div id=\"detailed-Search-Form\">\r\n");
#nullable restore
#line 26 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <label>First Name</label>\r\n                <input type=\"text\" name=\"firstName\"");
            BeginWriteAttribute("value", " value=\"", 914, "\"", 940, 1);
#nullable restore
#line 30 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 922, ViewBag.firstName, 922, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <label>Last Name</label>\r\n                <input type=\"text\" name=\"lastName\"");
            BeginWriteAttribute("value", " value=\"", 1077, "\"", 1102, 1);
#nullable restore
#line 34 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1085, ViewBag.lastName, 1085, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <label>Personal Id</label>\r\n                <input type=\"text\" name=\"personalId\"");
            BeginWriteAttribute("value", " value=\"", 1243, "\"", 1270, 1);
#nullable restore
#line 38 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1251, ViewBag.personalId, 1251, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <label>Birth Date</label>\r\n                <input type=\"text\" name=\"birthDate\"");
            BeginWriteAttribute("value", " value=\"", 1409, "\"", 1435, 1);
#nullable restore
#line 42 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1417, ViewBag.birthDate, 1417, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <label>Gender</label>\r\n                <input type=\"text\" name=\"gender\"");
            BeginWriteAttribute("value", " value=\"", 1567, "\"", 1590, 1);
#nullable restore
#line 46 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1575, ViewBag.gender, 1575, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <label>City</label>\r\n                <input type=\"text\" name=\"city\"");
            BeginWriteAttribute("value", " value=\"", 1718, "\"", 1739, 1);
#nullable restore
#line 50 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1726, ViewBag.city, 1726, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <label>Phone Number</label>\r\n                <input type=\"text\" name=\"phone\"");
            BeginWriteAttribute("value", " value=\"", 1876, "\"", 1898, 1);
#nullable restore
#line 54 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 1884, ViewBag.phone, 1884, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <label>Connected Customer</label>\r\n                <input type=\"text\" name=\"connectedCustomer\"");
            BeginWriteAttribute("value", " value=\"", 2053, "\"", 2087, 1);
#nullable restore
#line 58 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 2061, ViewBag.connectedCustomer, 2061, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div>\r\n                <input class=\"btn btn-primary\" type=\"submit\" value=\"Search\" />\r\n            </div>\r\n");
#nullable restore
#line 63 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input class=\"btn btn-secondary\" type=\"button\" value=\"Clear\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2311, "\"", 2370, 3);
            WriteAttributeValue("", 2321, "location.href=\'", 2321, 15, true);
#nullable restore
#line 64 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
WriteAttributeValue("", 2336, Url.Action("Index", "Customers"), 2336, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2369, "\'", 2369, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n</fieldset>\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
           Write(Html.ActionLink("First Name", "Index", new { sort = "FirstName", order = ViewBag.order, pagination = ViewBag.sort, keyword = ViewBag.keyword }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 74 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
           Write(Html.ActionLink("Last Name", "Index", new { sort = "LastName", order = ViewBag.order, pagination = ViewBag.sort, keyword = ViewBag.keyword }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                Gender
            </th>
            <th>
                Personal Id
            </th>
            <th>
                City
            </th>
            <th>
                Birth Date
            </th>
            <th>
                Graphical Data
            </th>
            <th>
                Actions
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 97 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 101 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 104 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 107 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 110 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PersonalId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 113 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.City.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 116 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd58fe4be8957068fd0b2b284a913b4a6e22eb1817633", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/");
#nullable restore
#line 119 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
                           WriteLiteral(item.GraphicalData);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 122 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd58fe4be8957068fd0b2b284a913b4a6e22eb1820338", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
                                           WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd58fe4be8957068fd0b2b284a913b4a6e22eb1822524", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
                                              WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd58fe4be8957068fd0b2b284a913b4a6e22eb1824714", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
                                             WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 130 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\"pagedList\">\r\n    ");
#nullable restore
#line 135 "C:\Users\vania\Desktop\ApiTask\WebApiTask\PhysicalCustomers\Views\Customers\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index",
    new
         {
             page,
             sort = ViewBag.sort,
             order = ViewBag.order,
        pagination = ViewBag.sort,
             keyword = ViewBag.keyword
         }), PagedListRenderOptions.ClassicPlusFirstAndLast));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<hr />\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd58fe4be8957068fd0b2b284a913b4a6e22eb1827756", async() => {
                WriteLiteral("Add new Customer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\"#detailed-Search-Form\").attr(\"hidden\", true);\r\n        $(\"#detailedSearch\").click(function () {\r\n            $(\"#detailed-Search-Form\").attr(\"hidden\", false);\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<PhysicalCustomers.Application.Customers.CustomerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
