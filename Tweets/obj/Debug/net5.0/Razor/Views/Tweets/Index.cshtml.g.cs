#pragma checksum "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "256684ae4aa4686f45bbdb88b7eaa7972427bff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tweets_Index), @"mvc.1.0.view", @"/Views/Tweets/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"256684ae4aa4686f45bbdb88b7eaa7972427bff8", @"/Views/Tweets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba809345108d2f04423390e21a92b0bf30bea86a", @"/Views/_ViewImports.cshtml")]
    public class Views_Tweets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Previosu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pageIndexer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tweets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabRanks", new global::Microsoft.AspNetCore.Html.HtmlString("-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ranks.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
  
    ViewData["Title"] = "Ranks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
     using (Html.BeginForm("SearchTweets", "Button"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input class=\"mt-2\" type=\"text\" name=\"inputValue\" placeholder=\"Wpisz\" />\r\n        <button type=\"submit\" class=\"btn bg-dark text-light\">Szukaj</button>\r\n");
#nullable restore
#line 12 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 15 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
 if (ViewBag.tweets != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
         foreach (var tweet in ViewBag.tweets)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card my-2\">\r\n                <div class=\"card-body\">\r\n                    <blockquote class=\"blockquote mb-0\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 24 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                       Write(tweet.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                             if (tweet.HyperLink.Count > 0)
                            {
                                foreach (var hyperLink in tweet.HyperLink)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 867, "\"", 884, 1);
#nullable restore
#line 29 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
WriteAttributeValue("", 874, hyperLink, 874, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 29 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                                                                    Write(hyperLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 30 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <footer class=\"blockquote-footer\">\r\n                            ");
#nullable restore
#line 35 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                       Write(tweet.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 35 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                                        Write(tweet.Created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </footer>\r\n                    </blockquote>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 40 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"row\">\r\n        <nav aria-label=\"Page navigation \">\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 46 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                  
                    int position;
                    int pageCurrent = ViewBag.pageCurrent;
                    float numSize = ViewBag.numSize;
                    if (pageCurrent > 1)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "256684ae4aa4686f45bbdb88b7eaa7972427bff810582", async() => {
                WriteLiteral("\r\n                                <span aria-hidden=\"true\">&#10094;</span>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                                                                                                                                       WriteLiteral(pageCurrent);

#line default
#line hidden
#nullable disable
            WriteLiteral("-1");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 58 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                    }
                    for (position = 1; position <= numSize; position++)
                    {
                        if (position == pageCurrent)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item active\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2286, "\"", 2350, 1);
#nullable restore
#line 63 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
WriteAttributeValue("", 2293, Url.Action("Index", "Tweets" , new {  page = position }), 2293, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 63 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                                                                                                                                          Write(position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 64 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2526, "\"", 2588, 1);
#nullable restore
#line 67 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
WriteAttributeValue("", 2533, Url.Action("Index", "Tweets", new { page = position }), 2533, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 67 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                                                                                                                                 Write(position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 68 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                        }
                    }
                    if (pageCurrent > 0 && pageCurrent < numSize)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"page-item\">\r\n                            <a aria-label=\"Next\" class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2864, "\"", 2930, 1);
#nullable restore
#line 73 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
WriteAttributeValue("", 2871, Url.Action("Index", "Tweets", new {page = pageCurrent+1 }), 2871, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabRanks=\"-1\">\r\n                                <span aria-hidden=\"true\">&#10095;</span>\r\n                            </a>\r\n                        </li>\r\n");
#nullable restore
#line 77 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </nav>\r\n    </div>\r\n");
#nullable restore
#line 81 "C:\Users\lukas\Desktop\Tweety\Tweety\Tweets\Views\Tweets\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "256684ae4aa4686f45bbdb88b7eaa7972427bff817395", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <style>\r\n\r\n        ");
                WriteLiteral(@"@keyframes transitionIn {
            from {
                opacity: 0;
                transform: rotateX(-10deg);
            }

            to {
                opacity: 1;
                transform: rotateX(0);
            }
        }

        .card {
            background: rgb(148, 148, 148);
            background: radial-gradient(circle, rgba(148, 148, 148, 1) 20%, rgba(116, 116, 116, 1) 92%);
            border-radius: 2rem;
            animation: transitionIn 0.65s linear;
        }

            .card p {
                background: #262626;
                padding: 10px 30px;
                display: inline-block;
                color: white;
                border-radius: 2rem;
            }

            .card a {
                text-decoration: dashed;
                color: aqua;
            }

            .card footer {
                color: white;
                display: flex;
                justify-content: flex-end;
            }
    </style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
