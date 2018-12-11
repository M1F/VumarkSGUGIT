using UnityEngine;
using LitJson;
using System.Collections.Generic;

public class Room
{
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

}


