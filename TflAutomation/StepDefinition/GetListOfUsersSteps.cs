using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace TflAutomation.StepDefinition
{
    [Binding]
    public class GetListOfUsersSteps
    {
        RestClient client;
        [Given(@"I send a get request list to ""(.*)""")]
        public void GivenISendAGetRequestListTo(string p0)
        {
            client = new RestClient("https://reqres.in/api/users?page=2");
            client.Timeout = -1;
        }
        
        [Given(@"I send a request to verify list of users")]
        public void GivenISendARequestToVerifyListOfUsers()
        {
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "__cfduid=d832d9a3a61284f9e083b1bbbf6046baa1599700203");
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
