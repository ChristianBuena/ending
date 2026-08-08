
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
    private ResourceStats bulletCount;
    private Reload reload;

    private BulletCounter bulletCounter;

    void Start()
    {
        bulletCount = GetComponent<ResourceStats>();
        bulletCounter = GameObject.FindWithTag("Canvas").GetComponent<BulletCounter>();
        reload = GetComponent<Reload>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current == null)
            return;

        if (!Mouse.current.leftButton.isPressed)
            return;

        if (Time.time < nextFireTime)
            return;

        if (bulletCount.IsEmpty)
        {
            reload.ReloadAmmo();
            return;
        }

        OnShoot();
        bulletCounter.UpdateBulletText();

        nextFireTime = Time.time + fireRate;

        Debug.Log($"Current Ammo: {bulletCount.CurrentAmount}");

        if (bulletCount.CurrentAmount < 20)
        {
            Debug.Log($"Low Ammo: {bulletCount.CurrentAmount}");

        }

        if(reload.IsReloading) 
            return;

        if (bulletCount.IsEmpty)
        {
            reload.ReloadAmmo();
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

        bulletCount.ResourceDecrease(1);
    }

}
