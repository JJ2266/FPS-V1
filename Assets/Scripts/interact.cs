using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class interact : MonoBehaviour
{
    [SerializeField] public UnityEvent interacting;
    [SerializeField] GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerStay(Collider other)
    {
      if (other.gameObject.GetComponent<FPSController>())
      {
            if (Input.GetKeyDown(KeyCode.E)) 
            { 
                interacting.Invoke();
            }
            text.SetActive(true);
      }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<FPSController>())
        { 
            text.SetActive(false);
        }
    }
}


