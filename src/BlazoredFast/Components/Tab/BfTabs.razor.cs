namespace SayusiAndo.Carbon.BlazoredFast.Components.Tab
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Components;

    public partial class BfTabs
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public string ActiveId { get; set; }

        [Parameter]
        public string Orientation { get; set; }

        [Parameter]
        public string ShowActiveIndicator { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UnknownParameters { get; set; }

        public async Task ChangeActiveTab(string activeTabId)
        {
            ActiveId = activeTabId;
            await InvokeAsync(StateHasChanged).ConfigureAwait(false);
        }
    }
}