using TMPro;
using UnityEngine;

namespace TestTask
{
    public class UIDataOutput : MonoBehaviour
    {
        #region Приватные сериализованные данные
        [SerializeField] private TextMeshProUGUI nameCharacterText;
        #endregion

        #region Публичные методы
        public void VisualisztionName(ItemData data)
        {
            nameCharacterText.text = data.CharacterName;
        }
        #endregion
    }
}

