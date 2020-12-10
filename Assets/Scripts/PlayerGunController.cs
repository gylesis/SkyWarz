using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunController : MonoBehaviour
{

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            PlayerGun.Shoot();
        }
    }


}
