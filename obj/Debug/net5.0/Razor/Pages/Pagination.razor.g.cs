#pragma checksum "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f2f63010ebb7388fa29bbd511931339dde7b589"
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
#line 2 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using BapBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using BapBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pagination")]
    public partial class Pagination : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Pagination</h1>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped table-hover");
            __builder.AddMarkupContent(3, "<thead><tr><th>Id</th>\r\n            <th>Name</th>\r\n            <th>Rating</th>\r\n            <th>People</th>\r\n            <th>Category</th>\r\n            <th>Date</th>\r\n            <th>Price</th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 23 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
         foreach (var storeapp in StoreApps)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.AddAttribute(6, "class", "justify-content-center");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 26 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                     storeapp.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 27 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                     storeapp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 28 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                     storeapp.Rating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 29 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                     storeapp.People

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 30 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                     storeapp.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 31 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                     storeapp.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 32 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
                     storeapp.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n<br>\r\n");
            __builder.AddMarkupContent(28, @"<nav aria-label=""...""><ul class=""pagination""><li class=""page-item disabled""><span class=""page-link"">Previous</span></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
        <li class=""page-item active"" aria-current=""page""><span class=""page-link"">2</span></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li></ul></nav>");
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\Pagination.razor"
       

    string responseBody = "";
    List<StoreApp> StoreApps = new List<StoreApp>();

    protected override async Task OnInitializedAsync()
    {
        var apiName = "api/StoreApps/FirstTen";
        var httpResponse = await client.GetAsync(apiName);

        if (httpResponse.IsSuccessStatusCode)
        {
            responseBody = await httpResponse.Content.ReadAsStringAsync();
            StoreApps = JsonConvert.DeserializeObject<List<StoreApp>>(responseBody);
            StateHasChanged();
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
