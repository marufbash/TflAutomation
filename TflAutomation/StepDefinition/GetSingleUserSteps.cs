using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomation.StepDefinition
{
    [Binding]
    public class GetSingleUserSteps
    {
        RestClient client;
        [Given(@"I send a get request to ""(.*)""")]
        public void GivenISendAGetRequestTo(string p0)
        {
            client = new RestClient("https://reqres.in/api/users/2");
            client.Timeout = -1;
        }
        
        [Given(@"I send the request to verify the details of the user")]
        public void GivenISendTheRequestToVerifyTheDetailsOfTheUser()
        {
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "__cfduid=d832d9a3a61284f9e083b1bbbf6046baa1599700203");
            IRestResponse response = client.Execute(request);
        }
    }
}
