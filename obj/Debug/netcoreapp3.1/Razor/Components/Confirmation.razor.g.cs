#pragma checksum "D:\C#\Projects\My_List_v2\Components\Confirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa74b16a3550f60bb9ab1f28b1b1f2beb9560f2"
// <auto-generated/>
#pragma warning disable 1591
namespace My_List_v2.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#\Projects\My_List_v2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#\Projects\My_List_v2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Models.DeserializeTranslation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\C#\Projects\My_List_v2\_Imports.razor"
using My_List_v2.Repository;

#line default
#line hidden
#nullable disable
    public partial class Confirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\C#\Projects\My_List_v2\Components\Confirmation.razor"
 if (displayConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <div class=\"modal-backdrop show\"></div>\r\n");
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "modal show ");
            __builder.AddAttribute(4, "id", "exampleModal");
            __builder.AddAttribute(5, "tabindex", "-1");
            __builder.AddAttribute(6, "role", "dialog");
            __builder.AddAttribute(7, "aria-labelledby", "exampleModal");
            __builder.AddAttribute(8, "aria-hidden", "true");
            __builder.AddAttribute(9, "style", "display: block ");
            __builder.AddMarkupContent(10, "\r\n\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-dialog");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "modal-content");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "modal-header");
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "h5");
            __builder.AddAttribute(21, "class", "modal-title");
#nullable restore
#line 11 "D:\C#\Projects\My_List_v2\Components\Confirmation.razor"
__builder.AddContent(22, Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                     ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\C#\Projects\My_List_v2\Components\Confirmation.razor"
                                       onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "class", "close");
            __builder.AddMarkupContent(28, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "modal-body");
            __builder.AddMarkupContent(33, "\r\n                    ");
#nullable restore
#line 15 "D:\C#\Projects\My_List_v2\Components\Confirmation.razor"
__builder.AddContent(34, ChildContent);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-footer");
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\C#\Projects\My_List_v2\Components\Confirmation.razor"
                                      onConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-danger");
            __builder.AddContent(44, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\C#\Projects\My_List_v2\Components\Confirmation.razor"
                                      onCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn btn-primary");
            __builder.AddContent(50, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
#nullable restore
#line 24 "D:\C#\Projects\My_List_v2\Components\Confirmation.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\C#\Projects\My_List_v2\Components\Confirmation.razor"
       
    private bool displayConfirmation = false;

     [Parameter]
     public string Title { get; set; } = "Confirm";
     
     [Parameter]
     public RenderFragment ChildContent { get; set; }
     
     [Parameter]
     public EventCallback onConfirm { get; set; }
     
     [Parameter]
     public EventCallback onCancel { get; set; }

    public void Show() => displayConfirmation = true;
    public void Hide() => displayConfirmation = false;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591