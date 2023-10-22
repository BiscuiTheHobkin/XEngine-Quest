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
    internal class InputKeypadPopup
    {
        public static IEnumerator Init()
        {
            MelonLogger.Msg("-> Patch -> InputKeypadPopup");
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/Darkness").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/Rectangle").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/InputField").GetComponent<Image>().color = Color.red;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/Rectangle/Panel").GetComponent<Image>().color = Color.black;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/TitleText").GetComponent<Text>().color = Color.red;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/ButtonLeft").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/ButtonLeft/Text").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/ButtonRight").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/ButtonRight/Text").GetComponent<Text>().color = Color.blue;
            yield break;
        }
   }
}
