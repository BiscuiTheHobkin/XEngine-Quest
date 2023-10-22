using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using VRC.Core;

namespace UIStuff
{
    internal class WelcomeScreenAfterLogin
    {
        public static IEnumerator Init()
        {
            while (GameObject.Find("StandardPopup") == null)
            {
                yield return null;
            }
            yield return new WaitForSeconds(2);
            new GameObject("Logo").transform.parent = GameObject.Find("MenuContent").transform;
            GameObject.Find("MenuContent/Logo").transform.position = new Vector3(-0.007f, 1.5623f, 0.78f);
            GameObject.Find("MenuContent/Logo").transform.localPosition = new Vector3(0f, 0.0375f, 0f);
            GameObject.Find("MenuContent/Logo").transform.localScale = new Vector3(3f, 3f, 3f);
            MelonCoroutines.Start(ShowLogoSound.Music.Start());
            GameObject.Find("MenuContent/Logo").AddComponent<TextMeshProUGUI>();
            GameObject.Find("MenuContent/Logo").GetComponent<TextMeshProUGUI>().fontSize = 10;
            GameObject.Find("MenuContent/Logo").GetComponent<TextMeshProUGUI>().SetText("Welcome Back : " + APIUser.CurrentUser.displayName.ToString());
            MelonCoroutines.Start(ShowLogoSound.Music.Start());
            yield return new WaitForSeconds(1f);
            GameObject.Find("MenuContent/Logo").GetComponent<TextMeshProUGUI>().fontSize = 12;
            GameObject.Find("MenuContent/Logo").GetComponent<TextMeshProUGUI>().SetText("You are running XEngine V" + Version + "\n            \nEnjoy the client and have fun :)\r\n\r\nNews : Abyss is bassed on emm vrc do u know that");
            yield return new WaitForSeconds(4);
            GameObject.Find("MenuContent/Logo").SetActive(false);
            yield break;
        }
        public static string Version = "1.5";
    }
}
