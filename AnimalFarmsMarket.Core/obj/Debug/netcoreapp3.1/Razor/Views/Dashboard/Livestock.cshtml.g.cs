#pragma checksum "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84782cfe1e1abef7f5d48d895977346017829b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Livestock), @"mvc.1.0.view", @"/Views/Dashboard/Livestock.cshtml")]
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
#line 1 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using AnimalFarmsMarket.Data.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84782cfe1e1abef7f5d48d895977346017829b63", @"/Views/Dashboard/Livestock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b5788d97abd233649efb838f59001af955b690", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Dashboard_Livestock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedResultDto<ShappedListOfLivestock>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("View Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editlivestock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
   int nextPage = Model.PageMetaData.Page + 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
   int prevPage = Model.PageMetaData.Page - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<div class=""container mt-5"">
    <div class=""mb-4 mr-5 "" style=""padding-left:15px;"">
        <h2 class=""brand pl-0"" style=""color:#2078BF; "">Livestock</h2>
    </div>
    <div id=""myLivestock"">
");
#nullable restore
#line 16 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
         if (Model.ResponseData.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"display:flex; justify-content:center;height:50px\">\r\n                <p style=\"margin-left:50px;margin-bottom:7px;font-weight:bold\">NO RECORD FOUND</p>\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 26 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                     foreach (var item in Model.ResponseData)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-12 col-md-6 col-lg-4 mb-2 \">\r\n                            <div class=\"card\" style=\"padding-bottom:0px\">\r\n                                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 1118, "\"", 1135, 1);
#nullable restore
#line 30 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
WriteAttributeValue("", 1124, item.Photo, 1124, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" height=\"250\">\r\n                                <div class=\"card-body\">\r\n                                    <h6 class=\"card-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84782cfe1e1abef7f5d48d895977346017829b638753", async() => {
#nullable restore
#line 32 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                                                                      Write(item.Breed);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\r\n                                    <p>\r\n");
#nullable restore
#line 34 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                         if ((await _authorization.AuthorizeAsync(User, "AdminRolePolicy")).Succeeded)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <small class=\"mr-2\">Agent Name: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84782cfe1e1abef7f5d48d895977346017829b6311594", async() => {
#nullable restore
#line 36 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                                                 WriteLiteral(item.AgentId);

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
            WriteLiteral("</small><br />\r\n");
#nullable restore
#line 37 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <small class=\"mr-2\">Market location: ");
#nullable restore
#line 38 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                                        Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                    </p>

                                    <div class=""row"">
                                        <div class=""col"">
                                            <p class=""btn btn-danger btn-block"">&#8358; ");
#nullable restore
#line 43 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n");
#nullable restore
#line 45 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                         if ((await _authorization.AuthorizeAsync(User, "AgentRolePolicy")).Succeeded)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"col\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84782cfe1e1abef7f5d48d895977346017829b6315658", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n");
#nullable restore
#line 50 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 55 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                    <div class=\"col-12\">\r\n                        <nav aria-label=\"...\">\r\n                            <ul class=\"pagination pagination1\">\r\n");
#nullable restore
#line 63 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                 if (Model.PageMetaData.Page != 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-item\"");
            BeginWriteAttribute("id", " id=\"", 3209, "\"", 3223, 1);
#nullable restore
#line 66 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
WriteAttributeValue("", 3214, prevPage, 3214, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"livestockBtn(this)\" tabindex=\"-1\">Previous</a>\r\n                                    </li>\r\n");
#nullable restore
#line 68 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <li class=\"page-item disabled\">\r\n                                    <a");
            BeginWriteAttribute("id", " id=\"", 3465, "\"", 3494, 1);
#nullable restore
#line 71 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
WriteAttributeValue("", 3470, Model.PageMetaData.Page, 3470, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                                Write(Model.PageMetaData.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </li>\r\n");
#nullable restore
#line 73 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                 for (int i = Model.PageMetaData.Page + 1; i <= Model.PageMetaData.Page + 2; i++)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                     if (i > Model.PageMetaData.TotalPages)
                                    {
                                        break;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-item\"");
            BeginWriteAttribute("id", " id=\"", 4038, "\"", 4045, 1);
#nullable restore
#line 80 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
WriteAttributeValue("", 4043, i, 4043, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"livestockBtn(this)\" tabindex=\"-1\">");
#nullable restore
#line 80 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 82 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                 if (Model.PageMetaData.Page < Model.PageMetaData.TotalPages)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\">\r\n                                        <a class=\"page-item\"");
            BeginWriteAttribute("id", " id=\"", 4426, "\"", 4440, 1);
#nullable restore
#line 86 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
WriteAttributeValue("", 4431, nextPage, 4431, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"livestockBtn(this)\">Next</a>\r\n                                    </li>\r\n");
#nullable restore
#line 88 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item pt-2 ml-3\">\r\n                                    ");
#nullable restore
#line 90 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                               Write(Model.PageMetaData.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral(" of ");
#nullable restore
#line 90 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
                                                           Write(Model.PageMetaData.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n                            </ul>\r\n                        </nav>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 97 "C:\Code\livestock-platform\AnimalFarmsMarket\AnimalFarmsMarket.Core\Views\Dashboard\Livestock.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService _authorization { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> _userManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedResultDto<ShappedListOfLivestock>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
