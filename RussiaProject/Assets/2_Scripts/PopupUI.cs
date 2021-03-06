﻿using Doozy.Engine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class PopupUI : Singletone<PopupUI>
{
    public StringBuilder strMessage;
    public StringBuilder strTitle;

    public Text txtTitle;
    public Text txtMessage;

    public UIPopup uIPopup;
    public Button btnOk;

	private void Awake()
	{
		
	}

    [ContextMenu("InitPublic")]
    private void SetUpUiObj()
	{
		txtTitle = GameObject.Find("Popup_Title").GetComponent<Text>();
		txtMessage = GameObject.Find("Popup_Message").GetComponent<Text>();
		uIPopup = gameObject.GetComponent<UIPopup>();
		btnOk = gameObject.GetComponentInChildren<Button>();
	}

	private void Start()
    {
        strMessage = new StringBuilder();
        strTitle = new StringBuilder();

		btnOk.onClick.AddListener(() => SelecOk());
	}

	private void Update()
	{
		
	}
	public void ActivePopupMessage(string _strtTitle  ,string _strMessage)
    {
		txtMessage.text = _strMessage;
		txtTitle.text = _strtTitle;

		//this.gameObject.SetActive(true);
		uIPopup.Show();
    }

    public void SelecOk()
	{
        //this.gameObject.SetActive(false);
        uIPopup.Hide();
		Debug.Log(nameof(SelecOk));
	}
}
