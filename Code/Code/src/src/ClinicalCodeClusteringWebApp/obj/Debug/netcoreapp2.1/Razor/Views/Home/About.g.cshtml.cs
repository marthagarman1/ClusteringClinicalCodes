#pragma checksum "C:\Users\Matt\AppData\Local\Packages\Microsoft.MicrosoftEdge_8wekyb3d8bbwe\TempState\Downloads\Code (1)\src\src\ClinicalCodeClusteringWebApp\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27c16b2da45df81358c316c5a7189ff7c63a95d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27c16b2da45df81358c316c5a7189ff7c63a95d0", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37ce3a9d75f0e72a8f146891befa6f0131efc30f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 8989, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fec7ba8b87a432283276d7387d1ab7f", async() => {
                BeginContext(6, 8976, true);
                WriteLiteral(@" 
<table class=""table table-bordered table-hover table-condensed"">
    <thead>
        <tr>
            <th title=""Field #1""></th>
            <th title=""Field #2"">summary</th>
            <th title=""Field #3"">param/</th>
            <th title=""Field #4"">param/0/</th>
            <th title=""Field #5"">param/1/</th>
            <th title=""Field #6"">param/2/</th>
            <th title=""Field #7"">returns</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>F:ClinicalCodeWebApplication.Controllers.HomeController.databaseconnection</td>
            <td>Database connection.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.HomeController.Index</td>
            <td>Generates landing page.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        <");
                WriteLiteral(@"/tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.HomeController.Revenue</td>
            <td>Generates Claim Revenue Chart if user is logged in.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.HomeController.Reports</td>
            <td>Generates reports page if user is logged in.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.HomeController.About</td>
            <td>Generates About Page.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.HomeController.Privacy</td>
            <td>Generates Priv");
                WriteLiteral(@"acy Policy.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.HomeController.UploadFile(Microsoft.AspNetCore.Http.IFormFile)</td>
            <td>Uploads CSV file to database.<br />                Then call K-Means Analysis.<br />                Redirects to cluster graph.</td>
            <td>file</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.HomeController.Analytics(System.Double[][],System.Double[][],System.Int32[])</td>
            <td>Takes in graph parameters, outputs scatter graph<br />                and table of information, if user is logged in.</td>
            <td> </td>
            <td>data</td>
            <td>centroids</td>
            <td>series</td>
            <td> </td>
        </tr>");
                WriteLiteral(@"
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.HomeController.Error</td>
            <td>Generates custom error: 404 page.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>F:ClinicalCodeWebApplication.Controllers.TestController.databaseconnection</td>
            <td>Database connection.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.TestController.Index</td>
            <td>Generates landing page.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.TestController.Revenue</td>
            <td>Generates Claim Revenue Chart if user is logged i");
                WriteLiteral(@"n.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.TestController.Reports</td>
            <td>Generates reports page if user is logged in.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.TestController.About</td>
            <td>Generates About Page.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.TestController.Privacy</td>
            <td>Generates Privacy Policy.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
    ");
                WriteLiteral(@"        <td>M:ClinicalCodeWebApplication.Controllers.TestController.UploadFile(Microsoft.AspNetCore.Http.IFormFile)</td>
            <td>Uploads CSV file to database.<br />                Then call K-Means Analysis.<br />                Redirects to cluster graph.</td>
            <td>file</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.TestController.Analytics(System.Double[][],System.Double[][],System.Int32[])</td>
            <td>Takes in graph parameters, outputs scatter graph<br />                and table of information, if user is logged in.</td>
            <td> </td>
            <td>data</td>
            <td>centroids</td>
            <td>series</td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Controllers.TestController.Error</td>
            <td>Generates custom error: 404 page.</td>
            <td");
                WriteLiteral(@"> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>T:ClinicalCodeWebApplication.Models.Algorithms.RunKMeans</td>
            <td>Runs the K-Means Algorithms on dataset.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>F:ClinicalCodeWebApplication.Models.Algorithms.RunKMeans.membership</td>
            <td>Goal of this program is to return membership variable.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Models.Algorithms.RunKMeans.#ctor(System.Int32,System.Double[][])</td>
            <td>Controller.<br />                Takes in dataset and intializes variables.</td>
            <td>dataset</td>
            <td> </td>
            <td");
                WriteLiteral(@"> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Models.Algorithms.RunKMeans.KMeans</td>
            <td>Controls the K-Means loop.</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Models.Algorithms.RunKMeans.InitializeCentroidMeans(System.Int32)</td>
            <td>Randomly assign mean to centroids by assigning to random centroid</td>
            <td>k</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Models.Algorithms.RunKMeans.UpdateMembership</td>
            <td>Assigns membership to closest centroid</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td>returns true if any points chan");
                WriteLiteral(@"ge membership</td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Models.Algorithms.RunKMeans.TotalWithinSumofSquares</td>
            <td>Total Variance Within Clusters Sum of Squares</td>
            <td>k</td>
            <td> </td>
            <td> </td>
            <td> </td>
            <td>returns distortion calculation.</td>
        </tr>
        <tr>
            <td>M:ClinicalCodeWebApplication.Models.Algorithms.RunKMeans.Distance(System.Double[],System.Double[])</td>
            <td>Euclidean Distance between two points.</td>
            <td> </td>
            <td>point1</td>
            <td>centroid</td>
            <td> </td>
            <td>returns sum of squared difference</td>
        </tr>
    </tbody>
</table>
");
                EndContext();
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
