using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour {

    [SerializeField]
    protected float damage;

    [SerializeField]
    protected string name;

    public static PlayerGun currentGun;

    [SerializeField]
    protected AudioClip shootSound;

    public virtual void ChooseGun() { }

    private void Start() {
    }

    public virtual void Shoot() {
        Debug.Log("Shoot");
    }


}
