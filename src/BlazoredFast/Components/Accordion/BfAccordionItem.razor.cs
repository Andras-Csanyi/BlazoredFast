namespace SayusiAndo.Carbon.BlazoredFast.Components.Accordion
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Components;

    public partial class BfAccordionItem
    {
        [Parameter] public bool IsExpanded { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UnknownParameters { get; set; }

        private void ExpandOperation()
        {
            IsExpanded = !IsExpanded;
        }
    }
}