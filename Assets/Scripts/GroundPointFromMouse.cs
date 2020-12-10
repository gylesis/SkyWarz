using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GroundPointFromMouse {

    public static Vector3 GetPos() {
        Ray ray = CameraController.Instance.mainCamera.ScreenPointToRay(Input.mousePosition);
       
        if (Physics.Raycast(ray, out RaycastHit hitInfo, maxDistance: 300f)) {
            var targetPos = hitInfo.point;
            return targetPos;
        }

        return Vector3.zero;
    }



}
