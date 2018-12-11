using UnityEngine;
using LitJson;
using System.Collections.Generic;

public class Room
{
    //public string rm { get; set; } // Room number
    //public string wb { get; set; } //Web URL
    //public string nm { get; set; } // Name
    //public string dscr { get; set; } // Description
    //public string dprt { get; set; } //Department owner
    //public string key { get; set; } //Room where to get key

    //public int flr { get; set; } //Floor
    //public int cmp { get; set; } // Computers
    //public int wp { get; set; } //WorkPlaces
    //public int bld { get; set; } //Campus

    //public bool brd { get; set; } //board
    //public bool scrn { get; set; } //screanBoard
    //public bool prj { get; set; } //projector

    //public List<string> sft { get; set; } //List of software

    public int WorkPlace { get; set; }
    public int Floor { get; set; }
    public int Computers { get; set; }
    public int Building { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Department { get; set; }
    public string Key { get; set; }
    public string Url { get; set; }
    public string RoomNumber { get; set; }
    public bool Projector { get; set; }
    public bool Screen { get; set; }
    public bool Board { get; set; }
    public List<string> Soft { get; set; }
    //public Object[] Sprite { get; set; }

    //public Room(string ID, JsonData rooms)
    //{
    //    for (int i = 0; i < rooms.Count; i++)
    //    {
    //        if (rooms[i]["rm"].ToString() == ID)
    //        {
    //            WorkPlace = (int)rooms[i]["wp"];
    //            Computers = (int)rooms[i]["cmp"];
    //            RoomNumber = ID;
    //            Projector = (bool)rooms[i]["prj"];
    //            Screen = (bool)rooms[i]["scrn"];
    //            Name = rooms[i]["nm"].ToString();
    //            Url = rooms[i]["wb"].ToString();
    //            Sprite = Resources.LoadAll("Photoes/" + ID, typeof(Sprite));
    //        }
    //    }
    //}
}


