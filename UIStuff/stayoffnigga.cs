using MelonLoader;
using System;
using UnityEngine;

namespace X_Engine_stayoffnigga
{
	internal class stayoffnigga : MonoBehaviour
	{
		public stayoffnigga(IntPtr ptr) : base(ptr)
		{
		}

		public void Start()
		{
			//base.gameObject.SetActive(true);
		}

		public void OnEnable()
		{
            //base.gameObject.SetActive(true);
            MelonLogger.Msg("Enable -");
            MelonCoroutines.Stop(UIStuff.NamePlatePatcher.Init());
        }
        public void OnUpdate()
        {
            //base.gameObject.SetActive(true);
        }
        public void OnDisable()
        {
			//base.gameObject.SetActive(true);
			MelonLogger.Msg("Dasabled -");
            MelonCoroutines.Start(UIStuff.NamePlatePatcher.Init());
        }
    }
}
