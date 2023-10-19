using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TestMod.UIStuff
{
    internal class LoadingTealGradient
    {
        public static IEnumerator Init()
        {
            MelonLogger.Log("-> Patch -> LoadingBackground");
            GameObject.Find("LoadingBackground_TealGradient_Music/SkyCube_Baked").gameObject.SetActive(false);
            GameObject.Find("LoadingBackground_TealGradient_Music/_FX_ParticleBubbles/FX_snow").GetComponent<ParticleSystem>().startColor = Color.red;
            GameObject.Find("LoadingBackground_TealGradient_Music/_FX_ParticleBubbles/FX_snow").GetComponent<ParticleSystem>().startSpeed = 3;
            yield break;
        }
}
}
