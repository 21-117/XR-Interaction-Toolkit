using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// XR Interaction Toolkit �� �����ϱ� ���� �ʿ��� ����ġ ��ũ��Ʈ
/// </summary>
public class Switch : MonoBehaviour
{
    private bool value = false;

    void SwitchOnOff()
    {
        //�Է� ���� �� ���� �� �Ǻ� �� bool�� ��ȯ
        value = value == false ? true : false;

        if (value)
        {
            // ����ġ ON �� ��
            // ���� ����
        }
        else if (!value)
        {
            // ����ġ OFF �� ��
            // ���� ����
        }
    }

}
