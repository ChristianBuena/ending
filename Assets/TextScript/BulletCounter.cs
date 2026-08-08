using UnityEngine;
using TMPro;
using Mono.Cecil;

public class BulletCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bulletText;
    [SerializeField] private ResourceStats bulletStat;

    void Start()
    {
        bulletStat = GameObject.FindWithTag("Bullet").GetComponent<ResourceStats>();
    }
    public void UpdateBulletText()
    {
       bulletText.text = $"Ammo: {bulletStat.CurrentAmount}"; 
    }

}
