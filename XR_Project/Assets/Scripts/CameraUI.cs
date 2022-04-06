using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraUI : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject cameraUI;

    public float offsetRadius = 0.3f;
    public float distanceToHead = 4;

    [Range(0, 10)]
    public float smoothPosFactor = 5f;

    [Range(0, 10)]
    public float smoothRotFactor = 5f;

    [Range(0, 1)]
    public float leftPosition = 0.2f;

    void Update()
    {
        cameraUI.transform.rotation = Quaternion.Lerp(transform.rotation, mainCamera.transform.rotation, smoothRotFactor);

        var cameraCenter = mainCamera.transform.position + mainCamera.transform.forward * distanceToHead - mainCamera.transform.right * leftPosition;
        var currentPos = cameraUI.transform.position;
        var direction = currentPos - cameraCenter; 
        var targetPosition = cameraCenter + direction.normalized * offsetRadius;

        cameraUI.transform.position = Vector3.Lerp(currentPos, targetPosition, Time.deltaTime * smoothPosFactor);

    }
}
