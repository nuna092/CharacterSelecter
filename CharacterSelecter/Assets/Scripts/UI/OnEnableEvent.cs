using UnityEngine;

namespace TestTask
{   
    [RequireComponent(typeof(ItemData))] 
    public class OnEnableEvent : MonoBehaviour
    {
        #region ��������� ��������������� ������
        [SerializeField] private UIDataOutput output;
        #endregion

        #region ��������� ������
        private ItemData characterData;
        #endregion

        #region ��������� ������
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

