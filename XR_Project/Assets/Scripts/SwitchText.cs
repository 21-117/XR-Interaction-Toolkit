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


    //�ܰ躰 ������ ���� ���� ���� ���� �ؽ�Ʈ ��ȯ
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
                Debug.Log("����ġ�� �۵� �� ���� �߻�");
                break;
        }
    }

    #region �ܰ躰 ����
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
