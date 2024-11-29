using System.Net;
using System.Net.Sockets;
using System.Text;

// Uncomment this block to pass the first stage
TcpListener server = new(IPAddress.Any, 6379);
server.Start();

var client = server.AcceptSocket();

while (client.Connected) {
var buffer = new byte[1024];

await client.ReceiveAsync(buffer);
await client.SendAsync(Encoding.ASCII.GetBytes("+PONG\r\n"));
}
