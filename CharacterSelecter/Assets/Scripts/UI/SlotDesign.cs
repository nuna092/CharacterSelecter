using UnityEngine;
using UnityEngine.UI;

namespace TestTask
{
    public class SlotDesign : MonoBehaviour
    {
        #region ��������� ��������������� ������
        [SerializeField] private Image slotImage;
        #endregion

        #region ��������� ������
        private ItemData currentSlotData;
        #endregion

        #region ��������� ������
        public void ReceiveData(ItemData data)
        {
            currentSlotData = data;
            Initialization();
        }
        #endregion

        #region ��������� ������
        private void Initialization()
        {
            VisualisztionAvatar(currentSlotData);
            CheckedIsClosed(currentSlotData);
        }

        private void CheckedIsClosed(ItemData slotdata)
        {
            if(slotdata.Closed)
               GetComponent<SlotBehaviour>().SlotIsClosed();                                  
        }

        private void VisualisztionAvatar(ItemData data)
        {
            slotImage.sprite = data.IconImage;
        }
        #endregion
    }

}
