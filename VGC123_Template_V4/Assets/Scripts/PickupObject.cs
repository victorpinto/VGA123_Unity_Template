using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public Transform PickupPoint;
    public Transform DropboxSpot;
    //public Rigidbody rb;

    public void Pickup()
    {
        gameObject.transform.parent = PickupPoint.transform;
        transform.localPosition = Vector3.zero;
        //rb.isKinematic = true;
        Debug.Log("TriggeredParent");
        //gameObject.SetActive (false); 
    }

    public void DropBox()
    {
        gameObject.transform.parent = DropboxSpot.transform;
        transform.localPosition = Vector3.zero;
        //rb.isKinematic = true;
        Debug.Log("TriggeredDrop");
        //gameObject.SetActive (false); 
    }
}
