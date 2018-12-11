using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using LitJson;

public class VuMarkEvent : MonoBehaviour {
    public JsonData rooms, schedules;
    public List<Room> Rooms;
    public System.DateTime moment = System.DateTime.Now;
	private VuMarkManager vuMarkManager;

    void Start () {
        TextAsset jsonData = (TextAsset)Resources.Load("JsonData/rooms", typeof(TextAsset));
        Rooms = JsonMapper.ToObject<List<Room>>(jsonData.text);
        schedules = new JsonReader("JsonData/rasp").JsonObject;
        vuMarkManager = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
		vuMarkManager.RegisterVuMarkDetectedCallback(onVuMarkDetected);
    }

    private void onVuMarkDetected(VuMarkTarget target)
    {
        string ID = getVuMarkID(target);
        Room room = Rooms.Find(item => item.RoomNumber == ID);
        //Schedule schedule = new Schedule(ID, schedules);
        Form form = GameObject.Find("Vumarker").GetComponent<Form>();
        form.UpdateForm(room);
    }

    private string getVuMarkID(VuMarkTarget vuMark){
		switch (vuMark.InstanceId.DataType){
		case InstanceIdType.BYTES:
			return vuMark.InstanceId.HexStringValue.Trim('\0');
		case InstanceIdType.STRING:
			return vuMark.InstanceId.StringValue.Trim('\0');
		case InstanceIdType.NUMERIC:
			return vuMark.InstanceId.NumericValue.ToString().Trim('\0');
		}
		return null;
	}

    void Update()
    {
    }

}
