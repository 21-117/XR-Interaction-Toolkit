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

    void Start()
    {

    }

    void Update()
    {
        cont.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger);
        if (trigger)
        {
            // 키 누르는 중
        }

    }
}
