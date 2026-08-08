using UnityEngine;
using TMPro;
using Mono.Cecil;

public class BulletCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bulletText;
    [SerializeField] private ResourceStats bulletStat;

    void Start()
    {
        bulletStat = GameObject.FindWithTag("Weapon").GetComponent<ResourceStats>();
        bulletText.text = $"Ammo: {bulletStat.CurrentAmount}"; 
    }
    public void UpdateBulletText()
    {
       bulletText.text = $"Ammo: {bulletStat.CurrentAmount}"; 
    }

    public void ReloadingBulletText()
    {
        bulletText.text = "Ammo: Reloading"; 
    }

}
