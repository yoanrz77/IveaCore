#pragma checksum "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b2d19827807ef90b85c3d51d5b18963bed19c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FarmSamplings_FarmSamplingsPDF), @"mvc.1.0.view", @"/Views/FarmSamplings/FarmSamplingsPDF.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37b2d19827807ef90b85c3d51d5b18963bed19c8", @"/Views/FarmSamplings/FarmSamplingsPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"360832cdf613724c4b656b6fb1e35b00caa77fa5", @"/Views/_ViewImports.cshtml")]
    public class Views_FarmSamplings_FarmSamplingsPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IVEACore.Models.FarmSampling>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
  
    ViewData["Title"] = "Report";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Report Farm Sampling</h1>\r\n\r\n<table id=\"farmSampling\" class=\"table\">\r\n");
            WriteLiteral("    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td align=\"left\" style=\"width:900px\">\r\n                    <b>");
#nullable restore
#line 21 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                  Write(Html.DisplayNameFor(model => model.Id_Farm));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</b> ");
#nullable restore
#line 21 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.Id_Farm));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>");
#nullable restore
#line 22 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                  Write(Html.DisplayNameFor(model => model.DateSampling));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</b> ");
#nullable restore
#line 22 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.DateSampling));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>");
#nullable restore
#line 23 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                  Write(Html.DisplayNameFor(model => model.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</b> ");
#nullable restore
#line 23 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <hr />\r\n                    <b>Description CFV:</b> ");
#nullable restore
#line 25 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_CFV));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value CFV:</b> ");
#nullable restore
#line 26 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_CFV));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                   \r\n                    <b>Description DAS:</b> ");
#nullable restore
#line 28 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_DAS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value DAS:</b> ");
#nullable restore
#line 29 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_DAS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                   \r\n                    <b>Description DFS:</b> ");
#nullable restore
#line 31 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_DFS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value DFS:</b> ");
#nullable restore
#line 32 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_DFS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                  \r\n                    <b>Description MPE:</b> ");
#nullable restore
#line 34 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_MPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value MPE:</b> ");
#nullable restore
#line 35 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_MPE));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    \r\n                    <b>Description NCS:</b> ");
#nullable restore
#line 37 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_NCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value NCS:</b> ");
#nullable restore
#line 38 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_NCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    \r\n                    <b>Description NES:</b> ");
#nullable restore
#line 40 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_NES));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value NES:</b> ");
#nullable restore
#line 41 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_NES));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    \r\n                    <b>Description NRS:</b> ");
#nullable restore
#line 43 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_NRS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value NRS:</b> ");
#nullable restore
#line 44 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_NRS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                   \r\n                    <b>Description PES:</b> ");
#nullable restore
#line 46 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_PES));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value PES:</b> ");
#nullable restore
#line 47 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_PES));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                  \r\n                    <b>Description RCES:</b> ");
#nullable restore
#line 49 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Description_RCES));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value_RCES:</b> ");
#nullable restore
#line 50 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Value_RCES));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                   \r\n                    <b>Description RCS:</b> ");
#nullable restore
#line 52 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_RCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value RCS:</b> ");
#nullable restore
#line 53 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_RCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                 \r\n                    <b>Description RES:</b> ");
#nullable restore
#line 55 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_RES));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value RES:</b> ");
#nullable restore
#line 56 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_RES));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                \r\n                    <b>Description VBS:</b> ");
#nullable restore
#line 58 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Description_VBS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value_VBS:</b> ");
#nullable restore
#line 59 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.Value_VBS));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                   \r\n                    <b>Description AF:</b> ");
#nullable restore
#line 61 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Description_AF));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value AF:</b> ");
#nullable restore
#line 62 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                Write(Html.DisplayFor(modelItem => item.Value_AF));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                  \r\n                    <b>Animals Amount:</b> ");
#nullable restore
#line 64 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Description_AF));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <b>Value Animals Amount:</b>");
#nullable restore
#line 65 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AnimalsAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    <hr Color=\"Blue\" />\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37b2d19827807ef90b85c3d51d5b18963bed19c816486", async() => {
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
#line 67 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                           WriteLiteral(item.Id_FamSampling);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37b2d19827807ef90b85c3d51d5b18963bed19c818673", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                              WriteLiteral(item.Id_FamSampling);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37b2d19827807ef90b85c3d51d5b18963bed19c820866", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
                                             WriteLiteral(item.Id_FamSampling);

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
#line 72 "C:\Users\yoanr\source\repos\IVEACore\Views\FarmSamplings\FarmSamplingsPDF.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IVEACore.Models.FarmSampling>> Html { get; private set; }
    }
}
#pragma warning restore 1591
