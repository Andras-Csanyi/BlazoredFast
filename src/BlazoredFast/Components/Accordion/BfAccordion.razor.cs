namespace SayusiAndo.Carbon.BlazoredFast.Components.Accordion
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Components;

    public partial class BfAccordion
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        
        [Parameter]
        public string ExpandMode { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object> UnknownParameters { get; set; }
        
        private string _expandModel = BfComponentApis.BfAccordion.ExpandModeValues.Multi;

        protected override async Task OnInitializedAsync()
        {
            await SetExpandMode().ConfigureAwait(false);
        }

        private async Task SetExpandMode()
        {
            if (!string.IsNullOrEmpty(ExpandMode) && !string.IsNullOrWhiteSpace(ExpandMode))
            {
                switch (ExpandMode)
                {
                    case BfComponentApis.BfAccordion.ExpandModeValues.Multi:
                        _expandModel = BfComponentApis.BfAccordion.ExpandModeValues.Multi;
                        break;
                    
                    case BfComponentApis.BfAccordion.ExpandModeValues.Single:
                        _expandModel = BfComponentApis.BfAccordion.ExpandModeValues.Single;
                        break;
                }
            }
        }
    }
}