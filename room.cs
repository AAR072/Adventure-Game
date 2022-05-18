using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventuregame
{

    internal class room
    {

        public string leftRoomObject = "";
        public string rightRoomObject = "";
        public string upRoomObject = "";
        public string downRoomObject = "";
        public string forwardRoomObject = "";
        public string backRoomObject = "";
        public string roomType { get; set; }
        public string[] roomTypes = {
            //0           1          2           3       4       5
            "entrance", "corridor", "library", "jail", "pit", "ending"

        };

        public room(string tempRoomType)
        {
            roomType = tempRoomType;

        }



    }
}
