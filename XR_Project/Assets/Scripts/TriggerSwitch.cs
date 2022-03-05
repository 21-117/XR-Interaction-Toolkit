using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// 컨트롤러 단일 입력 받기
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
                // 키 떼는 즉시
            }
            else
            {
                // 버튼 누르기
            }
            value = true;
        }

    }
}
