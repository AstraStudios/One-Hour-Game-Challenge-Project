using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyController : MonoBehaviour
{
    [SerializeField] TMP_Text enemyHealthBar;
    public int enemyHealth = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealthChecker();
    }

    void HealthChecker()
    {
        enemyHealthBar.text = enemyHealth.ToString();
        if (enemyHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
