using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;
using SimpleJSON;

public class LaunchRequest : MonoBehaviour {
    void Start() {
        StartCoroutine(GetText());
    }
    //the text box to bind to
    public TextMesh LaunchInfo;

    IEnumerator GetText() {
       // get data for the next launch
        UnityWebRequest www = UnityWebRequest.Get("https://launchlibrary.net/1.4/launch/next/1");
        yield return www.SendWebRequest();

        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            // Show results as text
            //Debug.Log(www.downloadHandler.text);

            // Or retrieve results as binary data
            // byte[] results = www.downloadHandler.data;

            //parse some JSON
            JSONNode N = JSON.Parse(www.downloadHandler.text);
            //Debug.Log(N["launches"][0]["name"].ToString());
            LaunchInfo.text = ("" + "Next Launch: " + N["launches"][0]["name"].ToString() );

        }
    }
}
