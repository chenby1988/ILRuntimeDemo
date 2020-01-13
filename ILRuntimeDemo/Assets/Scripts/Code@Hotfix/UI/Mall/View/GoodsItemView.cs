﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Hotfix.UI
{
    public class GoodsItemView : UIView
    {
        Text m_nameText;
        Button m_buyBtn;

        public GoodsItemView(GameObject go, RectTransform parent) : base(go, parent)
        {
        }

        public override void Init()
        {
            base.Init();

            m_buyBtn.onClick.AddListener(OnBuyBtnClicked);
        }

        public override void GetChild()
        {
            base.GetChild();
            m_nameText = transform.Find("NameText").GetComponent<Text>();
            m_buyBtn = transform.Find("BuyButton").GetComponent<Button>();
        }

        public void Setting(string name)
        {
            m_nameText.text = name;
        }

        void OnBuyBtnClicked()
        {
            Debug.Log("m_nameText:"+ m_nameText.text);
        }
    }
}