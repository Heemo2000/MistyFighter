using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace Game.UI
{
    public class MystieUIInitializer : MonoBehaviour
    {
        [SerializeField]private Image mystieImage;
        [SerializeField]private TMP_Text mystieName;
        [SerializeField]private BarsUI healthAmount;
        [SerializeField]private BarsUI expAmount;

        public void Setup(Image mystieImage, String mystieName)
        {
            this.mystieImage = mystieImage;
            this.mystieName.text = mystieName;
            this.healthAmount.SetFillAmount(1.0f);
            this.expAmount.SetFillAmount(1.0f);
        }
    }
}
