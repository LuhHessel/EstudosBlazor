using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace EstudosBlazoe.Components.Pages
{
    public partial class Separation
    {
        /*
         * Razor (Engine Template - ASP.NET): HTML/CSS/JS + C#
         * 
         * Blazor: .Razoer(Componentes blazzor)
         * ASP>NET .cshtml (MVC & Razor Pages)
         */

        public string Texto = "Oi eu sou código C#";

        [Inject]
        public IJSRuntime JSRuntime { get; set; } = default!;

        public async Task CarregarJS()
        {
            var modulo = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./Components/Pages/Separation.Razor.js");

            //await JSRuntime.InvokeVoidAsync("ShowMessage");
            await modulo.InvokeVoidAsync("ShowMessageTwo");
        }
    }
}
