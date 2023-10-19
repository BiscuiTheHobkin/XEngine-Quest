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
    internal class StandardPopup
    {
        public static IEnumerator Init()
        {
            MelonLogger.Log("-> Patch -> StandardPopup");
            GameObject.Find("MenuContent/Popups/StandardPopup/Rectangle").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopup/ArrowRight").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopup/ArrowLeft").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopup/ProgressLine").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopup/LowPercent").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopup/HighPercent").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopup/MidRing").GetComponent<Image>().color = Color.red;
            GameObject.Find("MenuContent/Popups/StandardPopup/InnerDashRing").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopup/RingGlow").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopup/ButtonMiddle").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/StandardPopup/TitleText").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/StandardPopup/BodyText").GetComponent<Text>().color = Color.blue;
            yield break;
        }
    }
}
