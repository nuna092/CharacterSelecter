using UnityEngine;
using UnityEngine.Events;

namespace TestTask
{
    public class ButtonSelectCharacter : MonoBehaviour
    {
        #region ��������� ��������������� ������
        [SerializeField] private GameObject buttonSelect;
        [SerializeField] private Transform parentSelectionButtons;
        [SerializeField] private string itemType;
        #endregion
        
        #region ��������� ������
        private int currentSelectedSlotId;
        private SlotBehaviour slotBehaviorCurrentSelectedSlot;
        private UnityEvent HideAllMarksEvent = new UnityEvent();
        #endregion
       
        #region ��������� ������
        public void ReceiveCharacterData(int id, SlotBehaviour slotBehavior)
        {
            ReceiveId(id);
            this.slotBehaviorCurrentSelectedSlot = slotBehavior;
            ActivateButtonSelect();
        }
        public void SelectButtonAction()
        {
            HideAllMarksEvent.Invoke();
            slotBehaviorCurrentSelectedSlot.SlotIsSelected();
            SaveCurrentSlotId();
        }
        #endregion

        #region ��������� ������
        private void Start()
        {
            var allSlotsBehavior = new SlotBehaviour[parentSelectionButtons.childCount];
            for(var i = 0; i < parentSelectionButtons.childCount; i++)
            {
                allSlotsBehavior[i] = parentSelectionButtons.GetChild(i).GetComponent<SlotBehaviour>();
                HideAllMarksEvent.AddListener(allSlotsBehavior[i].SlotIsDeselected);
            }                             
        }
     
        private void ReceiveId(int id)
        {
            currentSelectedSlotId = id;            
        }

        private void ActivateButtonSelect()
        {
            buttonSelect.gameObject.SetActive(true);
        } 
        
        private void SaveCurrentSlotId()
        {
            SaveData saveManger = new SaveData(itemType, currentSelectedSlotId); 
        }
        #endregion
    }
}

