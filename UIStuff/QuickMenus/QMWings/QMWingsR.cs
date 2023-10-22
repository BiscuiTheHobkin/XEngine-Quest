using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace QuickMenus.QMWings
{
    internal class QMWingsR
    {
        public static IEnumerator Start()
        {
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Right/Container/InnerContainer/Background").GetComponent<Image>().color = Color.white;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Right/Container/InnerContainer/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMWingR_BG.png");
            yield break;
        }
    }
}
