using AspNetCore.GrpcServiceDemo.Protos;
using Grpc.Core;
using System.Threading.Tasks;

namespace AspNetCore.GrpcServiceDemo.Services
{
    public class OrderService : Order.OrderBase
    {
        public async override Task<CreateOrderReply> CreateOrder(CreateOrderRequest request, ServerCallContext context)
        {
            //todo something

            //throw RpcException异常
            throw new RpcException(new Status(StatusCode.NotFound, "资源不存在"));

            //返回
            return new CreateOrderReply
            {
                Success = true
            };
        }
    }
}
