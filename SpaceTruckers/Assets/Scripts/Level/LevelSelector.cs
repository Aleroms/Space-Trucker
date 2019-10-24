using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//make sure to tag the player as "Player"
public class LevelSelector : MonoBehaviour
{
	[SerializeField] private string dst_Level= null;

	//changed Collider2D to Collider
	//why wasn't error printed?
	void OnTriggerStay2D(Collider2D other)
	{
		print("level:"+dst_Level);
		if (other.CompareTag("Player"))
		{
			if (dst_Level != null)
			{
				int sceneIndex = getSceneIndex(dst_Level);
				SceneManager.LoadScene(dst_Level);
			}
			else
				print("error:dst_lvl is null. Assign string to resolve.");
		}
	}
	private int getSceneIndex(string lvl)
	{
		for(int i = 0; i < SceneManager.sceneCountInBuildSettings; ++i)
		{
			string checkLevel = NameFromIndex(i);

			//DebugTool: print("sceneIndexFromName: i: " + i + " sceneName = " + testedScreen);
			if(checkLevel==lvl)
			{
				return i;
			}
		}
		return -1;
	}
	private static string NameFromIndex(int BuildIndex)
	{
		string path = SceneUtility.GetScenePathByBuildIndex(BuildIndex);
		int slash = path.LastIndexOf('/');
		string name = path.Substring(slash + 1);
		int dot = name.LastIndexOf('.');
		return name.Substring(0, dot);
	}

}
