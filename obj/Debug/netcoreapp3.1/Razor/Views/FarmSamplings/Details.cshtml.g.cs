#pragma checksum "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8107763ced0225596a6bc25dcdb3e4bc0dd5d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FarmSamplings_Details), @"mvc.1.0.view", @"/Views/FarmSamplings/Details.cshtml")]
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
#line 1 "C:\Users\yoanr\source\repos\IVEACore\Views\_ViewImports.cshtml"
using IVEACore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yoanr\source\repos\IVEACore\Views\_ViewImports.cshtml"
using IVEACore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8107763ced0225596a6bc25dcdb3e4bc0dd5d4", @"/Views/FarmSamplings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"360832cdf613724c4b656b6fb1e35b00caa77fa5", @"/Views/_ViewImports.cshtml")]
    public class Views_FarmSamplings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IVEACore.Models.FarmSampling>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>FarmSampling</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id_Farm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id_Farm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateSampling));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateSampling));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_CFV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_CFV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_CFV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_CFV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_DAS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_DAS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_DAS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_DAS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_DFS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_DFS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_DFS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_DFS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_MPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_MPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_MPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_MPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_NCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_NCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_NCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_NCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_NES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_NES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_NES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_NES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_NRS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_NRS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_NRS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_NRS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_PES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_PES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_PES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_PES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_RCES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_RCES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_RCES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_RCES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_RCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_RCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_RCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_RCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_RES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_RES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_RES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_RES));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_VBS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_VBS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_VBS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_VBS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description_AF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description_AF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Value_AF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.Value_AF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AnimalsAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
       Write(Html.DisplayFor(model => model.AnimalsAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8107763ced0225596a6bc25dcdb3e4bc0dd5d423156", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 197 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\Details.cshtml"
                           WriteLiteral(Model.Id_FamSampling);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a8107763ced0225596a6bc25dcdb3e4bc0dd5d425304", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IVEACore.Models.FarmSampling> Html { get; private set; }
    }
}
#pragma warning restore 1591
