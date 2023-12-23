using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class QuitApplication : MonoBehaviour {

    void OnTriggerEnter(Collider other)
	{
#if UNITY_EDITOR
        {
            EditorApplication.isPlaying = false;
        }
#else
        {
            Application.Quit();
        }
#endif
    }
}
