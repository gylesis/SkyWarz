using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static Transform playerTransform;

    [SerializeField]
    private Rigidbody _rb;

    private Vector3 _correction;

    [SerializeField]
    private float _rotation;

    [SerializeField]
    private float _speed;

    private void Start() {
        playerTransform = GetComponent<Transform>();
    }

    void Update() {
        Move();     
    }

    private void Move() {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");

        _correction = Quaternion.Euler(new Vector3(0f, -_rotation, 0f)) * new Vector3(yInput / _speed, 0, -xInput / _speed);

        RotateFromMouseVector();

        _rb.transform.position += _correction;
    }


    private void RotateFromMouseVector() {
        Ray ray = CameraController.Instance.mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hitInfo, maxDistance: 300f)) {
            var target = hitInfo.point;
            target.y = transform.position.y;
            transform.LookAt(target);
        }
    }
}
