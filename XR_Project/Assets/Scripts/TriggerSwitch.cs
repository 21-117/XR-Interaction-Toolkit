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
        // 태그로 설정 된 오른쪽 컨트롤러 할당
        xrCont = GameObject.FindWithTag("Right").transform.GetComponent<XRController>();
    }

    void Update()
    {
        //cont.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger);
        
        if (xrCont.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger))
        {
            if (trigger != value)
            {
                // 버튼을 누르고 있을 때
            }
            else
            {
                // 버튼을 눌렀을 때
            }
            value = trigger;
        }

    }
}
