using System;
using Connect_to_ELMA_API.ELMA_SOAP;

namespace Connect_to_ELMA_API
{
    class Program
    {
        static void Main(string[] args)
        {
            // Before you start, you need to remove service reference to my Web API 
            // Add your own by click Add Service reference and enter string like "http://192.168.19.157/Modules/EleWise.ELMA.Workflow.Processes.Web/WFPWebService.asmx" 
            // Where http://192.168.19.157 you must change to your own basic url of ELMA web-server
            Console.Write("Enter login to ELMA: ");
            string login = Console.ReadLine();
            Console.Write("Enter password to ELMA: ");
            string password = Console.ReadLine();

            WFPWebServiceSoapClient client = new WFPWebServiceSoapClient();

            // Simple example of getting information from active tasks from process Id 144910
            foreach (var result in client.GetActiveTasks(login, password, 144910))
            {
                Console.WriteLine(result.CreationDate + " " + result.ExecutorName + " " + result.Subject);
            }
            Console.ReadKey();
        }
    }
}
