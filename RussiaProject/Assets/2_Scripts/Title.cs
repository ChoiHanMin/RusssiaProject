using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
	public RectTransform rectLoading;
	private bool isLoading;

	public Button btnSignIn;
	public Button btnCreate;

	//ID_PW
	public InputField txtInputID;
	public InputField txtInputPW;
	public bool isHasUserInfo;


	private float timeLading;
	private const float UPDATE_CYCLE = 0.2f;
	protected void Start()
	{
		rectLoading = GameObject.Find("Img_Loading").GetComponent<RectTransform>();
		timeLading = UPDATE_CYCLE;

		txtInputPW = GameObject.Find("InputFieldPW").GetComponent<InputField>();
		txtInputID = GameObject.Find("InputFieldID").GetComponent<InputField>();

		btnCreate = GameObject.Find("Btn_Create").GetComponent<Button>();
		btnSignIn = GameObject.Find("Btn_SignIn").GetComponent<Button>();

		btnSignIn.onClick.AddListener(() => ClickBtnSingIn());
		btnCreate.onClick.AddListener(() => ClickBtnCreate());
	}

	protected void Update()
	{
		UpdateLoading();


		if (Input.GetKeyDown(KeyCode.Return))
		{

		}
	}



	protected void UpdateLoading()
	{
		if (isLoading)
		{
			timeLading -= Time.deltaTime;
			if (timeLading < 0)
			{
				rectLoading.Rotate(0, 0, -10f);
				timeLading = UPDATE_CYCLE;
			}
		}
	}

	protected virtual void ClickBtnSingIn()
	{
		
	}


	protected virtual void ClickBtnCreate()
	{

	}
}
