using System;
using System.Collections.Generic;

namespace car_lot
{
  class Program
  {
    static void Main(string[] args)
    {
      var vehicles = new List<Dictionary<string, Dictionary<string, string>>>();

      var vehicleOne = new Dictionary<string, string>() {
                {"year", "2008"},
                {"model", "Damfresh"},
                {"make", "Biotraxquote"},
                {"color", "Sky Magenta"}
            };
      var salesAgentOne = new Dictionary<string, string>() {
                {"mobile", "(896) 478-6975"},
                {"lastName", "Botsford"},
                {"firstName", "Shaina"}
            };
      var creditOne = new Dictionary<string, string>() {
                {"creditProvider", "J.P. Morgan Chase & Co"},
                {"account", "601109582720302"}
            };

      var carOne = new Dictionary<string, Dictionary<string, string>>() {
            {"vehicle", vehicleOne},
            {"salesAgent", salesAgentOne},
            {"credit", creditOne}
        };

      vehicles.Add(carOne);


      var vehicleTwo = new Dictionary<string, string>() {
            {"year", "2010"},
            {"model", "Hotquadtrax"},
            {"make", "Transtintechno"},
            {"color", "robin egg blue"}
        };
      var salesAgentTwo = new Dictionary<string, string>() {
            {"mobile", "562.300.2912"},
            {"last_name", "Davis"},
            {"first_name", "Gerardo"}
        };
      var creditTwo = new Dictionary<string, string>() {

            {"credit_provider", "PNC Financial Services"},
            {"account", "34578280562836"}
      };

      var carTwo = new Dictionary<string, Dictionary<string, string>>() {
            {"vehicle", vehicleTwo},
            {"salesAgent", salesAgentTwo},
            {"credit", creditTwo}
        };

      vehicles.Add(carTwo);



    }
  }
}
