using System;
using System.IO;
using MelonLoader;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

namespace ShowLogoSound
{
    public class Music
    {
        public static AudioClip clip;
        public static IEnumerator Start()
        {
            GameObject.Find("MenuContent/Logo").AddComponent<AudioSource>();
            string path = Path.Combine(Directory.CreateDirectory("XEngine/").FullName, "StartupSound.ogg");
            if (!File.Exists(path))
            {
                var download = new UnityWebRequest("https://github.com/BiscuiTheHobkin/XEngine-files/blob/main/StandardPopup.ogg", UnityWebRequest.kHttpVerbGET);
                download.downloadHandler = new DownloadHandlerFile(path);
                yield return download.SendWebRequest();
            }
            UnityWebRequest localfile = UnityWebRequest.Get("file://" + path);
            yield return localfile.SendWebRequest();
            clip = WebRequestWWW.InternalCreateAudioClipUsingDH(localfile.downloadHandler, localfile.url, false, false, 0);
            AudioSource musicObj = GameObject.Find("MenuContent/Logo").GetComponent<AudioSource>();
            while (GameObject.Find("MenuContent/Logo") == null) yield return new WaitForEndOfFrame();
            musicObj.clip = clip;
            musicObj.volume = 100;
            musicObj.Play();
            localfile = null;
            yield break;
        }
    }
}