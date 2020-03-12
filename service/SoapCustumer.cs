using MaxHackton.data;
using SoapHttpClient;
using SoapHttpClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaxHackton.service
{
    public class SoapCustumer
    {
        string baseUrl = "";
        SoapClient client = new SoapClient();
        



        public async Costumer registerUser1()
        {
            var ns = XNamespace.Get("http://helio.spdf.gsfc.nasa.gov/");
            var result = await client.PostAsync(
          new Uri("http://sscweb.gsfc.nasa.gov:80/WS/helio/1/HeliocentricTrajectoriesService"),
          SoapVersion.Soap11,
          body: new XElement(ns.GetName("getAllObjects")));
            return null;
          
        }
        


    }
}
