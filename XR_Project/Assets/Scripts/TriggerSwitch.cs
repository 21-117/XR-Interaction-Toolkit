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
    private XRController xrCont;
    bool value = false;
    void Start()
    {
        xrCont = GameObject.FindWithTag("Right").transform.GetComponent<XRController>();
    }

    void Update()
    {
        //cont.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger);
        
        if (xrCont.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger))
        {
            if (!value)
            {
                // Ű ���� ���
            }
            else
            {
                // ��ư ������
            }
            value = true;
        }

    }
}
