using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Vector3 AngleRotation;
    public void QuaternionRotation()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            GameManager.Instance.GainCoin();
            Destroy(this.gameObject);
        }
    }
}
