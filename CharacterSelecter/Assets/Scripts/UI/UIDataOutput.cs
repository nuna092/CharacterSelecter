using TMPro;
using UnityEngine;

namespace TestTask
{
    public class UIDataOutput : MonoBehaviour
    {
        #region ��������� ��������������� ������
        [SerializeField] private TextMeshProUGUI nameCharacterText;
        #endregion

        #region ��������� ������
        public void VisualisztionName(ItemData data)
        {
            nameCharacterText.text = data.CharacterName;
        }
        #endregion
    }
}

