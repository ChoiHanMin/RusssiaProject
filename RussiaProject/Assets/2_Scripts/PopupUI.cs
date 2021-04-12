using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class PopupUI : Singletone<PopupUI>
{
    public StringBuilder strMessage;
    public StringBuilder strTitle;

    public bool test;

    private void Start()
    {
        strMessage = new StringBuilder();
        strTitle = new StringBuilder();
    }

    public void ActivePopupMessage(string str)
    {

    }
}
