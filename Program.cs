using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      ServiceReference1.ListServiceClient client = new ServiceReference1.ListServiceClient();
      ServiceReference1.CancelRequest[] requests = new ServiceReference1.CancelRequest[]
      {
        new ServiceReference1.CancelRequest()
      };
      requests[0].RequestId = "temp";
      requests[0].RequestServiceKey = "temp service key";

      var resutls = client.GetResponses(requests);
            
      Console.ReadLine();
    }
  }
}
