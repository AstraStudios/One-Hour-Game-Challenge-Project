using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlaceBuildings : MonoBehaviour
{
    // farmer
    [SerializeField] GameObject farmer;
    [SerializeField] GameObject farmerParent;
    GameObject farmerChild;

    [SerializeField] GameObject switchBuildingObject;
    SwitchBuilding switchBuildingScript;

    float gridSize = 2f; // trying to make the farmer attach to grid
    // Start is called before the first frame update
    void Start()
    {
        switchBuildingScript = switchBuildingObject.GetComponent<SwitchBuilding>();
    }

    // Update is called once per frame
    void Update()
    {
        PlaceFarmer();
    }

    void PlaceFarmer()
    {
        if (Input.GetMouseButtonDown(0) && switchBuildingScript.selectedBuildingInt == 1)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Look for closet grid cell (Part of code generated by chatgpt because couldnt find clean solution
            float x = Mathf.Round(mousePos.x / gridSize) * gridSize;
            float y = Mathf.Round(mousePos.y / gridSize) * gridSize;
            Vector2 gridPos = new Vector2(x, y);
            farmerChild = Instantiate(farmer, gridPos, Quaternion.identity);
            farmerChild.transform.parent = farmerParent.transform;
        }
    }

    void PlaceWall()
    {
        if (Input.GetMouseButtonDown(0) && switchBuildingScript.selectedBuildingInt == 2)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Look for closet grid cell (Part of code generated by chatgpt because couldnt find clean solution
            float x = Mathf.Round(mousePos.x / gridSize) * gridSize;
            float y = Mathf.Round(mousePos.y / gridSize) * gridSize;
            Vector2 gridPos = new Vector2(x, y);
            farmerChild = Instantiate(farmer, gridPos, Quaternion.identity);
            farmerChild.transform.parent = farmerParent.transform;
        }
    }
}
