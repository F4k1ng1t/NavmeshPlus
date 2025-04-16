using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;
public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera cam;
    public ThirdPersonCharacter character;
    // Update is called once per frame
    private void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
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
        if (agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
    }
}
