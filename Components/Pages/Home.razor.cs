using DoctorOfficePro.Resources;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace DoctorOfficePro.Components.Pages
{
    public partial class Home
    {
        [Inject] public IStringLocalizer<Texts> local { get; set; }
    }
}
