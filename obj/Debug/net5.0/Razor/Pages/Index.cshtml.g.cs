#pragma checksum "C:\Users\srilo\Box\Education\Microsoft-Verifiable-Credentials-UTD-Web-App\azure files\sample code\active-directory-verifiable-credentials-dotnet\1-asp-net-core-api-idtokenhint\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ce2dc4eaf4060c7618e3bfe7aaabbdf7d3bcc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreVerifiableCredentials.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AspNetCoreVerifiableCredentials.Pages
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
#line 1 "C:\Users\srilo\Box\Education\Microsoft-Verifiable-Credentials-UTD-Web-App\azure files\sample code\active-directory-verifiable-credentials-dotnet\1-asp-net-core-api-idtokenhint\Pages\_ViewImports.cshtml"
using AspNetCoreVerifiableCredentials;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ce2dc4eaf4060c7618e3bfe7aaabbdf7d3bcc6", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1696cd1c73de55a48ac8554feb073dcb6d0d8bc3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\srilo\Box\Education\Microsoft-Verifiable-Credentials-UTD-Web-App\azure files\sample code\active-directory-verifiable-credentials-dotnet\1-asp-net-core-api-idtokenhint\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div style=""text-align: center;"">
                <img src=""utdlogo.png"" height=200px; />
                <img class=""microsoft"" alt=""microsoft"" src=""microsoft.png"">
                 <h1> UTD Verifiable Credentials Demo </h1>
                <div class=""messageInitial""><h2>This web application takes advantage of Microsoft Decentralized Verifiable Credentials Service which are on a decentralized blockchain to provide privacy/transparency and allow users to take true ownership of their data. This web app was created during Microsoft Decentralized Identity Hackathon</h2></div>
                <button type=""button"" id=""idIssue"" class=""button"">GET CREDENTIAL</button>
                <button type=""button"" id=""idVerify"" class=""button"">VERIFY CREDENTIAL</button>
                <script>
                        var idIssue = document.getElementById('idIssue');
                        var idVerify = document.getElementById('idVerify');

                        idIssue.addEventListener('click', ");
            WriteLiteral(@"() => {
                            window.location = ""issuer"";
                        })
                        idVerify.addEventListener('click', () => {
                            window.location = ""verifier"";
                        })
                    </script>
            </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
