using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// ��Ʈ�ѷ� ���� �Է� �ޱ�
/// </summary>

public class TriggerSwitch : MonoBehaviour
{
    private InputDevice cont;

    void Start()
    {

    }

    void Update()
    {
        cont.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger);
        if (trigger)
        {
            // Ű ������ ��
        }

    }
}
