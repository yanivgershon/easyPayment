using MaxHackton.data;
using Rest;
using RestSharp;
using SimpleSOAPClient;
using SimpleSOAPClient.Helpers;
using SimpleSOAPClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestClient = RestSharp.RestClient;

namespace MaxHackton.service
{
	
    public class CostumerSoap
    {
		public string aplicationToken = "1878cdd2-c241-45a3-b45d-eb028aaaa232";

		public string registerCostumerAsync(Costumer costumer)
		{/*
			var a = costumer;
			
			var client = new RestClient("{{baseurl}}/V2/customer.svc/RegisterCustomer");
			client.Timeout = -1;
			var request = new RestRequest(Method.POST);
			request.AddHeader("Content-Type", "application/json");
			request.AddHeader("applicationToken", "{{applicationToken}}");
			request.AddParameter("application/json", "{\r\n  \"data\": {\r\n " +
				"   \"ApplicationToken\": {{"+ aplicationToken + "}},\r\n  " +
	"  \"Password\": \""+ costumer.Password+ "\",\r\n   " +
 " \"PinCode\": \"1310\",\r\n    \r\n  " +
 "  \"info\": {\r\n      \"AddressLine1\": \"barkat 14\",\r\n  " +
 "    \"AddressLine2\": \"apt 3\",\r\n     " +
 " \"City\": \"holon\",\r\n   " +
 "   \"CountryIso\": \"IL\",\r\n    " +
 "  \"PostalCode\": \"54888\",\r\n   " +
 "   \"CellNumber\": \"972549200123\",\r\n   " +
 "   \"EmailAddress\": \"meir@6nksdhs.com\",\r\n   " +
 "   \"userName\": \"jonjon1\",\r\n    " +
 "  \"FirstName\": \"Meir\",\r\n    " +
 "  \"LastName\": \"Segev\",\r\n  " +
 "    \"PersonalNumber\": \"066239385\",\r\n     " +
 " \"PhoneNumber\": \"972549200123\"\r\n  " +
 "  }\r\n  }\r\n}", ParameterType.RequestBody);
			IRestResponse response = client.Execute(request);
			Console.WriteLine(response.Content);
		}
		public async Task loginCostumerAsync(string userName,string passWord)
		{
			var client = new RestClient("https://webservices.coriunder.cloud//V2/account.svc/Login");
			client.Timeout = -1;
			var request = new RestRequest(Method.POST);
			request.AddHeader("Content-Type", "application/json");
			request.AddHeader("applicationToken", aplicationToken);
			request.AddParameter("application/json", "\r\n{\r\n  \"userName\":" +
				" \""+ userName + "\"," +
				"\r\n  " +
				"\"password\": \""+ passWord + "\",\r\n  " +
				"\"options\": {\r\n    \"applicationToken\": " +
	"\"{{"+applicationToken+"}}\"" +
	",\r\n    \"userRole\":\"15\"\r\n    \r\n  }\r\n}", ParameterType.RequestBody);
			IRestResponse response = client.Execute(request);
			Console.WriteLine(response.Content);
		}
		public async Task registerCostumerAsync()
		{
			using (var client = SoapClient.Prepare())
			{
				var responseEnvelope =
					await client.SendAsync(
						"https://services.company.com/Service.svc",
						"http://services.company.com/IService/CreateUser",
						SoapEnvelope.Prepare()
							.WithHeaders(new TrackingHeader())
							.Body(new CreateUserRequest()), ct);

				var response = responseEnvelope.Body<CreateUserResponse>();
			}
			*/
       
}
    }
}
