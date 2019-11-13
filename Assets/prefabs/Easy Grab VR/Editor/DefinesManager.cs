﻿/**
 *	Quick and dirty defines manager for Revolver Kit VR
 */

using UnityEngine;
using UnityEditor;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class DefineManager : EditorWindow
{
	const string DEF_MANAGER_PATH = "Assets/Easy Grab VR/Editor/DefinesManager.cs";
	const string SCRIPT_PATH = "Assets/Easy Grab VR/Scripts/SVControllerInput.cs";

	// http://forum.unity3d.com/threads/93901-global-define/page2
	// Do not modify these paths
	//const string CSHARP_PATH 		= "Assets/smcs.rsp";
	const string CSHARP_PATH 		= "Assets/mcs.rsp";
	List<string> csDefines = new List<string>(); 

	private int selection = 0;
	private int oldSelection = 0;

	[MenuItem("Window/Easy Grab VR SDK")]

	public static void OpenDefManager()
	{
		EditorWindow.GetWindow<DefineManager>(true, "Easy Grab VR SDK", true);
	}

	void OnEnable() {		
		csDefines = ParseRspFile(CSHARP_PATH);

		if (csDefines.Contains ("USES_STEAM_VR")) {
			selection = 1;
		} else if (csDefines.Contains ("USES_OPEN_VR")) {
			selection = 2;
		} else {
			selection = 0;
		}
		oldSelection = selection;
	}

	void OnGUI() {
		GUILayout.BeginVertical ();
		GUILayout.Label("Easy Grab VR SDK", EditorStyles.boldLabel);

		var text = new string[] { "VR SDK Undefined", "Steam VR (Vive / Rift)", "Open VR (Rift only)" };
		selection = GUILayout.SelectionGrid(selection, text, 1, EditorStyles.radioButton);

		csDefines.Clear ();
		if (selection == 1) {  // steam vr
			csDefines.Add ("USES_STEAM_VR");
		} else if (selection == 2) { //open vr
			csDefines.Add ("USES_OPEN_VR");
		}

		WriteDefines(CSHARP_PATH, csDefines);
		GUILayout.EndVertical ();

		if (oldSelection != selection) {
			oldSelection = selection;
			ForceUpdate();
		}
	}

	List<string> ParseRspFile(string path)
	{
		if(!File.Exists(path))
			return new List<string>();

		string[] lines = File.ReadAllLines(path);
		List<string> defs = new List<string>();

		foreach(string cheese in lines)
		{
			if(cheese.StartsWith("-define:"))
			{
				defs.AddRange( cheese.Replace("-define:", "").Split(';') );
			}
		}

		return defs;
	}

	void WriteDefines(string path, List<string> defs)
	{
		if(defs.Count < 1 && File.Exists(path))
		{
			File.Delete(path);
			File.Delete(path + ".meta");
			AssetDatabase.Refresh();
			return;
		}

		StringBuilder sb = new StringBuilder();
		sb.Append("-define:");

		for(int i = 0; i < defs.Count; i++)
		{
			sb.Append(defs[i]);
			if(i < defs.Count-1) sb.Append(";");
		}

		using (StreamWriter writer = new StreamWriter(path, false))
		{
			writer.Write(sb.ToString());
		}
	}

	void ForceUpdate() {
		AssetDatabase.Refresh();
		AssetDatabase.ImportAsset(DEF_MANAGER_PATH, ImportAssetOptions.ForceUpdate);
		AssetDatabase.ImportAsset(SCRIPT_PATH, ImportAssetOptions.ForceUpdate);
	}
}