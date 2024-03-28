using UnityEngine;

public class TextFileReader : MonoBehaviour
{
    // Reference to the text file in the Unity Editor
    public TextAsset textFile;

    void Start()
    {
        if (textFile != null)
        {
            // Extract text from the text file
            string fileContents = textFile.text;
            Debug.Log("Text File Contents: " + fileContents);


        }
        else
        {
            Debug.LogError("Text file is not assigned.");
        }
    }
}
