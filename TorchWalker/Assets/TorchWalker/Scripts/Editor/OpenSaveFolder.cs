// OpenSaveFolder.cs
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR

public class OpenSaveFolder
{
	[MenuItem("TorchWalker/Open Save Folder(Persistent Path)")]
	private static void Open()
	{
		// persistentDataPathはスラッシュ区切りでの取得となる
		string path = Application.persistentDataPath.Replace('/', '\\');
		// エクスプローラを実行
		System.Diagnostics.Process.Start("explorer.exe", path);
	}
} // class OpenSaveFolder

#endif