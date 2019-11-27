﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EventTriggers : MonoBehaviour
{
        [Header("Customization")]
        [Tooltip("PressButton can only be used for OnTriggerStay")]    
        public bool PressButton = false;
        public string ButtonChoice = null;
        public bool ReloadScene = false;
        public GameObject[] objectsThatTrigger;
    // a bunch of callbacks that let us do things 
        [Header("Events")]
        [SerializeField] public UnityEvent OnEnter;
        [SerializeField] private float UnityEventtickDelta;
        [SerializeField] public UnityEvent OnStay;
        [SerializeField] public UnityEvent OnExit;

    private void OnTriggerEnter(Collider other)
    {
        foreach (GameObject ObjectToTest in objectsThatTrigger)
        {
            if (other.gameObject == ObjectToTest )
            {
                OnEnter?.Invoke();
                // if the deathbox boolean was checked, restart the scene 
                if (ReloadScene)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
            }
          
        }
       
       

    }

    private void OnTriggerStay(Collider other)
    {
        foreach (GameObject ObjectToTest in objectsThatTrigger)
        {

            //if PressButton is true then we're going to do this as if we need to have a button pressed           
            if (other.gameObject == ObjectToTest && PressButton)
            {
                if (Input.GetKeyDown(ButtonChoice))
                {
                    OnStay?.Invoke();
                }
            }
            else if (other.gameObject == ObjectToTest && !PressButton)
            {
                OnStay?.Invoke();
            }

        }
    }

        private void OnTriggerExit(Collider other)
    {
        foreach (GameObject ObjectToTest in objectsThatTrigger)
        {
            if (other.gameObject == ObjectToTest)
            {
                OnExit?.Invoke();
            }

        }
    }

}


