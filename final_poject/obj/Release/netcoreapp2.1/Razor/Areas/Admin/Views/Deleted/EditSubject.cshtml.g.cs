#pragma checksum "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ea6455a47c8ec41a7ab978e92054b6825703068"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Deleted_EditSubject), @"mvc.1.0.view", @"/Areas/Admin/Views/Deleted/EditSubject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Deleted/EditSubject.cshtml", typeof(AspNetCore.Areas_Admin_Views_Deleted_EditSubject))]
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
#line 1 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\_ViewImports.cshtml"
using final_poject.Models;

#line default
#line hidden
#line 2 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\_ViewImports.cshtml"
using final_poject.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ea6455a47c8ec41a7ab978e92054b6825703068", @"/Areas/Admin/Views/Deleted/EditSubject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a023bc38249f464093c9bb251a195d5e384ae0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Deleted_EditSubject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditedSubjectVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Subject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success waves-effect waves-light m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Deleted", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActivateSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success waves-effect waves-light m-1 activate_subject"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Məzmun"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/plugins/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 253, true);
            WriteLiteral("<div class=\"container-fluid\">\n    <div class=\"row pt-2 pb-2\">\n        <div class=\"col-sm-6\">\n            <h4 class=\"page-title\">Məqalə</h4>\n        </div>\n        <div class=\"col-sm-6\">\n            <div class=\"btn-group float-sm-right\">\n                ");
            EndContext();
            BeginContext(276, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a0666eb1c74d96982f054f13a6ad8e", async() => {
                BeginContext(436, 12, true);
                WriteLiteral("Geriyə qayıt");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                                                    WriteLiteral(Model.Subject.Course.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(452, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(469, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b39e86d2ec497285b86f28875cd13d", async() => {
                BeginContext(646, 8, true);
                WriteLiteral("Aktiv et");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                                                           WriteLiteral(Model.Subject.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(658, 183, true);
            WriteLiteral("\n                <button class=\"btn btn-warning waves-effect waves-light m-1\" id=\"edit\">Bu mövzuya dəyişiklik et</button>\n            </div>\n        </div>\n    </div>\n    <hr />\n\n    ");
            EndContext();
            BeginContext(841, 4341, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29977e9323cf4b31aa2ba93c266721d1", async() => {
                BeginContext(861, 520, true);
                WriteLiteral(@"

        <div class=""row mt-4"">
            <div class=""col-12 col-md-6"">
                <div class=""card"">
                    <div class=""card-header text-uppercase"">Mövzunun adı</div>
                    <div class=""card-body"">
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fa fa-spinner fa-spin""></i></i></span>
                            </div>
                            ");
                EndContext();
                BeginContext(1381, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d5123fce905d4fc1b97817a2fed9cb61", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 28 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Subject.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1465, 594, true);
                WriteLiteral(@"
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-6"">
                <div class=""card"">
                    <div class=""card-header text-uppercase"">Mövzunun qısa məzmunu</div>
                    <div class=""card-body"">
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fa fa-spinner fa-spin""></i></span>
                            </div>
                            ");
                EndContext();
                BeginContext(2059, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6af9517cf9814c80b65e8d6d8a1c3618", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#line 42 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Subject.Definition);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2153, 480, true);
                WriteLiteral(@"
                        </div>

                    </div>
                </div>
            </div>
            <div class=""col-12 col-md-6"">
                <div class=""card"">
                    <div class=""card-header text-uppercase"">Aid olduğu kurs</div>
                    <div class=""card-body"">
                        <div class=""input-group"">
                            <select style=""width:50%;color:black"" id=""course"" name=""course"">
                                ");
                EndContext();
                BeginContext(2633, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f68cea1f505f48a9a3f9c29197783d80", async() => {
                    BeginContext(2675, 25, false);
#line 54 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                                                    Write(Model.Subject.Course.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 54 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                   WriteLiteral(Model.Subject.Course.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2709, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 55 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                 foreach (Course course in Model.Courses)
                                {
                                    if (course.Id != Model.Subject.Course.Id)
                                    {

#line default
#line hidden
                BeginContext(2934, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(2954, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92378c174ab54679b1e99a28cc9a91b5", async() => {
                    BeginContext(2982, 11, false);
#line 59 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                          Write(course.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                       WriteLiteral(course.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
#line 59 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                                                    }
                                }

#line default
#line hidden
                BeginContext(3038, 238, true);
                WriteLiteral("                            </select>\n                        </div>\n                    </div>\n                </div>\n            </div>\n\n        </div>\n        <div class=\"row\">\n            <div class=\"col-12 col-md-8\">\n                ");
                EndContext();
                BeginContext(3276, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9fdfb494ed84ffb99081c66d939b48f", async() => {
                    BeginContext(3353, 21, false);
#line 70 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                                                                       Write(Model.Article.Content);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 70 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Article.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3385, 642, true);
                WriteLiteral(@"
            </div>
            <div class=""col-md-4 col-12"">
                <div class=""table-responsive"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th scope=""col"">#</th>
                                <th scope=""col"">Məqaləni yazan</th>
                                <th scope=""col"">Yazılma tarixi</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <th scope=""row"">1</th>
                                <td>");
                EndContext();
                BeginContext(4028, 27, false);
#line 85 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                               Write(Model.Article.User.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(4055, 42, true);
                WriteLiteral("</td>\n                                <td>");
                EndContext();
                BeginContext(4098, 28, false);
#line 86 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                               Write(Model.Article.PublishingDate);

#line default
#line hidden
                EndContext();
                BeginContext(4126, 73, true);
                WriteLiteral("</td>\n                            </tr>\n                        </tbody>\n");
                EndContext();
#line 89 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                         if (Model.EditedSubjects.Count() != 0)
                        {

#line default
#line hidden
                BeginContext(4289, 281, true);
                WriteLiteral(@"            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Dəyişiklik edənlər</th>
                    <th scope=""col"">Dəyişilmə tarixi</th>
                </tr>
            </thead>
                            <tbody>
");
                EndContext();
#line 99 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                 foreach (EditedSubject editedSubject in Model.EditedSubjects)
                                {

#line default
#line hidden
                BeginContext(4699, 88, true);
                WriteLiteral("                <tr>\n                    <th scope=\"row\">1</th>\n                    <td>");
                EndContext();
                BeginContext(4788, 27, false);
#line 103 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                   Write(editedSubject.User.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(4815, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(4846, 24, false);
#line 104 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                   Write(editedSubject.EditedDate);

#line default
#line hidden
                EndContext();
                BeginContext(4870, 27, true);
                WriteLiteral("</td>\n                </tr>");
                EndContext();
#line 105 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                     }

#line default
#line hidden
                BeginContext(4899, 36, true);
                WriteLiteral("                            </tbody>");
                EndContext();
#line 106 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\EditSubject.cshtml"
                                    }

#line default
#line hidden
                BeginContext(4937, 238, true);
                WriteLiteral("                    </table>\n                </div>\n            </div>\n        </div>\n        <button id=\"save\" style=\"display:none;margin-top:25px\" class=\"btn btn-success waves-effect waves-light\">Dəyişiklikləri yadda saxla</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5182, 9, true);
            WriteLiteral("\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5208, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(5213, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27c0409307f04c24b9795b42c9d89cae", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5273, 1227, true);
                WriteLiteral(@"
    <script>$('#course').select2();
        let inputs = document.querySelectorAll(""input"")
        for (let i = 0; i < inputs.length; ++i) {
            inputs[i].disabled = true;
        }

        document.querySelector(""#edit"").onclick = function () {
            for (let i = 0; i < inputs.length; ++i) {
                inputs[i].disabled = false;
            }
            document.querySelector(""#save"").style.display = ""block""
        }
        CKEDITOR.replace('editor');

        $("".activate_subject"").click(function (e) {
            e.preventDefault();
            swal({
                title: ""Əminsiniz?"",
                text: ""Aktiv etmək istədiyinizə əminsinizmi?"",
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
            })
                .then((willDelete) => {
                    if (willDelete && $(this).val() != ""1"") {
                        swal(""Aktiv olundu"", {
                            icon: ""success"",
                        });
  ");
                WriteLiteral("                      location.href = $(this).attr(\'href\')\n                    } else {\n                        swal(\"Aktiv olunmadı\");\n                    }\n                });\n        })\n    </script>\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditedSubjectVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
