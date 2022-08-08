using System.ServiceModel;
using WCF_Service_1;
//using System.ServiceModel.Web;
//namespace Masala;

//[ServiceContract]
//public interface ICalculator
//{
//    [OperationContract]
//    [WebInvoke(UriTemplate = "add?x={x}&y={y}")]
//    long Add(long x, long y);

//    [OperationContract]
//    [WebInvoke(UriTemplate = "sub?x={x}&y={y}")]
//    long Subtract(long x, long y);

//    [OperationContract]
//    [WebInvoke(UriTemplate = "mult?x={x}&y={y}")]
//    long Multiply(long x, long y);

//    [OperationContract]
//    [WebInvoke(UriTemplate = "div?x={x}&y={y}")]
//    long Divide(long x, long y);

//    [OperationContract]
//    [WebGet(UriTemplate = "hello?name={name}")]
//    string SayHello(string name);
//}

//public class CalcService : ICalculator
//{
//    public long Add(long x, long y)
//    {
//        return x + y;
//    }

//    public long Subtract(long x, long y)
//    {
//        return x - y;
//    }

//    public long Multiply(long x, long y)
//    {
//        return x * y;
//    }

//    public long Divide(long x, long y)
//    {
//        return x / y;
//    }

//    public string SayHello(string name)
//    {
//        return "Hello " + name;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Uri baseAddress = new Uri("http://localhost:8000/");

//        WebServiceHost svcHost = new WebServiceHost(typeof(CalcService), baseAddress);

//        try
//        {
//            svcHost.Open();

//            Console.WriteLine("Service is running");
//            Console.WriteLine("Press enter to quit...");
//            Console.ReadLine();

//            svcHost.Close();
//        }
//        catch (CommunicationException cex)
//        {
//            Console.WriteLine("An exception occurred: {0}", cex.Message);
//            svcHost.Abort();
//        }
//    }
//}


//using Grpc.Core;
////Server code
//class Program
//{
//    static void Main(string[] args)
//    {
//        RunAsync().Wait();
//    }

//    private static async Task RunAsync()
//    {
//        var server = new Grpc.Core.Server
//        {
//            Ports = { { "127.0.0.1", 5000, ServerCredentials.Insecure } },
//            Services =
//            {
//                ServerServiceDefinition.CreateBuilder()
//                    .AddMethod(Descriptors.Method, async (requestStream, responseStream, context) =>
//                    {
//                        await requestStream.ForEachAsync(async additionRequest =>
//                        {
//                            Console.WriteLine($"Recieved addition request, number1 = {additionRequest.X} --- number2 = {additionRequest.Y}");
//                            await responseStream.WriteAsync(new AdditionResponse {Output = additionRequest.X + additionRequest.Y});
//                        });
//                    })
//                    .Build()
//            }
//        };

//        server.Start();

//        Console.WriteLine($"Server started under [127.0.0.1:5000]. Press Enter to stop it...");
//        Console.ReadLine();

//        await server.ShutdownAsync();
//    }
//}

//using Bond;
//using Bond.IO.Safe;
//using Bond.Protocols;
//using Grpc.Core;
//using Grpc.Core.Utils;

//class Program
//{

//    static void Main(string[] args)
//    {
//        RunAsync().Wait();
//    }

//    private static async Task RunAsync()
//    {
//        Channel channel = new Channel("127.0.0.1", 5000, ChannelCredentials.Insecure);
//        var invoker = new DefaultCallInvoker(channel);
//        using (var call = invoker.AsyncDuplexStreamingCall(Descriptors.Method, null, new CallOptions { }))
//        {
//            var responseCompleted = call.ResponseStream
//                .ForEachAsync(async response =>
//                {
//                    Console.WriteLine($"Output: {response.Output}");
//                });

//            await call.RequestStream.WriteAsync(new AdditionRequest { X =2, Y = 2 });
//            Console.ReadLine();

//            await call.RequestStream.CompleteAsync();
//            await responseCompleted;
//        }

//        Console.WriteLine("Press enter to stop...");
//        Console.ReadLine();

//        await channel.ShutdownAsync();
//    }
//}

////Service
//public class Descriptors
//{
//    public static Method<AdditionRequest, AdditionResponse> Method =
//            new Method<AdditionRequest, AdditionResponse>(
//                type: MethodType.DuplexStreaming,
//                serviceName: "AdditonService",
//                name: "AdditionMethod",
//                requestMarshaller: Marshallers.Create(
//                    serializer: Serializer<AdditionRequest>.ToBytes,
//                    deserializer: Serializer<AdditionRequest>.FromBytes),
//                responseMarshaller: Marshallers.Create(
//                    serializer: Serializer<AdditionResponse>.ToBytes,
//                    deserializer: Serializer<AdditionResponse>.FromBytes));
//}

////shared classes 
//[Schema]
//public class AdditionRequest
//{
//    [Id(0)]
//    public int X { get; set; }
//    [Id(1)]
//    public int Y { get; set; }
//}

//[Schema]
//public class AdditionResponse
//{
//    [Id(0)]
//    public int Output { get; set; }
//}

//public static class Serializer<T>
//{
//    public static byte[] ToBytes(T obj)
//    {
//        var buffer = new OutputBuffer();
//        var writer = new FastBinaryWriter<OutputBuffer>(buffer);
//        Serialize.To(writer, obj);
//        var output = new byte[buffer.Data.Count];
//        Array.Copy(buffer.Data.Array, 0, output, 0, (int)buffer.Position);
//        return output;
//    }

//    public static T FromBytes(byte[] bytes)
//    {
//        var buffer = new InputBuffer(bytes);
//        var data = Deserialize<T>.From(new FastBinaryReader<InputBuffer>(buffer));
//        return data;
//    }
//}
ServiceHost host = new ServiceHost(typeof(MathService));
host.Open();
Console.WriteLine("Ready");
host.Stop();

