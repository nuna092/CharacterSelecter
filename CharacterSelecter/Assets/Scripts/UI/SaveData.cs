using UnityEngine;

namespace TestTask
{
    public class SaveData 
    {
        public SaveData(string key,int id)
        {
            PlayerPrefs.SetInt(key, id);
        }
    }
}


