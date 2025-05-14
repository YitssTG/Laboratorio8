using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] pivotPoints;
    private Rigidbody rb;
    [SerializeField] private float Speed;
    private int currentPoint;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        currentPoint = 0;
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        Vector3 Direction = (pivotPoints[currentPoint].position - transform.position).normalized;
        Vector3 target = transform.position + Direction * Speed * Time.deltaTime;

        rb.MovePosition(target);

        UpdatePivot();
    }
    private void UpdatePivot()
    {
        if (Vector3.Distance(pivotPoints[currentPoint].position, transform.position) < 0.1)
        {
            if (currentPoint >= pivotPoints.Length - 1)
            {
                currentPoint = 0;
            }
            else
            {
                currentPoint++;
            }
        }
    }
}
