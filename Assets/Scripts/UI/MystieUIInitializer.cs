using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace Game
{
    public class MystieUIInitializer : MonoBehaviour
    {
        [SerializeField]private Image mystieImage;
        [SerializeField]private TMP_Text mystieName;
        [SerializeField]private Image healthAmount;
        [SerializeField]private Image expAmount;

        public void Setup(Image mystieImage, String mystieName)
        {
            this.mystieImage = mystieImage;
            this.mystieName.text = mystieName;
            this.healthAmount.fillAmount = 1.0f;
            this.expAmount.fillAmount = 1.0f;
        }
    }
}
