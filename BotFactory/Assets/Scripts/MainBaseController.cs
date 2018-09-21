using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainBaseController : MonoBehaviour {

    public Transform SpawnPoint;

    public void SpawnUnit()
    {
        var UnitType = (Object)Resources.Load("Units/Unit");
        GameObject Unit=(GameObject)Instantiate(UnitType, SpawnPoint.position, SpawnPoint.rotation);
        var controler = (UnitController)Unit.GetComponent(typeof(UnitController));
        controler.active = true;
    }
}
