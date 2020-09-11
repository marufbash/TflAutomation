using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomation.StepDefinition
{
    [Binding]
    public class SingleUserNotFoundSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;
        [Given(@"I send a single user get request to ""(.*)""")]
        public void GivenISendASingleUserGetRequestTo(string p0)
        {
            client = new RestClient("https://reqres.in/api/users/23,");
            client.Timeout = -1;
        }
        
        [Given(@"I send a get request for single user")]
        public void GivenISendAGetRequestForSingleUser()
        {
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "__cfduid=d832d9a3a61284f9e083b1bbbf6046baa1599700203");
            response = client.Execute(request);
        }
        
        [Then(@"I should get user ""(.*)"" response")]
        public void ThenIShouldGetUserResponse(string p0)
        {
            Assert.That(response.StatusCode.ToString() == "NotFound");
            Assert.That(response.IsSuccessful.ToString() == "False");
        }
    }
}
