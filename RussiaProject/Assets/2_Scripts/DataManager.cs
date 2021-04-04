using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private static DataManager singletone = null;

    //리소스만 관리합니다.
    public static DataManager Inst()
    {
        if (singletone == null)
        {
            singletone = new DataManager();
        }
        return singletone;
    }



}
