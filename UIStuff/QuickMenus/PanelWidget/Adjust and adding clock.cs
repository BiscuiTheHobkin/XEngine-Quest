using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace QuickMenus.PanelWidget
{
    internal class Adjust_and_adding_clock
    {
        public static IEnumerator Start()
        {
            #region QM - Panel_QM_Widget
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Background").transform.position = new Vector3(0f, 1.702f, 0.85f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Background").transform.localPosition = new Vector3(512f, 0.1f, 0f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Background").transform.localScale = new Vector3(2.5f, 2f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/Notifications").transform.position = new Vector3(12.7751f, 5.1782f, 3.3158f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/Notifications").transform.localPosition = new Vector3(0.032f, -305.8109f, -75.5849f);
            #region Clock 
            new GameObject("Clock").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Clock").transform.position = new Vector3(-0.073f, 0.586f, 0.3158f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Clock").transform.localPosition = new Vector3(52.7304f, 56.5444f, 29.412f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Clock").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Clock").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Clock").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Clock").GetComponent<TextMeshProUGUI>().SetText("       " + DateTime.Now.ToString("HH:mm"));
            #endregion
            MelonCoroutines.Start(Qmnotification.Music.Start());
            #endregion
            yield break;
        }
    }
}
