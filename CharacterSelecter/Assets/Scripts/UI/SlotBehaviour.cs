using UnityEngine;
using UnityEngine.Events;

namespace TestTask
{
    public class SlotBehaviour : MonoBehaviour
    {
        #region Приватные сериализованные данные
        [SerializeField] private UnityEvent OnSelectSlotAction;
        [SerializeField] private UnityEvent OnHightLightningSlotAction;
        [SerializeField] private UnityEvent OnRemoveHightLightningSlotAction;
        [SerializeField] private UnityEvent OnDeselectSlotAction;
        [SerializeField] private UnityEvent OnClosedSlot;
        #endregion

        #region Публичные методы
        public void SlotIsSelected()
        {
            OnSelectSlotAction.Invoke();
        }

        public void SlotIsDeselected()
        {
            OnDeselectSlotAction.Invoke();
        }

        public void SlotIsHightlitning()
        {
            OnHightLightningSlotAction.Invoke();
        }

        public void SlotRemoveHightlitning()
        {
            OnRemoveHightLightningSlotAction.Invoke();
        }

        public void SlotIsClosed()
        {
            OnClosedSlot.Invoke();
        }
        #endregion
    }
}

