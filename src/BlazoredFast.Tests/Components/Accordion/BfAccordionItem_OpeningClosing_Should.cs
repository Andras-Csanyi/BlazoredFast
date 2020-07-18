namespace BlazoredFast.Tests.Components.Accordion
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    using AngleSharp.Dom;

    using Bunit;

    using FluentAssertions;

    using SayusiAndo.Carbon.BlazoredFast;
    using SayusiAndo.Carbon.BlazoredFast.Components.Accordion;

    using Xunit;

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [ExcludeFromCodeCoverage]
    public class BfAccordionItem_OpeningClosing_Should : TestContext
    {
        [Fact]
        public async Task Change_ExpandedCollapsedState()
        {
            // Arrange
            IRenderedComponent<BfAccordion> cut = RenderComponent<BfAccordion>(
                p => p.AddChildContent<BfAccordionItem>());

            IElement accordionItem = cut.Find($"{FastHtmlElements.FastAccordion}>{FastHtmlElements.FastAccordionItem}");

            // Act
            accordionItem.Click();

            // Assert
            accordionItem.Attributes.GetNamedItem("expanded").Should().NotBeNull();
        }
    }
}