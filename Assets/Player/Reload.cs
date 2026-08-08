using System.Collections;
using UnityEngine;

public class Reload: MonoBehaviour
{
    private ResourceStats bulletStats;
    private bool isReloading;
    public bool IsReloading => isReloading;
    private BulletCounter bulletCounter;

    void Start()
    {
        bulletStats = GetComponent<ResourceStats>();
        bulletCounter = GameObject.FindWithTag("Canvas").GetComponent<BulletCounter>();
    }

    public void ReloadAmmo()
    {
        if(isReloading) return;
        StartCoroutine(Reloading());   
    }

    public IEnumerator Reloading()
    {
        isReloading = true;

        bulletCounter.ReloadingBulletText();

        yield return new WaitForSeconds(3f);
        bulletStats.ResourceIncrease(50);

        isReloading = false;

        bulletCounter.UpdateBulletText();
    }
}
