using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public float objectHealth;

    TMP_Text displayObjectHealth;

    // Start is called before the first frame update
    void Start()
    {
        objectHealth = 500f;
        displayObjectHealth = GetComponentInChildren<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfDead();
        displayObjectHealth.text = Mathf.Round(objectHealth).ToString();
    }

    void CheckIfDead()
    {
        if (objectHealth < 0 && gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
        if (objectHealth < 0 && gameObject.tag == "Player")
        {
            Debug.Log("The Player is dead!");
        }
    }
}
