using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;
    [SerializeField] GameObject projectile5;

    [SerializeField] GameObject dropbox;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player")
        {
            projectile.SetActive(true);
            projectile2.SetActive(true);
            projectile3.SetActive(true);
            projectile4.SetActive(true);
            projectile5.SetActive(true);

            dropbox.SetActive(true);
        }
    }
}