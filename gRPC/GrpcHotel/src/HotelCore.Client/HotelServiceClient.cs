using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace HotelCore.Client
{
    public partial class HotelServiceClient
    {
        private readonly HotelCore.Client.Protos.HotelService.HotelServiceClient _client;
        
        public HotelServiceClient(HotelCore.Client.Protos.HotelService.HotelServiceClient client)
        {
            _client = client;
        }
        
        public async Task<IList<Room>> GetAvailableRoomsAsync(DateTimeOffset checkInDate, DateTimeOffset checkOutDate)
        {
            var request = new Protos.GetAvailableRoomsRequest
            {
                CheckInDate = Timestamp.FromDateTimeOffset(checkInDate),
                CheckOutDate = Timestamp.FromDateTimeOffset(checkOutDate),
            };
            var response = await _client.GetAvailableRoomsAsync(request);
            var returnValues = new List<Room>(response.Values.Count);
            foreach (var value in response.Values)
            {
                returnValues.Add(value);
            }
            return returnValues;
        }
        
        public async Task<Room> GetRoomAsync(int number)
        {
            var request = new Protos.GetRoomRequest
            {
                Number = number,
            };
            var response = await _client.GetRoomAsync(request);
            var returnValue = response.Value;
            return returnValue;
        }
        
        public async Task<Room[]> GetRoomsAsync(int[] numbers)
        {
            var request = new Protos.GetRoomsRequest();
            foreach (var value in numbers)
            {
                request.Numbers.Add(value);
            }
            var response = await _client.GetRoomsAsync(request);
            var returnValues = new Room[response.Values.Count];
            for (int i = 0; i < response.Values.Count; i++)
            {
                returnValues[i] = response.Values[i];
            }
            return returnValues;
        }
        
#if(NETSTANDARD_2_1)
        public async IAsyncEnumerable<Room> AllRoomsAsync()
        {
            var request = new Protos.AllRoomsRequest();
            var streamingCall = _client.AllRooms(request);
            await foreach (var response in streamingCall.ResponseStream.ReadAllAsync())
            {
                var returnValue = response.Value;
                yield return returnValue;
            }
        }
#else
        public async Task<IEnumerable<Room>> AllRoomsAsync()
        {
            var request = new Protos.AllRoomsRequest();
            var streamingCall = _client.AllRooms(request);
            
            var list = new List<Room>();
            while (await streamingCall.ResponseStream.MoveNext())
            {
                var response = streamingCall.ResponseStream.Current;
                var returnValue = response.Value;
                list.Add(returnValue);
            }
            return list;
        }
#endif
        
    }
}

