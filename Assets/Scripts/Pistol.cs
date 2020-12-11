using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : PlayerGun {

    public override void ChooseGun() {
        PlayerGunController.choosenGun = this;
    }

    public override void Shoot() {
        Debug.Log("Pistol");
    }
}
