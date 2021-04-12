using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuestTitle : Title
{

    private void Start()
    {
        base.Start();
		PopupUI.Inst.test = false;
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
			LoadMainScene();
		}
	}

	protected override void ClickBtnCreate()
	{
		base.ClickBtnCreate();
	}
}
