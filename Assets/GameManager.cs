using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject UnitPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Buttons to spawn units (friendly)
    public void SpawnRiflemanUnit(bool friendly) {
        // print("Clicked!");
        // Instantiate(UnitPrefab);
        var obj = Instantiate(UnitPrefab, new Vector3(Random.Range(-18, -14), -2, 0), Quaternion.identity);
        if (friendly)
            transform.localScale = new Vector3(1, 1, 0);
        else
            transform.localScale = new Vector3(-1, -1, 0);


    }
    //     public void SpawnOfficerUnit(bool friendly) {
    //     // print("Clicked!");
    //     Instantiate(UnitPrefab);
    // }
}
