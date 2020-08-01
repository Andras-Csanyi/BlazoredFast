namespace SayusiAndo.Carbon.BlazoredFast.Components.TreeView
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Components;

    public partial class BfTreeItem
    {
        [Parameter]
        public bool Expanded { get; set; }

        [Parameter]
        public bool Selected { get; set; } = false;

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        private string _slot = "item";

        [CascadingParameter]
        protected BfTreeView ParentTreeView { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (Selected)
            {
                await Select().ConfigureAwait(false);
            }
        }

        private async Task Select()
        {
            Selected = true;
            await ParentTreeView.Select(this).ConfigureAwait(false);
        }
    }
}