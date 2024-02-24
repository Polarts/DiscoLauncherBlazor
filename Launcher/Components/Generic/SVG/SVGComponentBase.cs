using Microsoft.AspNetCore.Components;

namespace Launcher.Components.Generic.SVG
{
    public class SVGComponentBase : ComponentBase
    {
        [Parameter]
        public string Class { get; set; } = "";

        [Parameter]
        public string Style { get; set; } = "";
    }
}
