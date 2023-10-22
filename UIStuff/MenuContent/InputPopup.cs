using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace UIStuff
{
    internal class InputPopup
    {
        public static IEnumerator Init()
        {
            MelonLogger.Msg("-> Patch -> InputPopup");
            GameObject.Find("MenuContent/Popups/InputPopup/Darkness").GetComponent<Image>().gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/InputPopup/Darkness").GetComponent<Image>().color = Color.white;
            GameObject.Find("MenuContent/Popups/InputPopup/Rectangle").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/InputPopup/ButtonRight").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputPopup/ButtonRight/Text").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputPopup/ButtonLeft").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputPopup/ButtonLeft/Text").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputPopup/PasswordVisibilityToggle").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputPopup/InputField").GetComponent<Image>().color = Color.black;
            GameObject.Find("MenuContent/Popups/InputPopup/TitleText").GetComponent<Text>().color = Color.red;
            yield break;
        }
   }
}
