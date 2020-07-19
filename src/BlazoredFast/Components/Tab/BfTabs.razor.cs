namespace SayusiAndo.Carbon.BlazoredFast.Components.Tab
{
    using System.Collections.Generic;
    using System.Linq;
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

        private List<string> _tabs = new List<string>();

        public async Task ChangeActiveTab(string activeTabId)
        {
            ActiveId = activeTabId;
            await InvokeAsync(StateHasChanged).ConfigureAwait(false);
        }

        public async Task RegisterTab(string tabId)
        {
            _tabs.Add(tabId);
        }

        protected override async Task OnInitializedAsync()
        {
            await SetDefaultTab().ConfigureAwait(false);
            await SetOrDefaultOrientation().ConfigureAwait(false);
        }

        private async Task SetOrDefaultOrientation()
        {
            if (string.IsNullOrEmpty(Orientation) || string.IsNullOrWhiteSpace(Orientation))
            {
                Orientation = BfComponentApis.BfTabs.Attributes.OrientationValues.Horizontal;
            }
            else
            {
                switch (Orientation)
                {
                    case BfComponentApis.BfTabs.Attributes.OrientationValues.Horizontal:
                        Orientation = BfComponentApis.BfTabs.Attributes.OrientationValues.Horizontal;
                        break;

                    case BfComponentApis.BfTabs.Attributes.OrientationValues.Vertical:
                        Orientation = BfComponentApis.BfTabs.Attributes.OrientationValues.Vertical;
                        break;

                    default:
                        Orientation = BfComponentApis.BfTabs.Attributes.OrientationValues.Horizontal;
                        break;
                }
            }
        }

        private async Task SetDefaultTab()
        {
            if (_tabs.Any())
            {
                if (string.IsNullOrEmpty(ActiveId) || string.IsNullOrWhiteSpace(ActiveId))
                {
                    string def = _tabs.ElementAt(0);
                    ActiveId = def;
                }
            }
        }
    }
}