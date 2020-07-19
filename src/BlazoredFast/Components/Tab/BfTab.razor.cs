namespace SayusiAndo.Carbon.BlazoredFast.Components.Tab
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Components;

    public partial class BfTab
    {
        [Parameter]
        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                _bfTabId = $"{_id}Panel";
            }
        }

        private string _id = string.Empty;

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public Dictionary<string, object> UnknownParameters { get; set; }

        [CascadingParameter]
        public BfTabs ParentBfTab { get; set; }

        private string _bfTabId = string.Empty;

        private async Task MakeActive()
        {
            await ParentBfTab.ChangeActiveTab(Id).ConfigureAwait(false);
        }
    }
}