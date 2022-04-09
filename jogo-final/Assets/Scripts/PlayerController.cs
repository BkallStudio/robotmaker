using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    private RaycastHit hit;
    private Ray ray;
    public LayerMask camadaClicavel;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    void Movimento()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, camadaClicavel) && Input.GetMouseButtonDown(1))
        {
            Debug.DrawLine(ray.origin, hit.point, Color.green);
            agent.SetDestination(hit.point);
        }
    }
}
