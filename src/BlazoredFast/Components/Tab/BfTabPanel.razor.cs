namespace SayusiAndo.Carbon.BlazoredFast.Components.Tab
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Components;

    public partial class BfTabPanel
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UnknownParameters { get; set; }
    }
}