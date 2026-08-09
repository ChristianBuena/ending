using UnityEngine;
using TMPro;

public class HealthCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private EntityStats entityStats;

    void Start()
    {
        entityStats = GameObject.FindWithTag("Player").GetComponent<EntityStats>();
    }

    public void UpdateHealthText()
{
    healthText.text = $"Health: {entityStats.Health.CurrentValue}";
}
}
