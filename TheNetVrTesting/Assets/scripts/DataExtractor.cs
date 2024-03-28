using System;
using System.Diagnostics;
using UnityEngine;



public class DataExtractor : MonoBehaviour
{
    // Reference to the text file in the Unity Editor
    public TextAsset textFile;
    AvatarData avatar;

    public string fileContents;
    void Start()
    {
        if (textFile != null)
        {
            // Extract text from the text file
            fileContents = textFile.text;
            UnityEngine.Debug.Log("Text File Contents: " + fileContents);
            avatar.data.str = fileContents;
        }
        else
        {
            UnityEngine.Debug.LogError("Text file is not assigned.");
        }
    }
    [ContextMenu("Save")]
    public void Save()
    {
        CloudSave.SaveData(avatar, "Avatar Data");
        UnityEngine.Debug.Log("Avatar Data Saved");
    }
    [ContextMenu("Load")]
    public async void Load()
    {

        var data = await CloudSave.LoadData<AvatarData>("Avatar Data");
        UnityEngine.Debug.Log(data);
    }

}

[Serializable]
public struct AvatarData
{
    public jsonData data;
}

[Serializable]
public struct jsonData
{
    public string str;
}