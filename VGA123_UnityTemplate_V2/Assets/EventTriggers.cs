using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EventTriggers : MonoBehaviour
{
        [Header("Checks")]
        public bool Deathbox = false;
        public GameObject[] objectsThatTrigger;
    // a bunch of callbacks that let us do things 
        [Header("Events")]
        [SerializeField] public UnityEvent OnEnter;
        [SerializeField] private float UnityEventtickDelta;
        [SerializeField] public UnityEvent OnTick;
        [SerializeField] public UnityEvent OnExit;

    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject ObjectToTest in objectsThatTrigger)
        {
            if (other.gameObject == ObjectToTest)
            {
                OnEnter?.Invoke();
            }

            // Deathbox Checker, reloads scene when enters trigger 
            if (Deathbox)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
       
       

    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        //OnEnter?.Invoke();
    }

}


