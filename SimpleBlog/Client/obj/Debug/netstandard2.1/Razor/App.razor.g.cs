#pragma checksum "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6afc4ec48fb12609615569a764b91fd26f44bbc0"
// <auto-generated/>
#pragma warning disable 1591
namespace ASimpleBlogStarter.Client
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using ASimpleBlogStarter.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\_Imports.razor"
using ASimpleBlogStarter.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(5);
                    __builder3.AddAttribute(6, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(7, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
#nullable restore
#line 6 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\App.razor"
                     if (!context.User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<ASimpleBlogStarter.Client.Shared.RedirectToLogin>(9);
                        __builder4.CloseComponent();
#nullable restore
#line 9 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\App.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddMarkupContent(10, "<p>You are not authorized to access this resource.</p>");
#nullable restore
#line 13 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\App.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(11, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(12);
                    __builder3.AddAttribute(13, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 18 "C:\Users\cm\Downloads\a-simple-blog-blazor-wasm-master\Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(15, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
