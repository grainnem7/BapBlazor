#pragma checksum "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60937eddb4cd069c3fd146777e69317b6a99d0a0"
// <auto-generated/>
#pragma warning disable 1591
namespace BapBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using BapBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using BapBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Delete.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Delete.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Delete.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ruper\source\repos\bapteam01\BapBlazor\Pages\Delete.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/delete")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Delete</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates deleting from the dataaset.</p>\r\n\r\n");
            __builder.AddMarkupContent(2, "<p>One way to tackle this problem;</p>\r\n");
            __builder.AddMarkupContent(3, @"<ul><li>Start with pretty much the same code as FetchStoreApps.razor.</li>
    <li>Add a new column to the data table with a Delete link.</li>
    <li>Send a DELETE request to the API to delete the record from API's database.</li>
    <li>The API will need to know the Id of the record you want to delete (onclick=""()=>deleteRecord(storeapp)"").</li>
    <li><a href=""https://docs.microsoft.com/en-us/aspnet/core/blazor/call-web-api?view=aspnetcore-5.0&pivots=webassembly"">Call a web API from Blazor</a></li>
    <li><a href=""https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient.deleteasync?view=net-5.0"">DeleteAsync Method</a></li>
    <li><a href=""https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio"">API Delete</a></li></ul>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Search> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
