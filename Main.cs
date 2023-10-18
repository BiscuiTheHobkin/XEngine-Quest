#region Using shit
using Cysharp.Threading.Tasks.Linq;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;
using Il2CppSystem.Collections.Generic;
using TMPro;
using VRC;
using VRC.Udon;
using Il2CppSystem.Diagnostics;
using VRC.Core;
using VRC.SDKBase;
using VRCSDK2;
using Photon.SocketServer;
using static VRC.Dynamics.CollisionShapes;
using Color = UnityEngine.Color;
using static MelonLoader.MelonLogger;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Math.EC;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Asn1.Cms;
using Harmony;
using Cysharp.Threading.Tasks.Triggers;
using Photon;
using UnityEngine.InputSystem;
using static BestHTTP.PlatformSupport.TcpClient.General.TcpClient;
using System.Diagnostics;
using System.Reflection;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine.Events;
using VRC.UI.Elements;
using Object = UnityEngine.Object;
using VRC.Core.Pool;
using VRC.SDK3.Network;
using VRC.UI.Core.Styles;
using VRC.UI.Elements.Controls;
using HarmonyLib;
using UnhollowerBaseLib;
using static Il2CppSystem.Xml.XmlWellFormedWriter.AttributeValueCache;
using WebSocketSharp;
using System.Net;
using VRC.UI.Elements.Menus;
using VRC.UI;
using VRC.SDK3.Components;
using VRC.Udon.Common.Interfaces;
using static VRC.SDKBase.VRC_SpecialLayer;
using VRC.SDK3.Image;
using Photon.Realtime;
using ExitGames.Client.Photon;
using System.Text;
using X_Engine_stayoffnigga;
using static VRC.Core.Logger;
#endregion


namespace TestMod
#region Mod Info
{
    public static class BuildInfo
    {
        public const string Name = "XEngine-Quest";
        public const string Description = null;
        public const string Author = "Biscuit and him only :D";
        public const string Company = "X-Core-Project";
        public const string Version = "1.0";
        public const string DownloadLink = null;
    }
    #endregion


    public class TestMod : MelonMod
    {
        [Obsolete]
        public override void OnApplicationStart()
        {
        #region WaitForUi
            MelonCoroutines.Start(WaitForUi());
            MelonLogger.Log("Waiting For UI...");
            MelonCoroutines.Start(WaitForMenus());
            MelonLogger.Log("Waiting for Qm/Mm Menus...");
            ClassInjector.RegisterTypeInIl2Cpp<stayoffnigga>();
        }
        private IEnumerator WaitForUi()
        {
            while (GameObject.Find("MenuContent") == null)
            {
                yield return null;
            }
            #region Start Init
            MelonCoroutines.Start(firstloadingmusic.FirstLoadingMusic.Start());
            MelonCoroutines.Start(LoadingMusic.Music.Start());
            MelonCoroutines.Start(GoButton.Music.Start());
            MelonCoroutines.Start(Inputpopup.Music.Start());
            MelonCoroutines.Start(InputKeypadPopup.Music.Start());
            MelonCoroutines.Start(ShowLogo());
            #endregion
            #region LogoContainer
            MelonLogger.Log("-> Patch -> LogoContainer");
            GameObject.Find("MenuContent/Screens/Title/LogoContainer/vrchatlogo2sided").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Title/Panel").gameObject.SetActive(false);
            #endregion
            #region Backdrop Not inplemented
            //MelonLogger.Log("-> Patch -> Backdrop");
            //GameObject.Find("MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("MMBG.png");
            //GameObject.Find("MenuContent/Backdrop/Backdrop/Background").GetComponent<Image>().color = Color.white;
            #endregion
            #region AlertPopup
            MelonLogger.Log("-> Patch -> AlertPopup");
            GameObject.Find("MenuContent/Popups/AlertPopup/Darkness").gameObject.SetActive(false);
            //GameObject.Find("MenuContent/Popups/AlertPopup/Lighter").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("AlertPopupBG.png");
            GameObject.Find("MenuContent/Popups/AlertPopup/Lighter").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/AlertPopup/Button").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/AlertPopup/Button/Text").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/AlertPopup/BodyText").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/AlertPopup/TitleText").GetComponent<Text>().color = Color.blue;
            #endregion  
            #region LoadingBackground
            MelonLogger.Log("-> Patch -> LoadingBackground");
            GameObject.Find("LoadingBackground_TealGradient_Music/SkyCube_Baked").gameObject.SetActive(false);
            GameObject.Find("LoadingBackground_TealGradient_Music/_FX_ParticleBubbles/FX_snow").GetComponent<ParticleSystem>().startColor = Color.red;
            GameObject.Find("LoadingBackground_TealGradient_Music/_FX_ParticleBubbles/FX_snow").GetComponent<ParticleSystem>().startSpeed = 3;
            #endregion
            #region LoadingScreen
            MelonLogger.Log("-> Patch -> LoadingPopup");
            GameObject.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/SkyCube_Baked").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").transform.position = new Vector3(-0.0068f, 1.17f, 1.2724f);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").transform.localPosition = new Vector3(0.25f, -124.3375f, 0.5001f);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").transform.localScale = new Vector3(0.7f, 2.9f, 5f);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Left").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Right").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/LOADING_BAR_BG").GetComponent<Image>().color = Color.gray;
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements").transform.localScale = new Vector3(0.9f, 0.9f, 0.1f);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING_Size").GetComponent<Text>().color = Color.red;
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING_Size").transform.position = new Vector3(-0.06f, 1.25f, 1.272f);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING_Size").transform.localPosition = new Vector3(-127.6389f, -13.5694f, 0f);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_Percent").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/LOADING_BAR").GetComponent<Image>().color = Color.green;
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton/Text").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/LoadingPopup/ButtonMiddle").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/LoadingPopup/ButtonMiddle/Text").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_snow").GetComponent<ParticleSystem>().startColor = Color.red;
            #endregion
            #region StandardPopup
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
            #endregion
            #region Authentication
            MelonLogger.Log("-> Patch -> Authentication");
            GameObject.Find("MenuContent/Screens/Authentication/OculusStoreLoginPrompt/VRChat_LOGO (1)").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/OculusStoreLoginPrompt/TextWelcome").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/OculusStoreLoginPrompt/VRChatButtonLogin").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Screens/Authentication/OculusStoreLoginPrompt/StoreButtonLogin (1)").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonCreate").GetComponent<Image>().color = Color.blue;
            #endregion
            #region LoginUserPass
            MelonLogger.Log("-> Patch -> LoginUserPass");
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/VRChat_LOGO (1)").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/Panel").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/TextWelcome").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/ButtonBack (1)").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldPassword").GetComponent<Image>().color = Color.clear;
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldUser").GetComponent<Image>().color = Color.clear;
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/ButtonDone (1)").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Screens/Authentication/LoginUserPass/BoxLogin").GetComponent<Image>().color = Color.clear;
            #endregion
            #region InputPopup
            MelonLogger.Log("-> Patch -> InputPopup");
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
            #endregion
            #region InputKeypadPopup
            MelonLogger.Log("-> Patch -> InputKeypadPopup");
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/Darkness").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/Rectangle").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/InputField").GetComponent<Image>().color = Color.red;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/Rectangle/Panel").GetComponent<Image>().color = Color.black;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/TitleText").GetComponent<Text>().color = Color.red;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/ButtonLeft").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/ButtonLeft/Text").GetComponent<Text>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/ButtonRight").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/InputKeypadPopup/ButtonRight/Text").GetComponent<Text>().color = Color.blue;
            #endregion
            #region StandardPopupV2
            MelonLogger.Log("-> Patch -> StandardPopupV2");
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Darkness").gameObject.SetActive(false);
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/BorderImage").GetComponent<Image>().color = Color.black;
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/Panel").GetComponent<Image>().color = Color.black;
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/ExitButton").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/Buttons/LeftButton").GetComponent<Image>().color = Color.blue;
            GameObject.Find("MenuContent/Popups/StandardPopupV2/Popup/Buttons/RightButton").GetComponent<Image>().color = Color.blue;
            MelonLogger.Log("-> Patch -> Done");
            MelonLogger.Log("Waiting for quickmenu...");
            #endregion
            #endregion
        }

        #region ShowLogo
        private IEnumerator ShowLogo()
        {
            while (GameObject.Find("StandardPopup") == null)
            {
                yield return null;
            }
            yield return new WaitForSeconds(2);
            new GameObject("Logo").transform.parent = GameObject.Find("MenuContent").transform;
            GameObject.Find("MenuContent/Logo").transform.position = new Vector3(-0.007f, 1.5623f, 0.78f);
            GameObject.Find("MenuContent/Logo").transform.localPosition = new Vector3(0f, 0.0375f, 0f);
            GameObject.Find("MenuContent/Logo").transform.localScale = new Vector3(3f, 3f, 3f);
            MelonCoroutines.Start(ShowLogoSound.Music.Start());
            GameObject.Find("MenuContent/Logo").AddComponent<TextMeshProUGUI>();
            GameObject.Find("MenuContent/Logo").GetComponent<TextMeshProUGUI>().fontSize = 12;
            GameObject.Find("MenuContent/Logo").GetComponent<TextMeshProUGUI>().SetText("Welcome Back : " + APIUser.CurrentUser.displayName.ToString());
            MelonCoroutines.Start(ShowLogoSound.Music.Start());
            yield return new WaitForSeconds(1f);
            GameObject.Find("MenuContent/Logo").GetComponent<TextMeshProUGUI>().fontSize = 12;
            GameObject.Find("MenuContent/Logo").GetComponent<TextMeshProUGUI>().SetText("You are running XEngine V" +Version+"\n            \nEnjoy the client and have fun :)");
            yield return new WaitForSeconds(4);
            GameObject.Find("MenuContent/Logo").SetActive(false);
        }
        #endregion
        #region Quickmenu custom ui
        [Obsolete]
        private IEnumerator WaitForMenus()
        {
            while (GameObject.Find("Canvas_QuickMenu(Clone)") == null)
            {
                yield return null;
            }
            #region console shit
            MelonLogger.Log(" ,--,     ,--,     ,---,.                                                       ");
            MelonLogger.Log(" |'. \\   / .`|   ,'  .' |                         ,--,                          ");
            MelonLogger.Log(" ; \\ `\\ /' / ; ,---.'   |      ,---,            ,--.'|         ,---,            ");
            MelonLogger.Log(" `. \\  /  / .' |   |   .'  ,-+-. /  |  ,----._,.|  |,      ,-+-. /  |           ");
            MelonLogger.Log("  \\  \\/  / ./  :   :  |-, ,--.'|'   | /   /  ' /`--'_     ,--.'|'   |   ,---.   ");
            MelonLogger.Log("   \\  \\.'  /   :   |  ;/||   |  ,\"' ||   :     |,' ,'|   |   |  ,\"' |  /     \\  ");
            MelonLogger.Log("    \\  ;  ;    |   :   .'|   | /  | ||   | .\\  .'  | |   |   | /  | | /    /  | ");
            MelonLogger.Log("   / \\  \\  \\   |   |  |-,|   | |  | |.   ; ';  ||  | :   |   | |  | |.    ' / | ");
            MelonLogger.Log("  ;  /\\  \\  \\  '   :  ;/||   | |  |/ '   .   . |'  : |__ |   | |  |/ '   ;   /| ");
            MelonLogger.Log("./__;  \\  ;  \\ |   |    \\|   | |--'   `---`-'| ||  | '.'||   | |--'  '   |  / | ");
            MelonLogger.Log("|   : / \\  \\  ;|   :   .'|   |/       .'__/\\_: |;  :    ;|   |/      |   :    | ");
            MelonLogger.Log(";   |/   \\  ' ||   | ,'  '---'        |   :    :|  ,   / '---'        \\   \\  /  ");
            MelonLogger.Log("`---'     `--` `----'                  \\   \\  /  ---`-'                `----'   ");
            MelonLogger.Log("                                        `--`-'                                  ");
            MelonLogger.Log("");
            MelonLogger.Log("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            MelonLogger.Log("- - - Welcomme back : " + APIUser.CurrentUser.displayName.ToString() + " - - - -");
            MelonLogger.Log("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            MelonLogger.Log("- - - Client Vesion : " + Version + " - - - -");
            MelonLogger.Log("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            MelonLogger.Log("- - Credit : fueltoguy for loadingcustomaudio - voided_space for playerlist - - ");
            MelonLogger.Log("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            #endregion
            #region qm init
            MelonCoroutines.Start(QmObjectenabler());
            MelonLogger.Log("Menus found wait : 8s before patch...");
            yield return new WaitForSeconds(8);
            MelonLogger.Log("ClientVRUI -> Started");
            MelonLogger.Log("ClientVRUI -> QM - Dashboard -> Init...");
            #region QM - Dashboard
            #region QM - Dashboard - VRC+_Banners
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners/SupportVRChat").gameObject.SetActive(false);
            GameObject.DestroyImmediate(GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners/ThankYouMM"));
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().SetText("\n       " +DateTime.Now.ToString("HH:mm:ss")+ " -> Welcome Back : " + APIUser.CurrentUser.displayName.ToString()+"\n       ------------------------------------------\n"+"       "+DateTime.Now.ToString("HH:mm:ss")+" -> Recent Log : Have Fun using XEngine <3");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().fontSize = 28;
            GameObject.DestroyImmediate(GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Carousel_Banners"));
            #endregion
            #region QM - Dashboard - text 
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/Header_H1/HeaderBackground").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title").GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title").GetComponentInChildren<TextMeshProUGUI>().SetText("XEngine");
            #endregion
            #region QM - Dashboard - QuickLink
            #region Button_Worlds
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Icon").GetComponent<Image>().color = Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
            #region Button_Avatars
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Icon").GetComponent<Image>().color = Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
            #region Button_Social
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Icon").GetComponent<Image>().color = Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
            #region Button_ViewGroups
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_ViewGroups/Icon").GetComponent<Image>().color = Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_ViewGroups/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
            #endregion
            #region QM - Dashboard - QuickActions
            #region Button_GoHome
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Icon").GetComponent<Image>().color = Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
            #region Button_Respawn
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Icon").GetComponent<Image>().color= Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
            #region Button_SitStand
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_Off").GetComponent<Image>().color= Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_On").GetComponent<Image>().color= Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Safety/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_SelectUser/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
            #endregion
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
            #region QM - Wing_Left
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Left/Container/InnerContainer/Background").GetComponent<Image>().color = Color.white;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Left/Container/InnerContainer/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMWingL_BG.png");
            #endregion
            #region QM - Wing_Right
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Right/Container/InnerContainer/Background").GetComponent<Image>().color = Color.white;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Wing_Right/Container/InnerContainer/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMWingR_BG.png");
            #endregion
            #region QM - BackGround
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/BackgroundLayer01").GetComponent<Image>().color = Color.white;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/BackgroundLayer01").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMBG.png");
            #endregion
            #region QM - mini button
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/MicButton").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Toggle_SafeMode").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
            #region QM - Tooltip
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/ToolTipPanel/Panel/Vertical Layout/Text_H3").GetComponentInChildren<TextMeshProUGUI>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            #endregion
            MelonLogger.Log("ClientVRUI -> QM - Dashboard -> Pass");
            #region TextColorPatcher
            TextMeshProUGUI[] textComponents = GameObject.FindObjectsOfType<TextMeshProUGUI>();

            foreach (TextMeshProUGUI textComponent in textComponents)
            {
                textComponent.color = Color.red;
            }

            MelonCoroutines.Start(QMClock());
            MelonCoroutines.Start(XEngineMenus());
            MelonCoroutines.Start(MMMenus());
            MelonCoroutines.Start(MicIconPatcher());
            MelonCoroutines.Start(AMPatcher());
        }
        private IEnumerator QmObjectenabler()
        {
            while (GameObject.Find("Canvas_QuickMenu(Clone)") == null)
            {
                yield return null;
            }
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Notifications").SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Here").SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Camera").SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_QM_AudioSettings").SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_QM_GeneralSettings").SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools").SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Modal_ConfirmDialog").SetActive(true);
            yield return new WaitForSeconds(5);
            MelonCoroutines.Start(Menu_Notifications());
            yield return new WaitForSeconds(1);
            MelonCoroutines.Start(Menu_Camera());
        }
        #region Menu_SelectedUser

        private IEnumerator Menu_SelectedUser()
        {
            while (GameObject.Find("Menu_SelectedUser_Remote") == null)
            {
                yield return null;
            }
        }

        #endregion
        #endregion
        #endregion
        #region QuickMenu custom page ui
        #region Menu_Notifications
        private IEnumerator Menu_Notifications()
        {
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Notifications").SetActive(true);
            while (GameObject.Find("Menu_Notifications") == null)
            {
                yield return null;
            }
            yield return new WaitForSeconds(1);
            GameObject.DestroyImmediate(GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Notifications/QMHeader_H1/HeaderBackground"));
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Notifications/QMHeader_H1/LeftItemContainer/Text_Title").GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Notifications/QMHeader_H1/RightItemContainer/Button_QM_Expand/Icon").GetComponentInChildren<Image>().color = Color.red;

        }
        #endregion
        #region Menu_Camera
        private IEnumerator Menu_Camera()
        {
            while (GameObject.Find("Menu_Camera") == null)
            {
                yield return null;
            }
            #region Header
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Camera/Header_Camera/LeftItemContainer/Text_Title").GetComponent<TextMeshProUGUI>().SetText("Cumera");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Camera/Header_Camera/RightItemContainer/Button_QM_Expand/Icon").GetComponent<Image>().color = Color.red;
            #endregion
            #region Button
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Camera/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Button_PhotoCamera/Icon").GetComponent<Image>().color = Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Camera/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Button_PhotoCamera/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            #endregion
        }
        #endregion

        #endregion
        #endregion
        #region MMenus
        private IEnumerator MMMenus()
        {
            while (GameObject.Find("Canvas_MainMenu(Clone)") == null)
            {
                yield return null;
            }
            #region MainMenu
            MelonLogger.Log("ClientVRUI -> MainMenu -> Init...");
            #region MM Background
            GameObject.Find("Canvas_MainMenu(Clone)/Container/MMParent/BackgroundLayer01").GetComponent<Image>().color = Color.white;
            GameObject.Find("Canvas_MainMenu(Clone)/Container/MMParent/BackgroundLayer01").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("MM/MMBG.png");
            #endregion
            #region Wing_Left
            GameObject.Find("Canvas_MainMenu(Clone)/Container/Wing_Left/Container/InnerContainer/Background").GetComponent<Image>().color = Color.white;
            GameObject.Find("Canvas_MainMenu(Clone)/Container/Wing_Left/Container/InnerContainer/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("MM/MMWingL_BG.png");
            #endregion
            #region Wing_Right
            GameObject.Find("Canvas_MainMenu(Clone)/Container/Wing_Right/Container/InnerContainer/Background").GetComponent<Image>().color = Color.white;
            GameObject.Find("Canvas_MainMenu(Clone)/Container/Wing_Right/Container/InnerContainer/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("MM/MMWingR_BG.png");
            #endregion
            #region Tooltip text
            GameObject.Find("Canvas_MainMenu(Clone)/Container/ToolTipPanel/Panel/Vertical Layout/Text_MM_H2").GetComponent<TextMeshProUGUI>().color = Color.red;
            #endregion
            MelonLogger.Log("ClientVRUI -> MainMenu -> Pass");
            #endregion

        }
        #endregion
        #region Client Page
        private IEnumerator XEngineMenus()
        {
            while (GameObject.Find("Canvas_QuickMenu(Clone)") == null)
            {
                yield return null;
            }
            #region RemoveOreginalButton
            MelonLogger.Log("ClientVRUI -> Building XEngineMenu...");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Header_DevTools/LeftItemContainer/Text_Title").GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Header_DevTools/LeftItemContainer/Text_Title").GetComponentInChildren<TextMeshProUGUI>().SetText("XEClient : V" + Version);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Button_WarpAllToHub").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Button_WarpAllToNewInstance").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Button_Invisible").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Button_Tag").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools/Icon").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/MenuIcon.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools").gameObject.SetActive(true);
            #endregion
            #region Making Utils Join by id button (XJWBID) --
            new GameObject("Space1").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space1").transform.position = new Vector3(-0.07f, 0.2313f, 0.3653f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space1").transform.localPosition = new Vector3(22.8375f, -1.452f, -2.626f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space1").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space1").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space1").AddComponent<RectTransform>();
            #region Utils Page
            #region button
            new GameObject("XUtilsPage").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/Buttonbg.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").transform.position = new Vector3(-0.0901f, 1.2759f, 0.9607f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)utilspageshow);
            #endregion
            #region text 
            new GameObject("text").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage/text").transform.position = new Vector3(-0.021f, 0.38f, 0.2219f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage/text").transform.localPosition = new Vector3(47.6614f, 6.1783f, -2.6479f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage/text").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage/text").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage/text").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Utils\nPage");
            #endregion
            #endregion
            #region Send an Hi By udon event button (XSAHBUE)
            #region Button
            new GameObject("XSAHBUE").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/Buttonbg.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").transform.position = new Vector3(-0.0901f, 1.2759f, 0.9607f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XSAHBUE);
            #endregion
            #region Text
            new GameObject("text").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE/text").transform.position = new Vector3(-0.07f, 0.2313f, 0.3653f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE/text").transform.localPosition = new Vector3(22.8375f, -1.452f, -2.626f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE/text").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE/text").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE/text").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE/text").GetComponentInChildren<TextMeshProUGUI>().SetText(" Send HI");
            #endregion
            #endregion
            #region space2
            new GameObject("Space2").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space2").transform.position = new Vector3(-0.07f, 0.2313f, 0.3653f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space2").transform.localPosition = new Vector3(22.8375f, -1.452f, -2.626f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space2").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space2").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space2").AddComponent<RectTransform>();
            #endregion
            #region Game Hack page

            new GameObject("XMshowhack").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/Buttonbg.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").transform.position = new Vector3(0.069f, 0.61f, 0.535f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XMurdershowbutton);
            new GameObject("text").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").transform.position = new Vector3(-0.0971f, 0.5069f, 0.3932f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").transform.localPosition = new Vector3(36.8766f, 27.7433f, -13.7129f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Show\nmurder4 \nhack");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").GetComponentInChildren<TextMeshProUGUI>().fontSize = 30;

            #endregion
        }
        #endregion

        #region Utils
        public void utilspageshow() //Added
        {
            #region XJWBID
            #region XJWBID Button
            new GameObject("XJWBID").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/Buttonbg.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").transform.position = new Vector3(-0.0901f, 1.2759f, 0.9607f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XJWBID);
            #endregion
            #region XJWBID Text
            new GameObject("text").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID/text").transform.position = new Vector3(-0.07f, 0.2313f, 0.3653f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID/text").transform.localPosition = new Vector3(22.8375f, -1.452f, -2.626f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID/text").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID/text").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID/text").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Join by id");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").gameObject.SetActive(true);
            #endregion
            #endregion
            #region disable main page stuff
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space1").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space2").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Go\nBack");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)utilspagehide);
            #endregion
        }
        public void XJWBID() //Added
        {
            string path = "XEngine/JoinByTextID.txt";
            Networking.GoToRoom(System.IO.File.ReadAllText(path));
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().SetText("\n       " + DateTime.Now.ToString("HH:mm:ss") + " -> Welcome Back : " + APIUser.CurrentUser.displayName.ToString() + "\n       ------------------------------------------\n" + "       " + DateTime.Now.ToString("HH:mm:ss") + " -> Recent Log : Join by id | Joining Romm : " + System.IO.File.ReadAllText(path) + "...");
        }

        public void XSAHBUE() //Added
        {
            GameObject.FindObjectOfType<UdonBehaviour>().gameObject.GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "HiFromEXClient");
            MelonLogger.Log("Hi Sended");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().SetText("\n       " + DateTime.Now.ToString("HH:mm:ss") + " -> Welcome Back : " + APIUser.CurrentUser.displayName.ToString() + "\n       ------------------------------------------\n" + "       " + DateTime.Now.ToString("HH:mm:ss") + " -> Recent Log : HI | Sending...");
            #region udonlogger
            /*UdonBehaviour[] gameObjects = GameObject.FindObjectsOfType<UdonBehaviour>();

            foreach (UdonBehaviour gameObject in gameObjects)
            {
                MelonLogger.Log("UdonBehaviour Name: " + gameObject.name);      
            }*/
            #endregion
        }
        public void utilspagehide() //Added
        {
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XJWBID").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space1").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space2").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Utils\nPage");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)utilspageshow);
        }
        #endregion
        #region Merderfunc
        public void XMurdershowbutton() //added
        {
            #region Murder Stuff
            #region StartMerdurGame (MStart)
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Hide\nmurder4 \nhack");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").GetComponentInChildren<TextMeshProUGUI>().fontSize = 30;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XMHideButton);
            #region Button
            new GameObject("MSStartG").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/Buttonbg.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG").transform.position = new Vector3(-0.0901f, 1.2759f, 0.9607f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XMStart);
            #endregion
            #region Text
            new GameObject("text").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG/text").transform.position = new Vector3(0.069f, 0.61f, 0.535f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG/text").transform.localPosition = new Vector3(32.9992f, 40.0735f, -16.3239f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG/text").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG/text").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG/text").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Murder4\nstart\ngame");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG/text").GetComponentInChildren<TextMeshProUGUI>().fontSize = 30;
            #endregion
            #endregion
            #region XMKillAll (XMKE)
            #region Button
            new GameObject("MKE").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/Buttonbg.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").transform.position = new Vector3(-0.0901f, 1.2759f, 0.9607f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XMKillAll);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").gameObject.SetActive(true);
            #endregion
            #region Text
            new GameObject("text").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE/text").transform.position = new Vector3(0.069f, 0.61f, 0.535f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE/text").transform.localPosition = new Vector3(32.9992f, 40.0735f, -16.3239f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE/text").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE/text").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE/text").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Murder4\nKill All");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE/text").GetComponentInChildren<TextMeshProUGUI>().fontSize = 30;
            #endregion
            #endregion
            #region XMShowAllRoles (RERS)
            #region Button
            new GameObject("RERS").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/Buttonbg.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").transform.position = new Vector3(-0.0901f, 1.2759f, 0.9607f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XMShowAllRoles);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").gameObject.SetActive(true);
            #endregion
            #region Text
            new GameObject("text").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS/text").transform.position = new Vector3(0.069f, 0.61f, 0.535f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS/text").transform.localPosition = new Vector3(32.9992f, 40.0735f, -16.3239f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS/text").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS/text").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS/text").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Murder4\nReshowing\nall budy \nrules");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS/text").GetComponentInChildren<TextMeshProUGUI>().fontSize = 25;
            #endregion
            #endregion
            #region XMBlindAll (MBEB)
            #region Button
            new GameObject("MBEB").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/Buttonbg.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").transform.position = new Vector3(-0.0901f, 1.2759f, 0.9607f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XMBlindAll);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").gameObject.SetActive(true);
            #endregion
            #region Text
            new GameObject("text").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB/text").transform.position = new Vector3(0.069f, 0.61f, 0.535f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB/text").transform.localPosition = new Vector3(32.9992f, 40.0735f, -16.3239f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB/text").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB/text").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB/text").AddComponent<TextMeshProUGUI>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Murder4\nBlind\nAll");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB/text").GetComponentInChildren<TextMeshProUGUI>().fontSize = 30;
            #endregion
            #endregion
            #region XMFlashs Everyone (MFEO)
            new GameObject("MFEO").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/XMD4H/MFEO.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO").transform.position = new Vector3(-0.0901f, 1.2759f, 0.9607f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XMCamFlash);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO").gameObject.SetActive(true);
            #endregion
            #region Release snake (MRSS)
            new GameObject("MRSS").transform.parent = GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons").transform;
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS").AddComponent<Image>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("XEButton/XMD4H/MRSS.png");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS").transform.position = new Vector3(-0.0901f, 1.2759f, 0.9607f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS").transform.localPosition = new Vector3(0.041f, 0.1226f, 0.0131f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS").transform.localRotation = Quaternion.Euler(0, 0, 0);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS").transform.localScale = new Vector3(1f, 1f, 1f);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS").AddComponent<Button>();
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XMSNAKE);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS").gameObject.SetActive(true);
            #endregion
            #region disable ui stuff 
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space1").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").gameObject.SetActive(false);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space2").gameObject.SetActive(false);
            #endregion
            #endregion
        }

        public void XMStart() //added
        {
            GameObject.Find("Game Logic").GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "SyncStartGame");
            MelonLogger.Log("Trying to force start Match...");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().SetText("\n       " + DateTime.Now.ToString("HH:mm:ss") + " -> Welcome Back : " + APIUser.CurrentUser.displayName.ToString() + "\n       ------------------------------------------\n" + "       " + DateTime.Now.ToString("HH:mm:ss") + " -> Recent Log : Murder 4 | Trying to force start Match...");
        }
        public void XMKillAll() //added
        {
            GameObject.Find("Game Logic").GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "KillLocalPlayer");
            MelonLogger.Log("Killing All...");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().SetText("\n       " + DateTime.Now.ToString("HH:mm:ss") + " -> Welcome Back : " + APIUser.CurrentUser.displayName.ToString() + "\n       ------------------------------------------\n" + "       " + DateTime.Now.ToString("HH:mm:ss") + " -> Recent Log : Murder 4 | Killing All...");
        }
        public void XMShowAllRoles() //added
        {
            GameObject.Find("Game Logic").GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "OnLocalPlayerAssignedRole");
            MelonLogger.Log("Reshowing Everyones Roles...");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().SetText("\n       " + DateTime.Now.ToString("HH:mm:ss") + " -> Welcome Back : " + APIUser.CurrentUser.displayName.ToString() + "\n       ------------------------------------------\n" + "       " + DateTime.Now.ToString("HH:mm:ss") + " -> Recent Log : Murder 4 | Reshowing Everyones Roles...");
        }
        public void XMBlindAll() //added
        {
            GameObject.Find("Game Logic").GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "OnLocalPlayerBlinded");
            MelonLogger.Log("Blinding EveryBody...");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().SetText("\n       " + DateTime.Now.ToString("HH:mm:ss") + " -> Welcome Back : " + APIUser.CurrentUser.displayName.ToString() + "\n       ------------------------------------------\n" + "       " + DateTime.Now.ToString("HH:mm:ss") + " -> Recent Log : Murder 4 | Blinding EveryBody...");
        }
        public void XMCamFlash() //added
        {
            GameObject.Find("Game Logic").GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "OnLocalPlayerFlashbanged");
            MelonLogger.Log("Flashsing Everyone...");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().SetText("\n       " + DateTime.Now.ToString("HH:mm:ss") + " -> Welcome Back : " + APIUser.CurrentUser.displayName.ToString() + "\n       ------------------------------------------\n" + "       " + DateTime.Now.ToString("HH:mm:ss") + " -> Recent Log : Murder 4 | Flashsing Everyone...");
        }
        public void XMSNAKE() // added
        {
            GameObject.Find("Game Logic/Snakes/SnakeDispenser").GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "DispenseSnake");
            MelonLogger.Log("Releasing Snakes...");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/VRC+_Banners").GetComponentInChildren<TextMeshProUGUI>().SetText("\n       " + DateTime.Now.ToString("HH:mm:ss") + " -> Welcome Back : " + APIUser.CurrentUser.displayName.ToString() + "\n       ------------------------------------------\n" + "       " + DateTime.Now.ToString("HH:mm:ss") + " -> Recent Log : Murder 4 | Releasing Snakes...");
        }
        public void XMHideButton() // added
        {
            GameObject.DestroyImmediate(GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/RERS"));
            GameObject.DestroyImmediate(GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MBEB"));
            GameObject.DestroyImmediate(GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MFEO"));
            GameObject.DestroyImmediate(GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MRSS"));
            GameObject.DestroyImmediate(GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MSStartG"));
            GameObject.DestroyImmediate(GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/MKE"));
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space1").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XUtilsPage").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XSAHBUE").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/Space2").gameObject.SetActive(true);
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack/text").GetComponentInChildren<TextMeshProUGUI>().SetText("Show\nmurder4 \nhack");
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport/VerticalLayoutGroup/Buttons/XMshowhack").GetComponent<Button>().onClick.AddListener((UnityEngine.Events.UnityAction)XMurdershowbutton);
        }
        #endregion
        #endregion
        //************
        #region QMClock
        private IEnumerator QMClock()
        {
            while (GameObject.Find("Canvas_QuickMenu(Clone)") == null)
            {
                yield return null;
            }
            GameObject.Find("Canvas_QuickMenu(Clone)/CanvasGroup/Container/Window/Panel_QM_Widget/DebugInfoPanel/Panel/Clock").GetComponent<TextMeshProUGUI>().SetText("       " + DateTime.Now.ToString("HH:mm"));
            yield return new WaitForSeconds(10);
            MelonCoroutines.Start(QMClock());
        }
        #endregion
        #region ActionMenuPatcher
        private IEnumerator AMPatcher()
        {
            while (GameObject.Find("MenuR") == null)
            {
                yield return null;
            }
            #region MenuR
            GameObject.Find("ActionMenu/Container/MenuR/ActionMenu/Main/Background").GetComponent<MaskableGraphic>().color = Color.blue;
            #endregion
        }
        #endregion
        #region MicIconPatcher
        private IEnumerator MicIconPatcher()
        {
            while (GameObject.Find("MicIcon") == null)
            {
                yield return null;
            }
            #region MicColorAndCustomIcon
            MelonLogger.Log("ClientVRUI -> Micolor -> Init...");
            GameObject.Find("UnscaledUI/HudContent/HUD_UI 2(Clone)/VR Canvas/Container/Left/Icons/Mic/MicIcon").GetComponent<Image>().color = Color.red;
            GameObject.Find("UnscaledUI/HudContent/HUD_UI 2(Clone)/VR Canvas/Container/Left/Icons/Mic/MicIcon").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("MicIcon.png");
            MelonLogger.Log("ClientVRUI -> Micolor -> Pass");
            #endregion
        }
        #endregion
        #region NamePlatePatcher
        private IEnumerator NamePlatePatcher()
        {
            while (GameObject.Find("NameplateContainer") == null)
            {
                yield return null;
            }

            yield return new WaitForSeconds(15);
            #region Nameplate/Contents/Main
            GameObject.Find("NameplateManager/NameplateContainer/PlayerNameplate/Canvas/NameplateGroup/Nameplate/Contents/Main/Background").GetComponent<MaskableGraphic>().color = new Color(0.3f, 0.0f, 0.0f, 1.0f);
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
            MelonCoroutines.Start(NamePlatePatcher());
        }
        

        #endregion
        #region WorldPatcher
        #region FrenchFurHubPatcher
        private IEnumerator FrenchFurHubPatcher()
        {
            while (GameObject.Find("InstanceTutorial") == null)
            {
                yield return null;
            }
            MelonLogger.Log("FrenchFurHubPatcher Init...");
            yield return new WaitForSeconds(8);
            GameObject.Find("Menu/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("MM/MMBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleChairs").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/TogglePost").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleSfx").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleParticles").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleCrayons").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleClimb").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/TogglePortableMenu").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleScreenBlocker").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleSwim").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleClassicButtons").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleColliders").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/Panels/Toggles/Buttons/ToggleQuality").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("QM/QMButtonBG.png");
            GameObject.Find("Menu/Container/TutorialModal").gameObject.SetActive(false);
            GameObject.Find("Systems/ImpostorsAlert/Background").GetComponent<Image>().overrideSprite = XClientResources.Resources.LoadSprite("MM/MMBG.png");
            GameObject.Find("Environment/Bar/SpawnRules/RulesGround").gameObject.SetActive(false);
            GameObject.Find("Systems/ImpostorsAlert/Text (TMP)").GetComponentInChildren<TextMeshProUGUI>().SetText("<b>Attention!</b> Depuis quelque temps des gens se font passer pour des modérateurs du groupe/map VFF.\nVoici la liste des vrais modérateurs : \n<b>\n\nBiscuiTheHobkin\nTheSlagDeLélite\n</b>\nWelcome back : " + APIUser.CurrentUser.displayName.ToString());
        }
        #endregion
        #endregion
        //************
        #region app utils fuck
        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            MelonCoroutines.Start(FrenchFurHubPatcher());
            MelonCoroutines.Start(NamePlatePatcher());
        }
        public override void OnSceneWasUnloaded(int buildIndex, string sceneName) 
        {
            MelonCoroutines.Start(LoadingMusic.Music.Start());
            MelonCoroutines.Start(GoButton.Music.Start());
            //MelonCoroutines.Stop(NamePlatePatcher());
        }
        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
            
        }
        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
            
        }   
        public override void OnUpdate() // Runs once per frame.
        {
        }
        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {

        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {

        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            MelonLogger.Msg("OnPreferencesSaved");

        }
        #endregion
        public static string Version = "1.4";
    }
}