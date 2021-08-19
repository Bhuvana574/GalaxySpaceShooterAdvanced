using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    [SerializeField]
    private float laserSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);
        if (transform.position.y >= 6)
        {
            if (transform.parent != null)
            {
                Destroy(transform.parent);
            }

            Destroy(this.gameObject);
        }
    }
}
