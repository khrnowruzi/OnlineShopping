using FluentAssertions;
using OnlineShopping.Specs.Models;
using RestSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace OnlineShopping.Specs.Steps
{
    [Binding]
    public class ManagingProductSteps
    {
        private long _newId;
        private readonly RestClient _client = new RestClient("http://localhost:57028/");
        private Product _expectedProduct;

        [Given(@"I have entered as a seller account")]
        public void GivenIHaveEnteredAsASellerAccount() { }

        [When(@"I define the following product")]
        public void WhenIDefineTheFollowingProduct(Table table)
        {
            _expectedProduct = table.CreateInstance<Product>();
            var request = new RestRequest("api/products", DataFormat.Json);
            request.AddJsonBody(_expectedProduct);
            var response = _client.Post<long>(request);
            _newId = _expectedProduct.Id = response.Data;
        }

        [Then(@"I should be able to see the product in the list of products")]
        public void ThenIShouldBeAbleToSeeTheProductInTheListOfProducts()
        {
            var request = new RestRequest($"api/products/{_newId}", DataFormat.Json);
            var response = _client.Get<Product>(request);
            var actualProduct = response.Data;
            actualProduct.Should().BeEquivalentTo(_expectedProduct);
            var tearDownResponse = _client.Delete<Product>(request);
        }
    }
}
