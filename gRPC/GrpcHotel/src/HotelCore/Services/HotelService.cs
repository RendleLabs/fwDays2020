using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using HotelCore.Protos;

namespace HotelCore.Services
{
    public partial class HotelService : global::HotelCore.Protos.HotelService.HotelServiceBase
    {
            private readonly Hotel.IHotelService _serviceContract;
        
        public HotelService(Hotel.IHotelService serviceContract)
        {
            _serviceContract = serviceContract;
        }
        
        public override Task<Protos.GetAvailableRoomsResponse> GetAvailableRooms(Protos.GetAvailableRoomsRequest request, ServerCallContext context)
        {
            var values = _serviceContract.GetAvailableRooms(request.CheckInDate.ToDateTimeOffset(), request.CheckOutDate.ToDateTimeOffset());
            var response = new Protos.GetAvailableRoomsResponse();
            foreach (var value in values)
            {
                response.Values.Add(value);
            }
            return Task.FromResult(response);
        }
        
        public override Task<Protos.GetRoomResponse> GetRoom(Protos.GetRoomRequest request, ServerCallContext context)
        {
            var responseValue = _serviceContract.GetRoom(request.Number);
            return Task.FromResult(new Protos.GetRoomResponse { Value = responseValue });
        }
        
        public override Task<Protos.GetRoomsResponse> GetRooms(Protos.GetRoomsRequest request, ServerCallContext context)
        {
            var numbers = new int[request.Numbers.Count];
            for (int i = 0; i < request.Numbers.Count; i++)
            {
                numbers[i] = request.Numbers[i];
            }
            var values = _serviceContract.GetRooms(numbers);
            var response = new Protos.GetRoomsResponse();
            foreach (var value in values)
            {
                response.Values.Add(value);
            }
            return Task.FromResult(response);
        }
        
        public override async Task AllRooms(Protos.AllRoomsRequest request, IServerStreamWriter<AllRoomsResponse> responseStream, ServerCallContext context)
        {
            foreach (var item in _serviceContract.AllRooms())
            {
                var response = new Protos.AllRoomsResponse { Value = item };
                await responseStream.WriteAsync(response);
            }
        }
        
    }
}

