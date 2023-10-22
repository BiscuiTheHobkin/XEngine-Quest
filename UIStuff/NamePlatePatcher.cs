using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using MelonLoader;

namespace UIStuff
{
    internal class NamePlatePatcher
    {
        public static IEnumerator Init()
        {
            while (GameObject.Find("NameplateContainer") == null)
            {
                yield return null;
            }
            yield return new WaitForSeconds(5);
            #region Nameplate/Contents/Main
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Main/Background").GetComponent<MaskableGraphic>().color = new Color(0.2f, 0.0f, 0.0f, 1.0f);
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Main/Glow").GetComponent<MaskableGraphic>().color = new Color(1f, 0.1400024f, 0.0f, 1.0f);
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Main/Pulse").GetComponent<MaskableGraphic>().color = new Color(1f, 0f, 0.08f, 1.0f);
            #endregion
            #region Main/Text Container
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Main/Text Container/Name").GetComponent<TextMeshProUGUI>().color = new Color(1f, 0f, 0.08f, 1.0f);
            #endregion
            #region Nameplate/Contents/Icon
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Icon/Glow").GetComponent<MaskableGraphic>().color = new Color(1f, 0.1400024f, 0.0f, 1.0f);
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Icon/Pulse").GetComponent<MaskableGraphic>().color = new Color(1f, 0f, 0.08f, 1.0f);
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Icon/Background").GetComponent<Image>().color = new Color(0.3f, 0f, 0.3196226f, 1.0f);
            #endregion
            #region Nameplate/Contents/Quick Stats
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Quick Stats").GetComponent<MaskableGraphic>().color = new Color(0.3f, 0f, 0f, 1.0f);
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Quick Stats").transform.position = new Vector3(-0.9521f, 1.825f, 7.0778f);
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Quick Stats").transform.localPosition = new Vector3(-13.8414f, -59.1288f, 0.0069f);
            #endregion
            #region Nameplate/Contents/Group Info
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Group Info").GetComponent<MaskableGraphic>().color = new Color(0.3f, 0.0f, 0.0f, 1.0f);
            #endregion
            #region NameplateContainer/ChatBubble
            GameObject.Find("NameplateManager/NameplateContainer/ChatBubble/Canvas/TypingIndicator").GetComponent<MaskableGraphic>().color = new Color(0.3f, 0.0f, 0.0f, 1.0f);
            GameObject.Find("NameplateManager/NameplateContainer/ChatBubble/Canvas/Chat").GetComponent<MaskableGraphic>().color = new Color(0.3f, 0.0f, 0.0f, 1.0f);
            GameObject.Find("NameplateManager/NameplateContainer/ChatBubble/Canvas/Chat/ChatText").GetComponent<TextMeshProUGUI>().color = new Color(1f, 0.0f, 0.0f, 1.0f);
            #endregion
            MelonCoroutines.Start(UIStuff.NamePlatePatcher.Init());
            yield break;
        }
   }
}
