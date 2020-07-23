namespace SayusiAndo.Carbon.BlazoredFast.Components.TreeView
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Components;

    public partial class BfTreeItem
    {
        [Parameter]
        public bool Expanded { get; set; }

        [Parameter]
        public bool Selected { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private string _slot = "item";

        [CascadingParameter]
        public BfTreeView _parentTreeView { get; set; }

        private async Task Select()
        {
            Selected = !Selected;
            await _parentTreeView.Select(this).ConfigureAwait(false);
        }
    }
}