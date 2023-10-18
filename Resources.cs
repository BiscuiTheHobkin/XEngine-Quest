using System;
using System.IO;
using XClient.LoadSprites;
using UnityEngine;

namespace XClientResources
{
    public class Resources
    {
        public static Sprite LoadSprite(string sprite)
        {
            return (Resources.resourcePath + "/" + sprite).LoadSpriteFromDisk();
        }
        private static string resourcePath = Path.Combine(Environment.CurrentDirectory, "XEngine/Icons");


    }
}
