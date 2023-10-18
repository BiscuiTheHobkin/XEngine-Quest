using System;
using System.IO;
using MelonLoader;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

namespace Inputpopup
{
    public class Music
    {
        public static AudioClip clip;
        public static IEnumerator Start()
        {
            GameObject.Find("MenuContent/Popups/InputPopup").AddComponent<AudioSource>();
            string path = Path.Combine(Directory.CreateDirectory("XEngine/").FullName, "Inputpopup.ogg");
            if (!File.Exists(path))
            {
                var download = new UnityWebRequest("https://github.com/BiscuiTheHobkin/XEngine-files/blob/main/Inputpopup.ogg", UnityWebRequest.kHttpVerbGET);
                download.downloadHandler = new DownloadHandlerFile(path);
                yield return download.SendWebRequest();
            }
            UnityWebRequest localfile = UnityWebRequest.Get("file://" + path);
            yield return localfile.SendWebRequest();
            clip = WebRequestWWW.InternalCreateAudioClipUsingDH(localfile.downloadHandler, localfile.url, false, false, 0);
            AudioSource musicObj = GameObject.Find("MenuContent/Popups/InputPopup").GetComponent<AudioSource>();
            while (GameObject.Find("MenuContent/Popups/InputPopup") == null) yield return new WaitForEndOfFrame();
            musicObj.clip = clip;
            musicObj.volume = 100;
            musicObj.Play();
            //MelonLogger.Msg("Gobutton Sound has been played");
            localfile = null;
            yield break;
        }
    }
}