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
    internal class StandardPopupV2
    {
        public static IEnumerator Init()
        {
            MelonLogger.Msg("-> Patch -> StandardPopupV2");
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Darkness").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/BorderImage").GetComponent<Image>().color = Color.black;
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/Panel").GetComponent<Image>().color = Color.black;
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/ExitButton").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/Buttons/LeftButton").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/Buttons/RightButton").GetComponent<Image>().color = Color.blue;
            MelonLogger.Msg("-> Patch -> Done");
            yield break;
        }
    }
}
