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
        // �±׷� ���� �� ������ ��Ʈ�ѷ� �Ҵ�
        xrCont = GameObject.FindWithTag("Right").transform.GetComponent<XRController>();
        xrRig = GameObject.FindWithTag("XRRig").transform;
    }

    void Update()
    {
        //����ġ ������ �̵� ��Ʈ��
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
        // ���������� ����Ű�� ��ġ Ŭ�� �ޱ�
        if (xrCont.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool trigger))
        {
            if (trigger)
            {
                // XR ���� �̵�
                xrRig.transform.position = reticle_obj.transform.position;
                xrRig.transform.rotation = reticle_obj.transform.rotation;

                // Ʈ���� ��ư �� �ʱ�ȭ
                // ���� �Ƚ� ����
                value = 0;
            }
        }
    }

}
