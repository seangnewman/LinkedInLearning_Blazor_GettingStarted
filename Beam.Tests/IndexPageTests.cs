using Bunit;
using Xunit;

namespace Beam.Tests
{
    /// <summary>
    /// These tests are written entirely in C#.
    /// Learn more at https://bunit.egilhansen.com/docs/getting-started/
    /// </summary>
    public class IndexPageTests : TestContext
    {
        [Fact]
        public void CounterStartsAtZero()
        {
            // Arrange
            var cut = RenderComponent<Beam.Client.Pages.Index>();

            // Assert that content of the paragraph shows counter at zero
            Assert.Contains("Select a Frequency, or create a new one", cut.Markup);
            //cut.Find("p").MarkupMatches("<p>Current count: 0</p>");
            cut.MarkupMatches(@"<h2 diff:ignore></h2>
                                                    <p diff:ignore></p>");

        }


    }
}
