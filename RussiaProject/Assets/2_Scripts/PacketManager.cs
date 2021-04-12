using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacketManager : Singletone<PacketManager>
{
  
    //TODO 이런식으로 정의할껀지 Common 파일 또는 데이터베이스 정의를 통해 구별할건지.
    public enum WHO_USE
	{
        GUEST,
        DIRVER,
        RESTAURANT,
        MANAGER
    }
    public bool SendSignInInfo(string id, string pw, WHO_USE who)
    {

        return false;
    }

}
