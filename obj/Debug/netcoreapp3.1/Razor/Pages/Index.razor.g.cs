#pragma checksum "D:\C#\Projects\My_List_v2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d235530b429dce0766c9557064d81db3246743"
// <auto-generated/>
#pragma warning disable 1591
namespace My_List_v2.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<My_List_v2.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
