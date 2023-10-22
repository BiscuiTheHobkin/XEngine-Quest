using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UIStuff
{
    internal class LoadingTealGradient
    {
        public static IEnumerator Init()
        {
            MelonLogger.Msg("-> Patch -> LoadingBackground");
            GameObject.Find("LoadingBackground_TealGradient_Music/SkyCube_Baked").gameObject.SetActive(false);
            GameObject.Find("LoadingBackground_TealGradient_Music/_FX_ParticleBubbles/FX_snow").GetComponent<ParticleSystem>().startColor = Color.white;
            GameObject.Find("LoadingBackground_TealGradient_Music/_FX_ParticleBubbles/FX_snow").GetComponent<ParticleSystem>().startSpeed = 15;
            GameObject.Find("LoadingBackground_TealGradient_Music/_FX_ParticleBubbles/FX_snow").transform.localRotation = Quaternion.Euler(0, 0, 0);
            yield break;
        }
   }
}
