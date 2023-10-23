using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{

    public int scoreValue;
    public GameObject newBasketball;
    private bool dospawn = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BasketBall"))
        {
            scoreValue++;
            Score textController = FindObjectOfType<Score>();
            textController.UpdateText("Score: " + scoreValue);
            Destroy(other.gameObject, 2);
            dospawn = true;
            if (dospawn == true)
            {
                Instantiate(newBasketball, new Vector3(1.88f, 1.65f, -0.04f), Quaternion.identity);
                dospawn = false;
            }

        }
    }
}

 
