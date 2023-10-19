using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace TestMod.UIStuff
{
    internal class AlertPopup
    {
        public static IEnumerator Init()
        {
            MelonLogger.Log("-> Patch -> AlertPopup");
            GameObject.Find("MenuContent/Popups/AlertPopup/Darkness").gameObject.SetActive(false);
            //GameObject.Find("MenuContent/Popups/AlertPopup/Lighter").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("AlertPopupBG.png");
            GameObject.Find("MenuContent/Popups/AlertPopup/Lighter").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/AlertPopup/Button").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/AlertPopup/Button/Text").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/AlertPopup/BodyText").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/AlertPopup/TitleText").GetComponent<Text>().color = Color.blue;
            yield break;
        }
    }
}
