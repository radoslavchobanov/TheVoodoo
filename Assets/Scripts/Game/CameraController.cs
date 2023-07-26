using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private void Update()
    {
        var nextPos = PlayerManager.Instance.Player.transform.position + new Vector3(0, 0, Constants.CAMERA_Z_OFFSET);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, nextPos, Constants.CAMERA_SMOOTH_SPEED);
        transform.position = smoothedPosition;
    }
}
