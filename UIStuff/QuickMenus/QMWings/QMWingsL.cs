using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
namespace QuickMenus.QMWings
{
    internal class QMWingsL
    {
        public static IEnumerator Start()
        {
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Left/Container/InnerContainer/Background").GetComponent<Image>().color = Color.white;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Left/Container/InnerContainer/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMWingL_BG.png");
            yield break;
        }
    }
}
