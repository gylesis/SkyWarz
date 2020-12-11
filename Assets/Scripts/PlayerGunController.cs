using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunController : MonoBehaviour {

    public static PlayerGun choosenGun;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            choosenGun.Shoot();
        }
    }
}
