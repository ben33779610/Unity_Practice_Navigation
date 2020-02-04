using UnityEngine;
using UnityEngine.AI;

public class DogMove : MonoBehaviour
{
    private NavMeshAgent agent;    //宣告NavMeshAgent
    private Animator ani;

    public float xMin;
    public float zMin;
    public float xMax;
    public float zMax;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void Move() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            float randX = Random.Range(xMin, xMax);
            float randZ = Random.Range(zMin, zMax);
            ani.SetBool("跑步開關",true);
            agent.destination = new Vector3(randX,transform.position.y ,randZ);
        }
    }

}
