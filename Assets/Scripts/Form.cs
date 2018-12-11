using UnityEngine;
using UnityEngine.UI;

class Form : MonoBehaviour
{
    [SerializeField]
    private GameObject TextWorkPlace, Computers, Projector, Screen, RoomNumber, Title, Photo;
    private static string Url;

    public void UpdateForm(Room room)
    {
        TextWorkPlace.GetComponent<Text>().text = room.WorkPlace.ToString();
        Computers.GetComponent<Text>().text = room.Computers.ToString();
        Projector.GetComponent<Text>().text = (room.Projector == true) ? "✓" : "-";
        Screen.GetComponent<Text>().text = (room.Screen == true) ? "✓" : "-";
        RoomNumber.GetComponent<Text>().text = room.RoomNumber;
        Title.GetComponent<Text>().text = room.Name;
        Url = room.Url;
        //Photo.GetComponent<Image>().sprite = room.Sprite[0] as Sprite;
    }

    public void OpenUrl()
    {
        Application.OpenURL(Url);
    }
}
