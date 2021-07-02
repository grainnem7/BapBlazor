#pragma checksum "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9126697756205f1070a4a2a33c56e86886e841e3"
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
#line 3 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchstoreapps")]
    public partial class FetchStoreApps : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "<div class=\"row justify-content-center\" style=\"margin-bottom:50px\"><h3 class=\"text-center\">Store Apps - First Ten Records</h3></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddAttribute(5, "style", "margin:25px;");
#nullable restore
#line 17 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
         if (StoreApps != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(8, @"<thead class=""thead-dark""><tr><th>Id</th>
                        <th>Name</th>
                        <th>Rating</th>
                        <th>People</th>
                        <th>Category</th>
                        <th>Date</th>
                        <th>Price</th></tr></thead>
                ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 34 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
                     foreach (var storeapp in StoreApps)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.AddAttribute(11, "class", "justify-content-center");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 37 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
                             storeapp.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 38 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
                             storeapp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 39 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
                             storeapp.Rating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 40 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
                             storeapp.People

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 41 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
                             storeapp.Category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 42 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
                             storeapp.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 43 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
                             storeapp.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
         if (!StoreApps.Any())
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<div class=\"justify-content-center\"><h5>No records to show</h5></div>");
#nullable restore
#line 54 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\grain\OneDrive\Desktop\BapTeam01\BapBlazor\Pages\FetchStoreApps.razor"
       

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
