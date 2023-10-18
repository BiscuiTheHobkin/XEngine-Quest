using System;
using System.IO;
using MelonLoader;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

namespace GoButton
{
    public class Music
    {
        public static AudioClip clip;
        public static IEnumerator Start()
        {
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton").AddComponent<AudioSource>();
            string path = Path.Combine(Directory.CreateDirectory("XEngine/").FullName, "Gobutton.ogg");
            if (!File.Exists(path))
            {
                var download = new UnityWebRequest("https://github.com/BiscuiTheHobkin/XEngine-files/blob/main/Gobutton.ogg", UnityWebRequest.kHttpVerbGET);
                download.downloadHandler = new DownloadHandlerFile(path);
                yield return download.SendWebRequest();
            }
            UnityWebRequest localfile = UnityWebRequest.Get("file://" + path);
            yield return localfile.SendWebRequest();
            clip = WebRequestWWW.InternalCreateAudioClipUsingDH(localfile.downloadHandler, localfile.url, false, false, 0);
            AudioSource musicObj = GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton").GetComponent<AudioSource>();
            while (GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton") == null) yield return new WaitForEndOfFrame();
            musicObj.clip = clip;
            musicObj.volume = 100;
            musicObj.Play();
            //MelonLogger.Msg("Gobutton Sound has been played");
            localfile = null;
            yield break;
        }
    }
}