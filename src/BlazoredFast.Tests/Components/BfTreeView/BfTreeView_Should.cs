namespace BlazoredFast.Tests.Components.BfTreeView
{
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;

    using AngleSharp.Dom;

    using Bunit;

    using FluentAssertions;

    using SayusiAndo.Carbon.BlazoredFast.Components;
    using SayusiAndo.Carbon.BlazoredFast.Components.TreeView;

    using Xunit;

    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class BfTreeView_Should : TestContext
    {
        [Fact]
        public async Task Generate_FastTreeView_HtmlItem()
        {
            // Act
            IRenderedComponent<BfTreeView> cut = RenderComponent<BfTreeView>();

            // Assert
            cut.Find(BfComponentApis.BfTreeView.Html.BfTreeView)
                .Should().NotBeNull();
        }

        [Fact]
        public async Task SplatAttribute()
        {
            // Act
            IRenderedComponent<BfTreeView> cut = RenderComponent<BfTreeView>(
                ("custom", "value"));

            // Assert
            cut.Find(BfComponentApis.BfTreeView.Html.BfTreeView)
                .Attributes
                .GetNamedItem("custom")
                .Value
                .Should()
                .Be("value");
        }

        [Fact]
        public async Task SplatMultipleAttributes()
        {
            // Act
            IRenderedComponent<BfTreeView> cut = RenderComponent<BfTreeView>(
                ("custom", "value"),
                ("custom2", "value2")
            );

            // Assert
            cut.Find(BfComponentApis.BfTreeView.Html.BfTreeView)
                .Attributes
                .GetNamedItem("custom")
                .Value
                .Should()
                .Be("value");

            cut.Find(BfComponentApis.BfTreeView.Html.BfTreeView)
                .Attributes
                .GetNamedItem("custom2")
                .Value
                .Should()
                .Be("value2");
        }

        [Fact]
        public async Task RenderChildContent()
        {
            // Act
            IRenderedComponent<BfTreeView> cut = RenderComponent<BfTreeView>(
                p => p.AddChildContent<BfTreeItem>()
            );

            // Assert
            cut.Find(BfComponentApis.BfTreeView.Html.BfTreeView)
                .ToMarkup()
                .Contains(BfComponentApis.BfTreeItem.Html.BfTreeItem)
                .Should()
                .BeTrue();
        }
    }
}