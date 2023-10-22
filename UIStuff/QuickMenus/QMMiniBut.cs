using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace QuickMenus
{
    internal class QMMiniBut
    {
        public static IEnumerator Start()
        {
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/MicButton").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Toggle_SafeMode").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            yield break;
        }
    }
}
