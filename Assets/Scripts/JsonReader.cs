using UnityEngine;
using LitJson;


public class JsonReader
{
    public JsonData JsonObject { get; set; }
    public JsonReader(string Path)
    {
        TextAsset jsonData = (TextAsset)Resources.Load(Path, typeof(TextAsset));
        JsonObject = JsonMapper.ToObject(jsonData.text);
    }
}
