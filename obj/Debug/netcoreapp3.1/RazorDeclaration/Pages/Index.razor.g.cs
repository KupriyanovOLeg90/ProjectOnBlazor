// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "F:\Progects\ProjectOnBlazor\Pages\Index.razor"
      
    List<Game> games;

    Random rnd;

    Game oneGameToShow;

    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(2000);

        games = new List<Game>() {
            new Game() {Name = "PUGN", Genre = "Action", ReleaseDate = new DateTime(2010, 5, 4) },
            new Game() {Name = "StarCraft", Genre = "Stategy", ReleaseDate = new DateTime(1995, 1, 4) },
            new Game() {Name = "THe Wicher 3", Genre = "RPG", ReleaseDate = new DateTime(2015, 5, 3) } };


        rnd = new Random(DateTime.Now.Millisecond);
        oneGameToShow = games[rnd.Next(0, games.Count())];
    }

    void ShowNewGame()
    {
        oneGameToShow = SwichGame();
    }

    Game SwichGame()
    {
        Game tempGame;
        if (games.Count() > 1)
            tempGame = games[rnd.Next(0, games.Count())];
        else if (games.Count() == 1)
            tempGame = games[0];
        else
            return new Game() { Name = "No Items in Arrey", Genre = "", ReleaseDate=DateTime.Now};

        return tempGame;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
