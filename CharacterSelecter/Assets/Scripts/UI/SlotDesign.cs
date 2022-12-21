using UnityEngine;
using UnityEngine.UI;

namespace TestTask
{
    public class SlotDesign : MonoBehaviour
    {
        #region Приватные сериализованные данные
        [SerializeField] private Image slotImage;
        #endregion

        #region Приватные данные
        private ItemData currentSlotData;
        #endregion

        #region Публичные методы
        public void ReceiveData(ItemData data)
        {
            currentSlotData = data;
            Initialization();
        }
        #endregion

        #region Приватные методы
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
