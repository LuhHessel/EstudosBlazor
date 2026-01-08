using EstudosBlazoe.Models;
using Microsoft.AspNetCore.Components;

namespace EstudosBlazoe.Components.Pages
{
    public partial class DependecyInjection
    {
        [Inject(Key = "sms")]
        public IMensagem MensagemChaveada { get; set; } = default!;
    }
}
