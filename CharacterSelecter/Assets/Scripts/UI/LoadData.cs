using UnityEngine;

namespace TestTask
{
    public class LoadData : MonoBehaviour
    {
        #region Приватные сериализованные данные
        [SerializeField] private SelectorItem selectorCharacter;
        [SerializeField] private SelectorItem selectorStage;        
        [SerializeField] private GameObject[] characters;
        [SerializeField] private GameObject[] stages;
        #endregion

        #region Приватные методы
        private void Start()
        {          
            if (PlayerPrefs.HasKey("Character"))           
                OpenSavedCharacter(PlayerPrefs.GetInt("Character"));
            
            if (PlayerPrefs.HasKey("Stage"))       
                OpenSavedStage(PlayerPrefs.GetInt("Stage"));

            else OpenSavedStage(0);
        }

        private void OpenSavedCharacter(int characterId)
        {
            var charcterSlotsBehaviourComp = selectorCharacter.GetListSlotBehaviour();            
            charcterSlotsBehaviourComp[characterId].SlotIsHightlitning();
            charcterSlotsBehaviourComp[characterId].SlotIsSelected();

            characters[characterId].SetActive(true);
        }

        private void OpenSavedStage(int stageID)
        {
            var stageSlotsBehaviourComp = selectorStage.GetListSlotBehaviour();
            stageSlotsBehaviourComp[stageID].SlotIsHightlitning();
            stageSlotsBehaviourComp[stageID].SlotIsSelected();

            stages[stageID].SetActive(true);
        }
        #endregion
    }
}

