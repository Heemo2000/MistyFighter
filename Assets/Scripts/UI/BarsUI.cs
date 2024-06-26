using UnityEngine;
using UnityEngine.UI;

namespace Game.UI
{
    public class BarsUI : MonoBehaviour
    {
        private Image _fillImage;

        private void Awake() {
            _fillImage = GetComponent<Image>();
        }

        private void Start() 
        {
            _fillImage.fillMethod = Image.FillMethod.Horizontal;
        }
    
        public void SetFillAmount(float currentValue,float maxValue)
        {
            _fillImage.fillAmount = currentValue/maxValue;
        }

        public void SetFillAmount(float percent)
        {
            _fillImage.fillAmount = percent;
        }
    }

}
