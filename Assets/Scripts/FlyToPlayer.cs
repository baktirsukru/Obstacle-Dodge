using Unity.VisualScripting;
using UnityEngine;

public class FlyToPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;

    [SerializeField] float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake()
    {
        gameObject.SetActive(false);
    }
    
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }
        

    void MoveToPlayer()
    {
        transform.position = 
        Vector3.MoveTowards(transform.position, playerPosition, (Time.deltaTime * moveSpeed));
    }
    

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
