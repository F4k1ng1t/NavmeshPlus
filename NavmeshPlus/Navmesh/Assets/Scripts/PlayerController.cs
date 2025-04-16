using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera cam;
    // Update is called once per frame
    private void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Debug.Log("this is running");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("bruh");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) 
            {
                // MOVE OUR AGENT
                agent.SetDestination(hit.point);
                Debug.Log($"testing : {hit.point.ToString()}");
            }
                
        }
    }
}
