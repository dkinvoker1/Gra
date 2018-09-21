using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour {
    public bool active = false;
    private void FixedUpdate()
    {
        if (active)
        {
            Move move=(Move)transform.GetComponent(typeof(Move));
            if (move!=null)
            {
                move.MoveForward();
            }

        }

    }
}
