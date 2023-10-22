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
    internal class LoginUserPass
    {
        public static IEnumerator Init()
        {
            MelonLogger.Msg("-> Patch -> LoginUserPass");
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/VRChat_LOGO (1)").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/Panel").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/TextWelcome").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/ButtonBack (1)").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldPassword").GetComponent<Image>().color = Color.clear;
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldUser").GetComponent<Image>().color = Color.clear;
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/ButtonDone (1)").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/BoxLogin").GetComponent<Image>().color = Color.clear;

            yield break;
        }
    }
}
