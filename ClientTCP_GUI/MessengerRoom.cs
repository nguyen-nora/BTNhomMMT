using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ClientTCP
{
    class MessengerRoom
    {
        private string _nameRoom;
        private int _nameRoomSize;
        private string _nameActor;
        private int _nameActorSize;

        public string NameRoom { get => _nameRoom; set => _nameRoom = value; }
        public int NameRoomSize { get => _nameRoomSize; set => _nameRoomSize = value; }
        public string NameActor { get => _nameActor; set => _nameActor = value; }
        public int NameActorSize { get => _nameActorSize; set => _nameActorSize = value; }


    }
}
