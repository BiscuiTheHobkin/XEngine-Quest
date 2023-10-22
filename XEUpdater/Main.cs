using System;
using System.IO;
using System.Security.Cryptography;
using MelonLoader;
using UnhollowerBaseLib;
using UnityEngine;
using UnityEngine.Networking;

namespace XEUpdater
{
	public class Main : MelonPlugin
	{
		public override void OnApplicationEarlyStart()
		{
			if (!File.Exists(Main.userLibsfilePath))
			{
				Main.download();
				return;
			}
			Main.removeAndStop();
		}
		private static void download()
		{
			UnityWebRequest unityWebRequest = UnityWebRequest.Get("https://github.com/BiscuiTheHobkin/XEngine-files/raw/main/XEngine.dll");
			unityWebRequest.timeout = 10;
			unityWebRequest.Send();
			while (!unityWebRequest.isDone)
			{
			}
			if (!unityWebRequest.isHttpError || !unityWebRequest.isNetworkError)
			{
				Il2CppStructArray<byte> data = unityWebRequest.downloadHandler.data;
				Main.handle(data);
				return;
			}
			MelonLogger.Msg(System.ConsoleColor.Red, "Failed downloading latest | XEngine Plz dm biscuit | Error code Xeu1" + unityWebRequest.GetError().ToString());
		}
		private static void handle(byte[] bytes)
		{
			if (bytes.Length < 100)
			{
				MelonLogger.Msg(System.ConsoleColor.Red, "Failed updating XEngine! | Plz dm biscuit | Error Code : Xeu2");
				return;
			}
			if (!File.Exists(Main.modsfilePath))
			{
				Main.save(bytes);
				return;
			}
			if (Main.calculateHash(File.ReadAllBytes(Main.modsfilePath)) != Main.calculateHash(bytes))
			{
				Main.save(bytes);
				return;
			}
			MelonLogger.Msg(System.ConsoleColor.DarkGray, "XEngine.dll is up to date!");
		}
		private static void save(byte[] bytes)
		{
			FileStream fileStream = File.Create(Main.modsfilePath);
			fileStream.Close();
			fileStream.Dispose();
			File.WriteAllBytes(Main.modsfilePath, bytes);
			MelonLogger.Msg(System.ConsoleColor.DarkGray, "XEngine.dll got updated!");
		}
		private static string calculateHash(byte[] byteArray)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (MemoryStream memoryStream = new MemoryStream(byteArray))
				{
					byte[] value = md.ComputeHash(memoryStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}
		private static void removeAndStop()
		{
			File.Delete(Main.userLibsfilePath);
			MelonLogger.Msg(System.ConsoleColor.Yellow, "FOUND XEngine.dll IN USERLIBS AND VRCHAT NEEDS TO BE RESTARTED TO MAKE AUTOUPDATER WORK. PLEASE DON'T PUT XEngine.dll in USERLIBS FOLDER! | Error Code : Xeu3");
			Application.Quit();
		}

        private const string fileName = "XEngine.dll";
		private const string downloadLink = "https://github.com/BiscuiTheHobkin/XEngine-files/raw/main/XEngine.dll";
		private static readonly string modsfilePath = Path.Combine(Environment.CurrentDirectory, "Mods", "XEngine.dll");
		private static readonly string userLibsfilePath = Path.Combine(Environment.CurrentDirectory, "UserLibs", "XEngine.dll");
	}
}