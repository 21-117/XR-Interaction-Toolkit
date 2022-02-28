using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// XR Interaction Toolkit 를 응용하기 위해 필요한 스위치 스크립트
/// </summary>
public class Switch : MonoBehaviour
{
    private bool value = false;

    void SwitchOnOff()
    {
        //입력 받을 때 마다 식 판별 후 bool값 반환
        value = value == false ? true : false;

        if (value)
        {
            // 스위치 ON 일 때
            // 내용 기입
        }
        else if (!value)
        {
            // 스위치 OFF 일 때
            // 내용 기입
        }
    }

}
