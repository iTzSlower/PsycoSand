using UnityEngine;
using UnityEngine.AI;

public class MousePosition : MonoBehaviour
{
    [SerializeField] private Camera maincamera;
    [SerializeField] float Speed = 0.1f;

    NavMeshAgent agent;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit raycastHit) && Input.GetKey(KeyCode.Mouse0))
        {
            agent.SetDestination(raycastHit.point);
        }
    }
}
