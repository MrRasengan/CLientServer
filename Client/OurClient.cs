using System.Net.Sockets;
using System.Text;

namespace Client
{
    class OurClient
    {
        TcpClient client;
        StreamWriter sWriter;

        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555);
            sWriter = new StreamWriter(client.GetStream(), Encoding.UTF8);
            HandleComunication();
        }

        void HandleComunication()
        {
            while (true)
            {
                Console.Write("> ");
                string messege = Console.ReadLine()!;
                sWriter.WriteLine(messege);
                sWriter.Flush();
            }
        }

    }
}