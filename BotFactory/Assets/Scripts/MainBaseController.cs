using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBaseController : MonoBehaviour {

    public Transform SpawnPoint;
    public GameObject Unit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnUnit()
    {
        Instantiate(Unit, SpawnPoint.position, SpawnPoint.rotation);
    }
}
