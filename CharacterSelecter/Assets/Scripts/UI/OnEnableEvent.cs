using UnityEngine;

namespace TestTask
{   
    [RequireComponent(typeof(ItemData))] 
    public class OnEnableEvent : MonoBehaviour
    {
        #region Приватные сериализованные данные
        [SerializeField] private UIDataOutput output;
        #endregion

        #region Приватные данные
        private ItemData characterData;
        #endregion

        #region Приватные методы
        private void Awake()
        {
            characterData = GetComponent<ItemData>();
        }

        private void OnEnable()
        {
            output.VisualisztionName(characterData);
        }
        #endregion
    }
}

