using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class KeyboardSystem : MonoBehaviour
{
    #region Public Variables
    public XRController controller = null;
    public float delayInSeconds = 0.2f;
    #endregion

    #region Private Variables
    Coroutine rayController;
    private string lastTargetName = "";
    private bool state = false;
    #endregion

    InputDevice cont;
    RaycastHit hit;
    #region MonoBehaviour Callbacks

    void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

            if (cont.TryGetFeatureValue(CommonUsages.triggerButton, out bool isTrigger))
            {
                if (isTrigger != state)
                {
                    if (state)
                    {

                    }
                    else
                    {
                        // ����ĳ��Ʈ �浹 �ν�
                        if (Physics.Raycast(transform.position, fwd, out hit))
                        {
                            // �±� �ν�
                            if (hit.transform.tag == "VRGazeInteractable")
                            {
                                if (lastTargetName == hit.transform.name)
                                {
                                    return;
                                }
                                if (lastTargetName == "")
                                {
                                    lastTargetName = hit.transform.name;
                                }
                                // �ٸ��� ������ �� �ؽ�Ʈ �� ����
                                if (hit.transform.name != lastTargetName)
                                {
                                    lastTargetName = hit.transform.name;
                                }
                                if (rayController != null)
                                {
                                    StopCoroutine(rayController);
                                }
                                ClickTargerButton(hit.transform);
                            }
                        }
                    }
                    state = isTrigger;
                }
            }
        
        // ����ó�� �׽�Ʈ
        else
        {
            ResetRayController();
        }
    }
    #endregion

    #region Private Methods
    public void ClickTargerButton(Transform target)
    {
        // ����ĳ��Ʈ�� ��Ÿ��� �������ָ� Ŭ���� �����ִ� ��ư
        if (target.GetComponent<Button>())
        {
            target.GetComponent<Button>().onClick.Invoke();
        }
        ResetRayController();
    }

    //��Ʈ�ѷ��� ��ã�� ���
    private void ResetRayController()
    {
        if (controller == null)
        {
            Debug.LogError("��Ʈ�ѷ��� �����ϴ�");
            return;
        }
        lastTargetName = "";
    }
    #endregion
}
