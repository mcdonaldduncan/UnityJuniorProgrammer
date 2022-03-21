using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField]private float speed = 30;

    private float leftBound = -15;
    private PlayerController playerControllerScript;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
