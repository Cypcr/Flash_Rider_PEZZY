using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;

     [SerializeField]
    private float _bulletSpeed;

    private bool _fireContinously;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (_fireContinously)

        FireBullet();
    }

    private void FireBullet()
    {
        GameObject bullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();

        rigidbody.velocity = _bulletSpeed * transform.up;
    }

    private void OnFire(InputValue inputValue)
    {
        _fireContinously = inputValue.isPressed;
    }
}
