using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomation.StepDefinition
{
    [Binding]
    public class UpdateSingleUserSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;

        [Given(@"I send a put request to ""(.*)""")]
        public void GivenISendAPutRequestTo(string p0)
        {
            client = new RestClient("https://reqres.in/api/users/2");
            client.Timeout = -1;
        }
        
        [Given(@"I send a request to verify a single user is updated")]
        public void GivenISendARequestToVerifyASingleUserIsUpdated()
        {
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", "__cfduid=d832d9a3a61284f9e083b1bbbf6046baa1599700203");
            request.AddParameter("application/json", "{\r\n    \"name\": \"morpheus\",\r\n    \"job\": \"zion resident\"\r\n}", ParameterType.RequestBody);
            response = client.Execute(request);
        }
        
        [Then(@"I should receive an ""(.*)"" response")]
        public void ThenIShouldReceiveAnResponse(string p0)
        {
            Assert.That(response.StatusCode.ToString() == "OK");
            Assert.That(response.IsSuccessful.ToString() == "True");
        }
    }
}
