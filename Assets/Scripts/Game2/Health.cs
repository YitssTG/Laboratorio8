using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            GameManager.Instance.ModifyLife(_health);
            Destroy(this.gameObject);
        }
    }
}
