using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwitchBuilding : MonoBehaviour
{
    [SerializeField] TMP_Text currentBuildingToBuildText;
    [SerializeField] string[] buildingTypes = { "Farmer", "Wall", "Fighter",};

    public int selectedBuildingInt;

    // Start is called before the first frame update
    void Start()
    {
        selectedBuildingInt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            selectedBuildingInt += 1;
        }
        if (selectedBuildingInt > 2)
        {
            selectedBuildingInt = 0;
        }
        DisplayCurrentBuilding();
    }

    void DisplayCurrentBuilding()
    {
        currentBuildingToBuildText.text = buildingTypes[selectedBuildingInt];
    }
}
