namespace BlazoredFast.Tests.Components.Tab
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using AngleSharp.Dom;

    using Bunit;

    using FluentAssertions;

    using SayusiAndo.Carbon.BlazoredFast;
    using SayusiAndo.Carbon.BlazoredFast.Components;
    using SayusiAndo.Carbon.BlazoredFast.Components.Tab;

    using Xunit;

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [ExcludeFromCodeCoverage]
    public class BfTabs_Should : TestContext
    {
        [Fact]
        public async Task Have_TheRightCssClasses_WhenHorizontal()
        {
            // Arrange
            IRenderedComponent<BfTabs> cut = RenderComponent<BfTabs>(
                p =>
                {
                    p.Add(pp => pp.Orientation, BfComponentApis.BfTabs.Attributes.OrientationValues.Horizontal);
                    p.AddChildContent<BfTab>();
                });

            // Assert
            cut.Find(BfComponentApis.BfTabs.Html.BfTabs)
                .ClassList
                .Contains(BfComponentApis.BfTabs.Css.BfTabs.Horizontal)
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Have_TheRightClasses_WhenVertical()
        {
            // Arrange
            IRenderedComponent<BfTabs> cut = RenderComponent<BfTabs>(
                p => p.Add(pp => pp.Orientation, BfComponentApis.BfTabs.Attributes.OrientationValues.Vertical));

            // Assert
            cut.Find(BfComponentApis.BfTabs.Html.BfTabs)
                .ClassList
                .Contains(BfComponentApis.BfTabs.Css.BfTabs.Vertical)
                .Should()
                .BeTrue();
        }

        [Fact]
        public async Task Default_OrientationValue_WhenItIsNotConfigured()
        {
            // Arrange
            IRenderedComponent<BfTabs> cut = RenderComponent<BfTabs>();

            // Assert
            IAttr iattr = cut.Find(BfComponentApis.BfTabs.Html.BfTabs)
                .Attributes
                .GetNamedItem(BfComponentApis.BfTabs.Attributes.Orientation);
            iattr.Value.Should().Be(BfComponentApis.BfTabs.Attributes.OrientationValues.Horizontal);
        }

        [Fact]
        public async Task Orientation_Horizontal_WhenConfiguredSo()
        {
            // Arrange
            IRenderedComponent<BfTabs> cut = RenderComponent<BfTabs>(
                p => p.Add(pp => pp.Orientation, BfComponentApis.BfTabs.Attributes.OrientationValues.Horizontal));

            // Assert
            IAttr iattr = cut.Find(BfComponentApis.BfTabs.Html.BfTabs)
                .Attributes
                .GetNamedItem(BfComponentApis.BfTabs.Attributes.Orientation);
            iattr.Value.Should().Be(BfComponentApis.BfTabs.Attributes.OrientationValues.Horizontal);
        }

        [Fact]
        public async Task Orientation_Vertical_WhenConfiguredSo()
        {
            // Arrange
            IRenderedComponent<BfTabs> cut = RenderComponent<BfTabs>(
                p => p.Add(pp => pp.Orientation, BfComponentApis.BfTabs.Attributes.OrientationValues.Vertical));

            // Assert
            IAttr iattr = cut.Find(BfComponentApis.BfTabs.Html.BfTabs)
                .Attributes
                .GetNamedItem(BfComponentApis.BfTabs.Attributes.Orientation);
            iattr.Value.Should().Be(BfComponentApis.BfTabs.Attributes.OrientationValues.Vertical);
        }

        [Fact(Skip = "bunit is not implemented yet")]
        public async Task Default_FirstIsActive_WhenNotConfigured()
        {
            // Arrange
            IRenderedComponent<BfTab> bfTabFirst = RenderComponent<BfTab>(
                p => p.Add(pp => pp.Id, "first"));
            IRenderedComponent<BfTab> bfTabSecond = RenderComponent<BfTab>(
                p => p.Add(pp => pp.Id, "second"));
            string markupFirst = bfTabFirst.Find(BfComponentApis.BfTab.Html.BfTab).ToMarkup();
            string markupSecond = bfTabSecond.Find(BfComponentApis.BfTab.Html.BfTab).ToMarkup();
            string markup = $"{markupFirst}{markupSecond}";

            IRenderedComponent<BfTabs> cut = RenderComponent<BfTabs>(
                p =>
                {
                    p.Add(pp => pp.Orientation, BfComponentApis.BfTabs.Attributes.OrientationValues.Horizontal);
                    p.AddChildContent(markup);
                });

            // Assert
            IAttr attr = cut.Find($"{BfComponentApis.BfTabs.Html.BfTabs}>{BfComponentApis.BfTab.Html.BfTab}[2]")
                .Attributes
                .GetNamedItem("aria-selected");
            attr.Should().NotBeNull();
            attr.Value.Should().Be("true");
        }

        [Fact(Skip = "bunit is not implemented yet")]
        public async Task TheConfiguredTabIsTheActive()
        {
        }
    }
}