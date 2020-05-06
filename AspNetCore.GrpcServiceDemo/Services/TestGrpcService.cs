using Grpc.Core;
using System.Threading.Tasks;

namespace AspNetCore.GrpcServiceDemo
{
    public class TestGrpcService : Test.TestBase
    {
        public override Task<TestReply> TestMethod(TestRequest request, ServerCallContext context)
        {
            return Task.FromResult(new TestReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
