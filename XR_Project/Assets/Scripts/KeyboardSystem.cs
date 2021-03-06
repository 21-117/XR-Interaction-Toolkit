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
                        // 레이캐스트 충돌 인식
                        if (Physics.Raycast(transform.position, fwd, out hit))
                        {
                            // 태그 인식
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
                                // 다르게 저장할 시 텍스트 값 저장
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
        
        // 예외처리 테스트
        else
        {
            ResetRayController();
        }
    }
    #endregion

    #region Private Methods
    public void ClickTargerButton(Transform target)
    {
        // 레이캐스트의 사거리를 보완해주며 클릭을 도와주는 버튼
        if (target.GetComponent<Button>())
        {
            target.GetComponent<Button>().onClick.Invoke();
        }
        ResetRayController();
    }

    //컨트롤러를 못찾을 경우
    private void ResetRayController()
    {
        if (controller == null)
        {
            Debug.LogError("컨트롤러가 없습니다");
            return;
        }
        lastTargetName = "";
    }
    #endregion
}
