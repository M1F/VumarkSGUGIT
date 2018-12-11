using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using LitJson;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    public List<GameObject> modelList;
    public List<string> modelIdList;
    public JsonData RoomsJsonvale, RaspJsonvale;

    private int modelN;
    private VuMarkManager vuMarkManager;
    public GameObject TextWorkPlace, Computers, Projector, Board;

    void Start()
    {
        Processjson("JsonData/rooms", "JsonData/rasp");
        // Set VuMarkManager
        vuMarkManager = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
        // Set VuMark detected and lost behavior methods
        vuMarkManager.RegisterVuMarkDetectedCallback(onVuMarkDetected);
        //vuMarkManager.RegisterVuMarkLostCallback(onVuMarkLost);

        // Deactivate all models 
        //foreach(GameObject item in modelList){
        //	item.SetActive (false);
        //}
    }

    private void Processjson(string RoomsPath, string RaspPath)
    {
        TextAsset jsonData = (TextAsset)Resources.Load(RoomsPath, typeof(TextAsset));
        RoomsJsonvale = JsonMapper.ToObject(jsonData.text);
        jsonData = (TextAsset)Resources.Load(RaspPath, typeof(TextAsset));
        RaspJsonvale = JsonMapper.ToObject(jsonData.text);
        //Debug.Log(jsonvale[1]["ds"][1]["lsns"]["2"]["lsn"]);
    }

    public void onVuMarkDetected(VuMarkTarget target)
    {
        //Debug.Log ("Detected ID: "+ getVuMarkID(target));
        //Debug.Log (target.Template.VuMarkUserData);
        // Find and activate model by VuMark ID
        TextWorkPlace.GetComponent<Text>().text = getVuMarkID(target);
        GetDataByVumark(getVuMarkID(target));
        //for (int i = 0; i < modelIdList.Count; i++)
        //{
        //    if (modelIdList[i] == getVuMarkID(target))
        //    {
        //        modelList[i].SetActive(true);
        //        // Set model number
        //        modelN = i;
        //    }
        //}
    }

    private void GetDataByVumark(string ID)
    {
        //Debug.Log(jsonvale[186]["soft"][1]);
        for (int i = 0; i < RoomsJsonvale.Count; i++)
        {
            //if i
            //TextWorkPlace = jsonvale[186]["soft"][1];
            //Computers = ;
            //Projector = ; 
            //Board = ;
            //Debug.Log(jsonvale["results"][i]["room"].ToString());

            //Transform[] ts = tables[i].transform.GetComponentsInChildren<Transform>(true);
            //Material FoodMat = Resources.Load("Materials/Fastfood", typeof(Material)) as Material; //getting material
            //foreach (Transform t in ts)
            //{
            //    if (t.gameObject.name == "Caption")
            //    {
            //        t.gameObject.GetComponent<Text>().text = jsonvale["results"][i]["name"].ToString();
            //    }
            //};
        }
    }




    private string getVuMarkID(VuMarkTarget vuMark)
    {
        switch (vuMark.InstanceId.DataType)
        {
            case InstanceIdType.BYTES:
                return vuMark.InstanceId.HexStringValue;
            case InstanceIdType.STRING:
                return vuMark.InstanceId.StringValue;
            case InstanceIdType.NUMERIC:
                return vuMark.InstanceId.NumericValue.ToString();
        }
        return null;
    }



    //public void onVuMarkLost(VuMarkTarget target){
    //	//Debug.Log ("Lost ID: "+ getVuMarkID(target));
    //	// Deactivate model by model number
    //	modelList [modelN].SetActive (false);
    //}

    void Update()
    {
        /*		foreach (var vmb in vuMarkManager.GetActiveBehaviours()) {
                    Debug.Log ("ID: "+ getVuMarkID(vmb.VuMarkTarget));
                }
        */
    }

}
