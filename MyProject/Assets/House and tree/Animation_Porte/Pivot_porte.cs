using UnityEngine;
using System.Collections;

public class Pivot_porte : MonoBehaviour
{
    public GameObject Pivot, Porte;
    
    void OnTriggerEnter()
    {
        Porte.transform.RotateAround(Pivot.transform.position, Vector3.up, 90);
    }
    void OnTriggerExit()
    {
        Porte.transform.RotateAround(Pivot.transform.position, -Vector3.up, 90);
    }
}