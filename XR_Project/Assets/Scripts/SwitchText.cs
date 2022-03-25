using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitchText : MonoBehaviour
{
    public Text text;
    private float countTime = 0f;
    private int num = 0;

    string[] txt = new string[5];

    void Start()
    {

    }
    void Update()
    {
        SwitchingText();
    }


    //단계별 진행을 위해 조건 값에 따른 텍스트 변환
    public void SwitchingText()
    {

        switch (num)
        {
            case 0:
                //
                StepZero();
                break;
            case 1:
                //
                StepOne();
                break;
            case 2:
                //
                StepTwo();
                break;
            case 3:
                //
                StepThree();
                break;
            case 4:
                //
                StepFinal();
                break;
            default:
                Debug.Log("스위치문 작동 중 오류 발생");
                break;
        }
    }

    #region 단계별 스탭
    void StepZero()
    {
        num = 1;
    }
    void StepOne()
    {
        num = 2;
    }
    void StepTwo()
    {
        num = 3;
    }
    void StepThree()
    {
        num = 4;
    }
    void StepFinal()
    {
        num = 0;
    }
    #endregion
}
