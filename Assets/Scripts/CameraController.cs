using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public static CameraController Instance;

    [SerializeField]
    public Camera mainCamera;

    [SerializeField]
    private float _speedOfFollowing;

    [SerializeField]
    private float _zPosAddition;

    [SerializeField]
    private float _heightOfCamera;

    private void Start() {
        if (Instance != null) {
            Destroy(this);
        }
        Instance = this;
    }

    void Update() {
        mainCamera.transform.position = Vector3.Lerp(
            mainCamera.transform.position,
            new Vector3(Player.playerTransform.transform.position.x, Player.playerTransform.transform.position.y + _heightOfCamera, Player.playerTransform.transform.position.z + -_zPosAddition),
            _speedOfFollowing);
    }
}
