using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf.WellKnownTypes;

namespace HotelCore.Client.Protos
{
    public partial class Room
    {
        public static implicit operator Room(global::HotelCore.Client.Room src) => new Room {
            Number = src.Number,
            Floor = src.Floor,
            Name = src.Name,
            Price = Convert.ToDouble(src.Price),
        };

        public static implicit operator global::HotelCore.Client.Room(Room src) => new global::HotelCore.Client.Room {
            Number = src.Number,
            Floor = src.Floor,
            Name = src.Name,
            Price = Convert.ToDecimal(src.Price),
        };

    }
}

