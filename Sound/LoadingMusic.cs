using System;
using System.IO;
using MelonLoader;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

namespace LoadingMusic
{
    public class Music
    {
        public static AudioClip clip;
        public static IEnumerator Start()
        {
            string path = Path.Combine(Directory.CreateDirectory("XEngine/").FullName, "Loading.ogg");
            if (!File.Exists(path))
            {
                var download = new UnityWebRequest("https://github.com/BiscuiTheHobkin/XEngine-files/blob/main/Loading.ogg", UnityWebRequest.kHttpVerbGET);
                download.downloadHandler = new DownloadHandlerFile(path);
                yield return download.SendWebRequest();
            }
            UnityWebRequest localfile = UnityWebRequest.Get("file://" + path);
            yield return localfile.SendWebRequest();
            clip = WebRequestWWW.InternalCreateAudioClipUsingDH(localfile.downloadHandler, localfile.url, false, false, 0);
            AudioSource musicObj = GameObject.Find("MenuContent/Popups/LoadingPopup/LoadingSound").GetComponent<AudioSource>();
            while (GameObject.Find("MenuContent/Popups/LoadingPopup/LoadingSound") == null) yield return new WaitForEndOfFrame();
                musicObj.clip = clip;
                musicObj.volume = 100;
                musicObj.Play();
                MelonLogger.Msg("-> Music -> MainLoadingMusic Loaded");
            localfile = null;
            yield break;
        }
    }
}
