using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;

    }

    void Update()
    {
        
        //Debug.Log("Time since beginning: " + Time.time);
           
          
    
        if(Time.time > timeToWait)
        {
            //Debug.Log("Be careful!!! Somethings falling!");
            myMeshRenderer.enabled = true;
            myRigidBody.useGravity = true;

        }
    }

}
