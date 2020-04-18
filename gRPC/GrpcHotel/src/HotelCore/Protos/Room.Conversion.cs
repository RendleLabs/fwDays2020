using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf.WellKnownTypes;

namespace HotelCore.Protos
{
    public partial class Room
    {
        public static implicit operator Room(global::Hotel.Data.Room src) => new Room {
            Number = src.Number,
            Floor = src.Floor,
            Name = src.Name,
            Price = Convert.ToDouble(src.Price),
        };

        public static implicit operator global::Hotel.Data.Room(Room src) => new global::Hotel.Data.Room {
            Number = src.Number,
            Floor = src.Floor,
            Name = src.Name,
            Price = Convert.ToDecimal(src.Price),
        };

    }
}

