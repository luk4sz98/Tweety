#pragma checksum "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4817453aef03f93200e933c9b13f1d4c5829843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ranks_Index), @"mvc.1.0.view", @"/Views/Ranks/Index.cshtml")]
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
#line 1 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\_ViewImports.cshtml"
using Tweets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\_ViewImports.cshtml"
using Tweets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4817453aef03f93200e933c9b13f1d4c5829843", @"/Views/Ranks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba809345108d2f04423390e21a92b0bf30bea86a", @"/Views/_ViewImports.cshtml")]
    public class Views_Ranks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Tweets.Models.Smartphone>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SmartphoneTableDataPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm col-1 btn-dark text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ranks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-_pageSize", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-_pageSize", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-_pageSize", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ranks.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
  
    ViewData["Title"] = "Ranks";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <h1 class=""text-center text-light mt-3"">
        TOP 20 smartfonów na androida
    </h1>
</div>
<div class=""row my-4"">

    <div class=""dropdown col-4 col-md-2 col-lg-1 me-lg-3"">
        <button class=""btn btn-dark dropdown-toggle "" type=""button"" id=""dropdownMenuButton""
                data-bs-toggle=""dropdown"" aria-expanded=""false"">
            Filtruj po
        </button>
        <ul class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
            <li>
                <button id=""deviceName"" class=""btn dropdown-item"">nazwie urządzenia</button>
            </li>
            <li class=""dropdown-divider d-none d-md-block""></li>
            <li>
                <button id=""screenSize"" class=""btn dropdown-item d-none d-md-block"">
                    wielkości ekranu
                </button>
            </li>
        </ul>
    </div>
    <div id=""inputField"" class=""col-8 col-md-10 col-lg-3 ms-lg-3"">
        <input id=""filtruj"" type=""text"" class=""smartphones");
            WriteLiteral(@"-filter-input form-control"" placeholder=""Wprowadź frazę...""
               onfocus=""this.value=''"">
    </div>
</div>
<div class=""row"">
    <div id=""option"">

        <input type=""radio"" class=""btn-check btn-sm"" name=""options"" id=""lessThan"" autocomplete=""off""
               checked>
        <label class=""btn btn-sm btn-dark"" for=""lessThan"">mniejszy niż</label>

        <input type=""radio"" class=""btn-check btn-sm mx-2"" name=""options"" id=""equal"" autocomplete=""off""
               checked>
        <label class=""btn btn-sm btn-dark mx-2"" for=""equal"">równe</label>
        <input type=""radio"" class=""btn-check btn-sm"" name=""options"" id=""moreThan"" autocomplete=""off""
               checked>
        <label class=""btn btn-sm btn-dark"" for=""moreThan"">większy niż</label>

    </div>
    <div class=""row my-4"">
        <div class=""col-lg-12 col-md-12 col-sm-12"">
            <table id=""tabela"" class=""table table-striped table-hover text-white align-middle"">
                <thead>
                    <t");
            WriteLiteral(@"r>
                        <th class=""col-1"" data-field=""rank"">
                            Ranking
                        </th>
                        <th class=""col-2"" data-field=""device"">
                            Urządzenie
                        </th>
                        <th class=""col-1"" data-field=""performance"">
                            Moc
                        </th>
                        <th class=""col-1 d-none d-md-table-cell"" data-field=""screen"">
                            Ekran
                        </th>
                        <th class=""col-4 d-none d-md-table-cell"" data-field=""hardware"">
                            Specyfikacja
                        </th>
                        <th class=""col-1 d-none d-md-table-cell text-center"" data-field=""popularity"">
                            Popularność
                        </th>
                    </tr>
                </thead>
                <tbody class=""smartphones-table-data"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4817453aef03f93200e933c9b13f1d4c58298439743", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 77 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n            <div class=\"row\">\r\n                <nav aria-label=\"Page navigation \">\r\n                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 83 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
                          
                            int position;
                            int pageCurrent = ViewBag.pageCurrent;
                            float numSize = ViewBag.numSize;
                            if (pageCurrent > 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a aria-label=\"Previosu\" class=\"page-link \" id=\"pageIndexer\"");
            BeginWriteAttribute("href", " href=\"", 3831, "\"", 3926, 1);
#nullable restore
#line 90 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
WriteAttributeValue("", 3838, Url.Action("Index", "Ranks", new {page = pageCurrent-1, _pageSize = ViewBag.pageSize }), 3838, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabRanks=\"-1\">\r\n                                        <span aria-hidden=\"true\">&#10094;</span>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 94 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
                            }
                            for (position = 1; position <= numSize; position++)
                            {
                                if (position == pageCurrent)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4432, "\"", 4525, 1);
#nullable restore
#line 99 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
WriteAttributeValue("", 4439, Url.Action("Index", "Ranks" , new {  page = position, _pageSize = ViewBag.pageSize }), 4439, 86, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 99 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
                                                                                                                                                                               Write(position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 100 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4733, "\"", 4824, 1);
#nullable restore
#line 103 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
WriteAttributeValue("", 4740, Url.Action("Index", "Ranks", new { page = position, _pageSize = ViewBag.pageSize }), 4740, 84, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 103 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
                                                                                                                                                                      Write(position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 104 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
                                }
                            }
                            if (pageCurrent > 0 && pageCurrent < numSize)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"page-item\">\r\n                                    <a aria-label=\"Next\" class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5148, "\"", 5243, 1);
#nullable restore
#line 109 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
WriteAttributeValue("", 5155, Url.Action("Index", "Ranks", new {page = pageCurrent+1, _pageSize = ViewBag.pageSize }), 5155, 88, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabRanks=\"-1\">\r\n                                        <span aria-hidden=\"true\">&#10095;</span>\r\n                                    </a>\r\n                                </li>\r\n");
#nullable restore
#line 113 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Ranks\Index.cshtml"
                            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </nav>\r\n            </div>\r\n            <div class=\"row\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4817453aef03f93200e933c9b13f1d4c582984316701", async() => {
                WriteLiteral("\r\n                        5\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-_pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["_pageSize"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4817453aef03f93200e933c9b13f1d4c582984318737", async() => {
                WriteLiteral("\r\n                        10\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-_pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["_pageSize"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4817453aef03f93200e933c9b13f1d4c582984320774", async() => {
                WriteLiteral("\r\n                        20\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-_pageSize", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["_pageSize"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                \r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4817453aef03f93200e933c9b13f1d4c582984322980", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Tweets.Models.Smartphone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
