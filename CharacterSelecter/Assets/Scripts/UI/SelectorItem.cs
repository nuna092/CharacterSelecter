using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace TestTask 
{
    public class SelectorItem : MonoBehaviour
    {
        #region Приватные сериализованные поля
        [SerializeField] private Button buttonSelectPrefab;
        [SerializeField] private Transform parentSelectionButtons;
        [SerializeField] private Transform spawnCharacter;
        [SerializeField] private ButtonSelectCharacter buttonSelect;
        #endregion

        #region Приватные поля
        private UnityEvent OnDiselect = new UnityEvent();
        private List<SlotBehaviour> AllSlotBehaviourComp = new List<SlotBehaviour>();
        #endregion

        #region Пуюличные методы
        public List<SlotBehaviour> GetListSlotBehaviour()
        {
            return AllSlotBehaviourComp;
        }
        #endregion

        #region Приватные методы
        private void Awake()
        {
            Initialization();
            OnDiselect.AddListener(CloseAllCharactres);
        }

        private void Initialization()
        {           
            for (var i = 0; i < spawnCharacter.childCount; i++)
            {
                var selectSlot = Instantiate(buttonSelectPrefab, parentSelectionButtons);
                var slotBehaviourComp = GetComponentSlotBehaviour(selectSlot.gameObject);

                SendCharacterData(selectSlot, spawnCharacter.GetChild(i));
                AddListnerButtonOnclick(selectSlot, slotBehaviourComp, i);
                AddListnerDiselectAllStots(slotBehaviourComp);
            }
        }

        private void SendCharacterData(Button ReceivingObj, Transform SendingObj)
        {
            var slotDesignComp = ReceivingObj.gameObject.GetComponent<SlotDesign>();
            var characterData = SendingObj.gameObject.GetComponent<ItemData>();

            slotDesignComp.ReceiveData(characterData);
        }

        private SlotBehaviour GetComponentSlotBehaviour(GameObject selectButton)
        {
            var slotBehaviour = selectButton.GetComponent<SlotBehaviour>();
            AllSlotBehaviourComp.Add(slotBehaviour);
            return selectButton.GetComponent<SlotBehaviour>();
        }

        private void AddListnerButtonOnclick(Button selectButton, SlotBehaviour slotBehaviour, int id)
        {
            selectButton.onClick.AddListener(() => SelectCharacter(id));
            selectButton.onClick.AddListener(() => AddListnerSendDataToButton(id, slotBehaviour));
            selectButton.onClick.AddListener(slotBehaviour.SlotIsHightlitning);
        }

        private void AddListnerSendDataToButton(int id, SlotBehaviour slotBehaviour)
        {
            buttonSelect.ReceiveCharacterData(id, slotBehaviour);
        }

        private void AddListnerDiselectAllStots(SlotBehaviour slotBehaviour)
        {
            OnDiselect.AddListener(slotBehaviour.SlotRemoveHightlitning);
        }

        private void SelectCharacter(int id)
        {
            OnDiselect.Invoke();
            spawnCharacter.GetChild(id).gameObject.SetActive(true);
        }

        private void CloseAllCharactres()
        {
            for(var i = 0; i < spawnCharacter.childCount; i++)
                spawnCharacter.GetChild(i).gameObject.SetActive(false);           
        }
        #endregion 
    }

}

