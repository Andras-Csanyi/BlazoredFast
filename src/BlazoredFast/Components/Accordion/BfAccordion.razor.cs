namespace SayusiAndo.Carbon.BlazoredFast.Components.Accordion
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Components;

    public partial class BfAccordion
    {
        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object> UnknownParameters { get; set; }
    }
}