using System.Net;
using System.Net.Sockets;
using System.Text;

// You can use print statements as follows for debugging, they'll be visible when running tests.
Console.WriteLine("Logs from your program will appear here!");

// Uncomment this block to pass the first stage
TcpListener server = new(IPAddress.Any, 6379);
server.Start();
var client = server.AcceptSocket(); // wait for client

for (int i = 0; i < 1; i++)
{
    await client.SendAsync(Encoding.UTF8.GetBytes("+PONG\r\n"));
}