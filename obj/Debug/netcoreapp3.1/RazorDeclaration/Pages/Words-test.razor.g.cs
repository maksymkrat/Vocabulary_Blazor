// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/words-test")]
    public partial class Words_test : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\C#\Projects\My_List_v2\Pages\Words-test.razor"
       
    Word mainWord ;
    List<Word> words;
    Random rnd = new Random();
    string resultStyle = "light";
    string mainWordStyle = "light";
    int rndWord = 0;
    
    
    protected override void OnInitialized()
    {
         
        words = _business.GetFourWordsForTestWords();
        mainWord = words.ElementAt(rnd.Next(0, words.Count));
    }
    

    void ChangeStyleMainWord(string style)
    {
        mainWordStyle = style;
        
    }

    void ResetWord()
    {
        words = _business.GetFourWordsForTestWords();
        mainWord = words.ElementAt(rnd.Next(0, words.Count));
        resultStyle = "light";
        mainWordStyle = resultStyle;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusinessLogic _business { get; set; }
    }
}
#pragma warning restore 1591
