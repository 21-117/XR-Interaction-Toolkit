using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class Controller_Moving : MonoBehaviour
{
    #region Private Variables
    private XRController xrCont;
    private Transform xrRig;
    private int value = 0;
    private float speed = 0.5f;
    #endregion

    #region Public Variables
    public Transform reticle_obj;
    #endregion

    void Start()
    {
        // 태그로 설정 된 오른쪽 컨트롤러 할당
        xrCont = GameObject.FindWithTag("Right").transform.GetComponent<XRController>();
        xrRig = GameObject.FindWithTag("XRRig").transform;
    }

    void Update()
    {
        //스위치 문으로 이동 컨트롤
        switch (value)
        {
            case 0:
                SetClear();
                break;
            case 1:
                XRRig_Teleport();
                break;
        }
        
    }

    void SetClear()
    {

    }

    void XRRig_Teleport()
    {
        // 오른손으로 가리키는 위치 클릭 받기
        if (xrCont.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger))
        {
            if (trigger)
            {
                // XR 리그 이동
                xrRig.transform.position = reticle_obj.transform.position;
                xrRig.transform.rotation = reticle_obj.transform.rotation;

                // 트리거 버튼 후 초기화
                // 추후 픽스 예정
                value = 0;
            }
        }
    }

}
