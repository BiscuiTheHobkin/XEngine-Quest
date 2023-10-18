using System;
using System.IO;
using MelonLoader;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

namespace Qmnotification
{
    public class Music
    {
        public static AudioClip clip;
        public static IEnumerator Start()
        {
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/Notifications/SocialNotificationsOverlay/AvatarButton0").AddComponent<AudioSource>();
            string path = Path.Combine(Directory.CreateDirectory("XEngine/").FullName, "QMNotifications.ogg");
            if (!File.Exists(path))
            {
                var download = new UnityWebRequest("https://github.com/BiscuiTheHobkin/Colored-UI-files/raw/main/AlertPopup.ogg", UnityWebRequest.kHttpVerbGET);
                download.downloadHandler = new DownloadHandlerFile(path);
                yield return download.SendWebRequest();
            }
            UnityWebRequest localfile = UnityWebRequest.Get("file://" + path);
            yield return localfile.SendWebRequest();
            clip = WebRequestWWW.InternalCreateAudioClipUsingDH(localfile.downloadHandler, localfile.url, false, false, 0);
            AudioSource musicObj = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/Notifications/SocialNotificationsOverlay/AvatarButton0").GetComponent<AudioSource>();
            while (GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/Notifications/SocialNotificationsOverlay/AvatarButton0") == null) yield return new WaitForEndOfFrame();
            musicObj.clip = clip;
            musicObj.volume = 100;
            musicObj.Play();
            localfile = null;
            yield break;
        }
    }
}
