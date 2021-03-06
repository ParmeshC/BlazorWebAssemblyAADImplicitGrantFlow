#pragma checksum "C:\Users\waelk\Desktop\Security\BlazorWasmApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3396da22728f6ccb7fc9fa8b5179fb6467703d4b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWasmApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using BlazorWasmApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using BlazorWasmApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\waelk\Desktop\Security\BlazorWasmApp\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        var tokenResult = await TokenProvider.RequestAccessToken(
                            new AccessTokenRequestOptions
                            {
                                Scopes = new[] { "api://weatherforecast/weather.get" }
                            });


        if (tokenResult.TryGetToken(out var token))
        {
            Http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);

            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("https://localhost:44301/weatherforecast");
        }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccessTokenProvider TokenProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
