using NUnit.Framework;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomation.StepDefinition
{
    [Binding]
    public class PostSingleUserSteps
    {
        RestClient client;
        RestRequest request;
        IRestResponse response;
        [Given(@"I send a post request to https://reqres\.in/api/users/(.*)")]
        public void GivenISendAPostRequestToHttpsReqres_InApiUsers(int p0)
        {
            client = new RestClient("https://reqres.in/api/users/2");
            client.Timeout = -1;
        }
        
        [Given(@"I send post request to verify the user")]
        public void GivenISendPostRequestToVerifyTheUser()
        {
            client = new RestClient("https://reqres.in/api/users/2");
            client.Timeout = -1;
        }
        
        [When(@"The reply is received")]
        public void WhenTheReplyIsReceived()
        {
            request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", "__cfduid=d832d9a3a61284f9e083b1bbbf6046baa1599700203");
            request.AddParameter("application/json", "{\r\n    \"name\": \"morpheus\",\r\n    \"job\": \"leader\"\r\n}\r\n", ParameterType.RequestBody);
            response = client.Execute(request);
        }
        
        [Then(@"I should get status code ""(.*)""")]
        public void ThenIShouldGetStatusCode(string p0)
        {
            //Assert.That(response.Content.Length > 84);
            Assert.That(response.StatusCode.ToString() == "Created");
            Assert.That(response.IsSuccessful.ToString() == "True");
        }
    }
}
