using LitJson;
using System.Collections.Generic;

class Schedule
{
    private int WorkPlace { get; set; }
    public int Computers { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string RoomNumber { get; set; }
    public bool Projector { get; set; }
    public bool Screen { get; set; }

    //public Schedule(string iD, JsonData schedules)
    //{
    //    for (int i = 0; i < schedules.Count; i++)
    //    {
    //        if (schedules[i]["rm"].ToString() == ID)
    //        {
    //            WorkPlace = (int)schedules[i]["wp"];
    //            Computers = (int)schedules[i]["cmp"];
    //            RoomNumber = ID;
    //            Projector = (bool)schedules[i]["prj"];
    //            Screen = (bool)schedules[i]["scrn"];
    //            Title = schedules[i]["nm"].ToString();
    //            Url = schedules[i]["wb"].ToString();
    //        }
    //    }
    //}
}
