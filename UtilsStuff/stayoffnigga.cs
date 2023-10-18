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
			base.gameObject.SetActive(false);
		}

		public void OnEnable()
		{
			base.gameObject.SetActive(false);
		}
        public void OnUpdate()
        {
            base.gameObject.SetActive(false);
        }
    }
}
