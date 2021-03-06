#pragma checksum "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7868aea4985f13139c9c1f45391d1c5e14206b55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Bookmark), @"mvc.1.0.view", @"/Views/Course/Bookmark.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Course/Bookmark.cshtml", typeof(AspNetCore.Views_Course_Bookmark))]
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
#line 1 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\_ViewImports.cshtml"
using code_tutorial.Models;

#line default
#line hidden
#line 2 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\_ViewImports.cshtml"
using code_tutorial.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7868aea4985f13139c9c1f45391d1c5e14206b55", @"/Views/Course/Bookmark.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd42274eb3f2d4212cb943c1eac67834f15fac91", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Bookmark : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Subject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-control", "Bookmark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
   ViewData["Title"] = "Yaddaşda saxlanılmış kurslar"; 

#line default
#line hidden
            BeginContext(89, 183, true);
            WriteLiteral("\r\n<section id=\"bookmark\" class=\"section-padding\">\r\n    <div class=\"container\">\r\n        <div class=\"row justify-content-center\">\r\n            <div class=\"col-lg-8 col-md-10 col-12\">\r\n");
            EndContext();
#line 9 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
            BeginContext(333, 68, true);
            WriteLiteral("                    <h2>Yaddaşda saxlanılmış kursunuz yoxdur.</h2>\r\n");
            EndContext();
#line 12 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(461, 846, true);
            WriteLiteral(@"                    <table class=""course_table"">
                        <thead>
                            <tr>
                                <th>
                                    <label class=""checkbox"">
                                        <input class=""checkbox_input select_all"" type=""checkbox"" name=""mycheckboxName"" id=""mycheckboxId"">
                                        <span class=""checkbox_box""></span>
                                    </label>
                                </th>
                                <th>

                                    <button type=""submit"" id=""removeSelected"" class=""btn remove_selected"">Seçilmiş kursları siyahıdan sil</button>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 31 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                             foreach (Subject subject in Model)
                            {

#line default
#line hidden
            BeginContext(1403, 45, true);
            WriteLiteral("                                <tr data-id=\"");
            EndContext();
            BeginContext(1449, 10, false);
#line 33 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                                        Write(subject.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1459, 521, true);
            WriteLiteral(@""" class=""saved_courses"">
                                    <td>
                                        <label class=""checkbox"">
                                            <input class=""checkbox_input"" type=""checkbox"" name=""mycheckboxName"" id=""mycheckboxId"">
                                            <span class=""checkbox_box""></span>
                                        </label>
                                    </td>
                                    <td>
                                        ");
            EndContext();
            BeginContext(1980, 393, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64a13892d2794bdf9dd9349daa14e451", async() => {
                BeginContext(2055, 126, true);
                WriteLiteral("\r\n                                            <div class=\"saved_course\">\r\n                                                <h3>");
                EndContext();
                BeginContext(2182, 12, false);
#line 43 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                                               Write(subject.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2194, 58, true);
                WriteLiteral("</h3>\r\n                                                <p>");
                EndContext();
                BeginContext(2253, 18, false);
#line 44 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                                              Write(subject.Definition);

#line default
#line hidden
                EndContext();
                BeginContext(2271, 98, true);
                WriteLiteral("</p>\r\n                                            </div>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                                                                                          WriteLiteral(subject.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2373, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2500, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b2a55bb12c041e08ad734ed3f8d5409", async() => {
                BeginContext(2615, 31, true);
                WriteLiteral("<i class=\"fas fa-bookmark\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                                                                                                     WriteLiteral(subject.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-control", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["control"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2650, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                            }

#line default
#line hidden
            BeginContext(2765, 64, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
            EndContext();
#line 55 "C:\Users\Kanan\Desktop\final_project\code_tutorial\Views\Course\Bookmark.cshtml"
                }

#line default
#line hidden
            BeginContext(2848, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2929, 3484, true);
                WriteLiteral(@"
    <script>
        $('#removeSelected').click(function () {
            let selected = $('.selected_course')
            let data = []

            selected.each(function () {
                data.push($(this).data('id'))
            })


            if (data.length > 0) {
                $.ajax({
                    method: 'GET',
                    url: '/Course/RemoveSelected',
                    data: { 'data': JSON.stringify(data) },
                    contentType: ""application/json; charset=utf-8"",
                    cache: false,
                    success: function () {
                        location.reload();
                    }
                })
            }



        })

        let checkboxes = document.querySelectorAll("".checkbox_input"")
        let selectAll = document.querySelector("".select_all"")

        window.onload = function () {
            for (var i = 0; i < checkboxes.length; ++i) {
                checkboxes[i].checked = false;
        ");
                WriteLiteral(@"    }
        }
        for (var i = 0; i < checkboxes.length; ++i) {
            checkboxes[i].onclick = function () {
                if (this.checked && this.className != ""checkbox_input select_all"") {
                    this.parentElement.parentElement.parentElement.classList.add(""selected_course"")
                }
                else {
                    this.parentElement.parentElement.parentElement.classList.remove(""selected_course"")
                }

                if (document.querySelectorAll("".selected_course"").length == checkboxes.length - 1) {
                    selectAll.checked = true;
                }
                else {
                    selectAll.checked = false;
                }
                if (document.querySelectorAll("".selected_course"").length > 0) {
                    document.querySelector("".remove_selected"").style.display = ""block""
                }
                else {
                    document.querySelector("".remove_selected"").style.displ");
                WriteLiteral(@"ay = ""none""
                }
            }
        }

        selectAll.onclick = function () {
            if (this.checked) {
                for (var i = 0; i < checkboxes.length; ++i) {
                    if (checkboxes[i].className != ""checkbox_input select_all"" && checkboxes[i].parentElement.parentElement.parentElement.className != (""saved_courses selected_course"")) {
                        checkboxes[i].checked = true
                        checkboxes[i].parentElement.parentElement.parentElement.classList.add(""selected_course"")
                    }
                }
            }
            else {
                for (var i = 0; i < checkboxes.length; ++i) {
                    if (checkboxes[i].className != ""checkbox_input select_all"" && checkboxes[i].parentElement.parentElement.parentElement.className == (""saved_courses selected_course"")) {
                        checkboxes[i].checked = false
                        checkboxes[i].parentElement.parentElement.parentElement.clas");
                WriteLiteral(@"sList.remove(""selected_course"")
                    }
                }
            }
            if (document.querySelectorAll("".selected_course"").length > 0) {
                document.querySelector("".remove_selected"").style.display = ""block""
            }
            else {
                document.querySelector("".remove_selected"").style.display = ""none""
            }

        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Subject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
