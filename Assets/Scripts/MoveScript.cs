using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveScript : MonoBehaviour
{
    public float speed = 1;
    public TextMeshProUGUI gui;
    public float counter = 0;

    // Start is called before the first frame update
    private void Start()
    {
        if(gui != null)
        {
            gui.text = counter.ToString();
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)){
            transform.position += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            counter++;
            gui.text = counter.ToString();
        }
    }
}
