using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuestTitle : Title
{

    private void Start()
    {
        base.Start();
    }


    private void Update()
	{
        base.Update();
	}

    public void LoadMainScene()
	{
        SceneManager.LoadScene("GuestMain");
	}

	protected override void ClickBtnSingIn()
	{
		if(DebugingApp.Inst.nowTestMode)
		{
			PopupUI.Inst.ActivePopupMessage("test", "test");
			Debug.Log("push");
		}
	}

	protected override void ClickBtnCreate()
	{
		base.ClickBtnCreate();
	}
}
