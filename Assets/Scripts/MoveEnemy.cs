using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{

    public Vector3 move = new Vector3(0,-1,0);
    public float waitTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Death());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += move * Time.deltaTime;
    }

    private IEnumerator Death()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }
}
