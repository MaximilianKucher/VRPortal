using UnityEngine;

public class GunPos : MonoBehaviour
{
    private BoxCollider parentCollider;
    private BoxCollider objCollider;
   
    void Start()
    {
        parentCollider = GetComponentInParent<BoxCollider>();
        objCollider = this.GetComponent<BoxCollider>();
    }

    void Update()
    {
        objCollider.transform.position = parentCollider.transform.position;
        objCollider.transform.rotation = parentCollider.transform.rotation;
    }
}
