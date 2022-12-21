using UnityEngine;
using UnityEditor;


namespace TestTaskEditor
{
    public class CleanSaves : MonoBehaviour
    {
        [MenuItem("Tools/Clear PlayerPrefs")]
        private static void NewMenuOption()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}

