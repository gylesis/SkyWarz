using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField]
    protected float damage;

    [SerializeField]
    protected string name;

    public static PlayerGun currentGun;

    [SerializeField]
    protected AudioClip shootSound;

    public static void Shoot() {
        Debug.Log("Shoot");
    }


}
