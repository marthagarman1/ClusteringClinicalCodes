#pragma checksum "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05dda441f821dcb0d45ac918b2e3f2c28e63c2c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Analytics), @"mvc.1.0.view", @"/Views/Home/Analytics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Analytics.cshtml", typeof(AspNetCore.Views_Home_Analytics))]
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
#line 1 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\_ViewImports.cshtml"
using ClinicalCodeClusteringWebApp;

#line default
#line hidden
#line 2 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\_ViewImports.cshtml"
using ClinicalCodeClusteringWebApp.Models;

#line default
#line hidden
#line 1 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05dda441f821dcb0d45ac918b2e3f2c28e63c2c2", @"/Views/Home/Analytics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37ce3a9d75f0e72a8f146891befa6f0131efc30f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Analytics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClinicalCodeClusteringWebApp.Models.CPTCats>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/clinical_code.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(116, 12, true);
            WriteLiteral("\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(128, 1464, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e958f9a1b6241f29947a9572d14f05b", async() => {
                BeginContext(134, 69, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\"/>\r\n    <title>Chart.js demo</title>\r\n    ");
                EndContext();
                BeginContext(203, 70, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c103bedc9d064373b238fb3c5f88633a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(273, 1312, true);
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/0.2.0/Chart.min.js"" type=""text/javascript""></script>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Scatter Chart</title>


    <link href=""../../assets/styles.css"" rel=""stylesheet""/>
    <link href=""http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"" rel=""stylesheet"">
    <script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js""></script>
    <link rel=""stylesheet""
          href=""http://cdn.datatables.net/1.10.2/css/jquery.dataTables.min.css"">
    <script type=""text/javascript""
            src=""http://cdn.datatables.net/1.10.2/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript""
            src=""http://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js""></script>

    <style>

        #chart {
            background-color: aliceblue;");
                WriteLiteral(@"
            margin: 35px auto;
            max-width: 650px;
        }

        .my-custom-scrollbar {
            height: 200px;
            overflow: auto;
            position: relative;
        }

        .table-wrapper-scroll-y { display: block; }
    
    </style>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1592, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1596, 5983, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16db7d4b79c44a3cb420ed54a439cc10", async() => {
                BeginContext(1602, 102, true);
                WriteLiteral("\r\n\r\n\r\n<h1>Cluster Reports</h1>\r\n<h2>Upload CSV of Claim Data</h2>\r\n\r\n\r\n<div class=\"input-group\">\r\n    ");
                EndContext();
                BeginContext(1704, 266, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7519c6002e644928d0a492491020948", async() => {
                    BeginContext(1811, 152, true);
                    WriteLiteral("\r\n\r\n        <input style=\"background: azure\" type=\"file\" name=\"file\"/>\r\n        <button accept=\".csv\" type=\"submit\">Upload File</button>\r\n        \r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1970, 1602, true);
                WriteLiteral(@"

    <asp:FileUpload ID=""FileUpload1"" runat=""server""/>
    <asp:Button Text=""Upload""  OnClick=""Upload"" runat=""server""/>

</div>


<div id=""chart"">

</div>


<script src=""https://cdn.jsdelivr.net/npm/apexcharts@latest""></script>

<script>
    var options = {
        chart: {
            height: 400,
            type: 'scatter',
            zoom: {
                enabled: true,
                type: 'xy'
            }
        },

        series: [],
        xaxis: {
            tickAmount: 10,
            labels: {
                formatter: function(val) {
                    return parseFloat(val).toFixed(1);
                }
            }
        },
        yaxis: {
            tickAmount: 10,
            labels: {
                formatter: function(val) {
                    return parseFloat(val).toFixed(1);
                }
            }
        },
        legend: {
            show: true
        },
        dataLabels: {
            enabled: false,
    ");
                WriteLiteral(@"        enabledOnSeries: true,
            textAnchor: 'middle',
            offsetX: 0,
            offsetY: 0,
            style: {
                fontSize: '14px',
                fontFamily: 'Helvetica, Arial, sans-serif',
                colors: undefined
            },
            dropShadow: {
                enabled: false,
                top: 1,
                left: 1,
                blur: 1,
                opacity: 0.45
            }
        
        },
        tooltip: {
            enabled: false
        }
    };


    console.log(");
                EndContext();
                BeginContext(3573, 46, false);
#line 134 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
           Write(JsonConvert.SerializeObject(ViewBag.ChartData));

#line default
#line hidden
                EndContext();
                BeginContext(3619, 21, true);
                WriteLiteral(");\r\n\r\n\r\n    d_data = ");
                EndContext();
                BeginContext(3641, 46, false);
#line 137 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
        Write(JsonConvert.SerializeObject(ViewBag.ChartData));

#line default
#line hidden
                EndContext();
                BeginContext(3687, 22, true);
                WriteLiteral(";\r\n\r\n\r\n    d_series = ");
                EndContext();
                BeginContext(3710, 48, false);
#line 140 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
          Write(JsonConvert.SerializeObject(ViewBag.ChartSeries));

#line default
#line hidden
                EndContext();
                BeginContext(3758, 23, true);
                WriteLiteral(";\r\n\r\n\r\n    d_centers = ");
                EndContext();
                BeginContext(3782, 49, false);
#line 143 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
           Write(JsonConvert.SerializeObject(ViewBag.ChartCenters));

#line default
#line hidden
                EndContext();
                BeginContext(3831, 917, true);
                WriteLiteral(@";


    for (var i = 0; i < d_series.length; i ++) {
        if (options.series.length > d_series[i]) {
            options.series[d_series[i]].data.push([d_data[i][0], d_data[i][1], 0.075]);
        } else {
            for (var j = options.series.length; j <= d_series[i]; j++) {
                options.series.push({
                    name: ""Cluster "" + j,
                    data: [
                    ]
                });
            }
            i--;
        }
    }

    

    options.series.push({
        name: ""Center"",
        data: []
    });

    for (i = 0; i < d_centers.length; i++) {
        options.series[options.series.length - 1].data.push([d_centers[i][0], d_centers[i][1], 0.5]);
    }

    console.log(options);


    var chart = new ApexCharts(
        document.querySelector(""#chart""),
        options
    );

    chart.render();

</script>


");
                EndContext();
#line 185 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
 if (ViewBag.ChartSeries != null && Model != null)

{

#line default
#line hidden
                BeginContext(4805, 248, true);
                WriteLiteral("    <div class=\"table-wrapper-scroll-y my-custom-scrollbar\">\r\n\r\n        <table class=\"table table-bordered table-striped mb-0\" style=\"background-color: aliceblue\">\r\n\r\n            <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(5054, 43, false);
#line 195 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
               Write(Html.DisplayNameFor(model => model.ClaimId));

#line default
#line hidden
                EndContext();
                BeginContext(5097, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(5165, 45, false);
#line 198 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
               Write(Html.DisplayNameFor(model => model.DrugAssay));

#line default
#line hidden
                EndContext();
                BeginContext(5210, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(5278, 48, false);
#line 201 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
               Write(Html.DisplayNameFor(model => model.Microbiology));

#line default
#line hidden
                EndContext();
                BeginContext(5326, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(5394, 45, false);
#line 204 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
               Write(Html.DisplayNameFor(model => model.Chemistry));

#line default
#line hidden
                EndContext();
                BeginContext(5439, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(5507, 49, false);
#line 207 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
               Write(Html.DisplayNameFor(model => model.DiseasePanels));

#line default
#line hidden
                EndContext();
                BeginContext(5556, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(5624, 46, false);
#line 210 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
               Write(Html.DisplayNameFor(model => model.Hematology));

#line default
#line hidden
                EndContext();
                BeginContext(5670, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(5738, 46, false);
#line 213 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
               Write(Html.DisplayNameFor(model => model.Immunology));

#line default
#line hidden
                EndContext();
                BeginContext(5784, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(5852, 46, false);
#line 216 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
               Write(Html.DisplayNameFor(model => model.Urinalysis));

#line default
#line hidden
                EndContext();
                BeginContext(5898, 164, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Clusters\r\n                </th>\r\n            </tr>\r\n            </thead>\r\n            <tbody>\r\n\r\n");
                EndContext();
#line 225 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
              
                var list = Model.ToList();
                for (var i = 0; i < list.Count(); i++)
                {

#line default
#line hidden
                BeginContext(6197, 84, true);
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6282, 45, false);
#line 231 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                       Write(Html.DisplayFor(modelItem => list[i].ClaimId));

#line default
#line hidden
                EndContext();
                BeginContext(6327, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6419, 47, false);
#line 234 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                       Write(Html.DisplayFor(modelItem => list[i].DrugAssay));

#line default
#line hidden
                EndContext();
                BeginContext(6466, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6558, 50, false);
#line 237 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                       Write(Html.DisplayFor(modelItem => list[i].Microbiology));

#line default
#line hidden
                EndContext();
                BeginContext(6608, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6700, 47, false);
#line 240 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                       Write(Html.DisplayFor(modelItem => list[i].Chemistry));

#line default
#line hidden
                EndContext();
                BeginContext(6747, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6839, 51, false);
#line 243 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                       Write(Html.DisplayFor(modelItem => list[i].DiseasePanels));

#line default
#line hidden
                EndContext();
                BeginContext(6890, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(6982, 48, false);
#line 246 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                       Write(Html.DisplayFor(modelItem => list[i].Hematology));

#line default
#line hidden
                EndContext();
                BeginContext(7030, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(7122, 48, false);
#line 249 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                       Write(Html.DisplayFor(modelItem => list[i].Immunology));

#line default
#line hidden
                EndContext();
                BeginContext(7170, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(7262, 48, false);
#line 252 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                       Write(Html.DisplayFor(modelItem => list[i].Urinalysis));

#line default
#line hidden
                EndContext();
                BeginContext(7310, 87, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                        ");
                EndContext();
                BeginContext(7398, 22, false);
#line 255 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                   Write(ViewBag.ChartSeries[i]);

#line default
#line hidden
                EndContext();
                BeginContext(7420, 59, true);
                WriteLiteral("\r\n                        <td>\r\n                    </tr>\r\n");
                EndContext();
#line 258 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
                }
            

#line default
#line hidden
                BeginContext(7513, 56, true);
                WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n\r\n    </div>\r\n");
                EndContext();
#line 265 "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\Analytics.cshtml"
}

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7579, 13, true);
            WriteLiteral("\r\n\r\n\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClinicalCodeClusteringWebApp.Models.CPTCats>> Html { get; private set; }
    }
}
#pragma warning restore 1591
