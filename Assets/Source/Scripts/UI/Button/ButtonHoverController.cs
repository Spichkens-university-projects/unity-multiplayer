using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Source.Scripts.UI.Button
{
    public class ButtonHoverController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private TMP_Text buttonText;

        private Color _initialButtonTextColor;

        private void Awake()
        {
            _initialButtonTextColor = buttonText.color;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            buttonText.color = Color.black;
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            buttonText.color = _initialButtonTextColor;
        }
    }
}
