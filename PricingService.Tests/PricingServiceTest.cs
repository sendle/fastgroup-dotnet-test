namespace PricingService.Tests;

public class PricingServiceIntegrationTest
{
    [Fact]
    public void ItRendersQuotes()
    {
        var pricing = new Pricing.Service.PricingService();

        // You'll need to create a list of shipments to pass to
        // get_quotes so it produces the expected_display when 
        // it's run through the quote system.
        // You can model this data structure as you please.
        var quotes = pricing.GetQuotes(null);
        var display = pricing.RenderQuotes(quotes);

        var expected = @"
        Quote Report

        Brisbane, 4000 to Brisbane, 4000, 200gm: $4.10
        Adelaide, 5000 to Sydney, 2000, 4000gm: $9.50
        Sydney, 2000 to Glebe, 2037, 5000gm: $4.10
        Perth, 6000 to Brisbane, 4000, 10000gm: $14.90
        Melbourne, 3000 to Modbury, 5092, 12000gm: -
        South Perth, 6151 to Brisbane, 4000, 8000gm: -
        Fremantle, 6160 to Adelaide, 5000, 500gm: $4.50

        Total: $37.10
        ";

        Assert.Equal(expected, display);
    }
}
