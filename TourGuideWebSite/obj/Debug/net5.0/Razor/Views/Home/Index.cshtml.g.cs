#pragma checksum "C:\Users\Volod\source\repos\ExcursionSite\TourGuideWebSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32a0e8b71f6b708040f114071a0dd1a04d4f9bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Volod\source\repos\ExcursionSite\TourGuideWebSite\Views\_ViewImports.cshtml"
using TourGuideWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Volod\source\repos\ExcursionSite\TourGuideWebSite\Views\_ViewImports.cshtml"
using TourGuideWebSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32a0e8b71f6b708040f114071a0dd1a04d4f9bf1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6b1647f7ae7acc2348c57ac3cdb9fb6c90f3290", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Volod\source\repos\ExcursionSite\TourGuideWebSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css"" type=""text/css"" rel=""stylesheet"" />
<link href=""https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.1.0/fullcalendar.min.css"" rel=""stylesheet"" />
<div id=""calendar""></div>

<div id=""myModal"" class=""modal"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
              
                <h4 class=""modal-title""><span id=""eventTitle""></span></h4>
            </div>
            <div class=""modal-body"">
                <p id=""pDetails""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.17.1/moment.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.1.0/fullcalendar.min.js""></script>
    <script href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""></script>
    <script>
        $(document).ready(function () {
            var events = [];
            $.ajax({
                type: ""GET"",
                url: ""Home/GetEvents"",
                success: function (data) {
                    $.each(data, function (i, v) {
                        events.push({
                            title: v.title,
                            href: v.href,
                            start: moment(v.startDate),
                            end: moment(v.endDate),
                            color: v.color
                        });
                    })

                    GenerateCalender(events);
                },
                error: function (error) ");
                WriteLiteral(@"{
                    alert(error.catch);
                }
            })
            function GenerateCalender(events) {
                $('#calendar').fullCalendar('destroy');
                $('#calendar').fullCalendar({
                    contentHeight: 400,
                    timeFormat: 'h(:mm)a',
                    displayEventTime: false,
                    header: {
                        left: 'prev,next today',
                        center: 'title',
                        right: 'month,basicWeek,agenda'
                    },
                    eventLimit: true,
                    eventColor: '#378006',
                    events: events,
                    eventClick:
                        function (calEvent, jsEvent, view) {
                            $('#myModal #eventTitle').text(calEvent.title);
                            var $description = $('<div/>');
                            $description.append($('<p/>').html('<b>Початок:</b>' + calEvent.start.format");
                WriteLiteral(@"(""DD-MM-YYYY HH:mm"")));
                            if (calEvent.end != null) {
                                $description.append($('<p/>').html('<b>Кінець:</b>' + calEvent.end.format(""DD-MM-YYYY HH:mm"")));
                            }
                            $description.append($('<p/>').html('<a href=""' + calEvent.href + '"">Посилання на сторінку</a>'));
                            $('#myModal #pDetails').empty().html($description);
                            $('#myModal').modal();
                        }
                })
            }
        })
    </script>
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
