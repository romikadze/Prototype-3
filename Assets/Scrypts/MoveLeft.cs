using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed = 25;
    PlayerController playerControllerScrypt;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScrypt = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerControllerScrypt.gameOver)
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if(transform.position.x < -15 && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
