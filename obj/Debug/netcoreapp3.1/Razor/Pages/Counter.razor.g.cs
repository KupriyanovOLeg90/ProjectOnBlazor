#pragma checksum "F:\Progects\ProjectOnBlazor\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f42a7cdb69853c5bbf04112df9c554724e71c85d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTraning.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using BlazorTraning;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using BlazorTraning.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Progects\ProjectOnBlazor\_Imports.razor"
using BlazorTraning.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row \"><div class=\"col alert alert-secondary text-center\"><h1>Counter</h1></div></div>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-6 text-left");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary p-3");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "F:\Progects\ProjectOnBlazor\Pages\Counter.razor"
                                                      IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-6 text-right");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "style", "font-size: 50px");
            __builder.AddContent(14, 
#nullable restore
#line 16 "F:\Progects\ProjectOnBlazor\Pages\Counter.razor"
             currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col text-center");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "number");
            __builder.AddAttribute(22, "class", "form-control-lg");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "F:\Progects\ProjectOnBlazor\Pages\Counter.razor"
                                                           currentCount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCount = __value, currentCount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "F:\Progects\ProjectOnBlazor\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
