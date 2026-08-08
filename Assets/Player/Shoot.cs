
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot: MonoBehaviour
{
    [Header("Shooting Setting")]
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireRate = 0.2f;
    [SerializeField] private float fireForce;
    private float nextFireTime;

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current != null && Mouse.current.leftButton.isPressed && Time.time >= nextFireTime)
        {
            OnShoot();
            nextFireTime = Time.time + fireRate;  
        }
    }

    private void OnShoot()
    {
        // to produce bullet instance
        GameObject bullet = Instantiate(
            bulletPrefab,
            firePoint.position,
            firePoint.rotation);


        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }

}
