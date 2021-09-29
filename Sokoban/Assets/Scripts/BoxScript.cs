using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public Sprite blueBox, defaultBox;
    public GameObject GameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = blueBox;
        GameManager.GetComponent<GameManagerScript>().TotalBoxes--;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = defaultBox;
        GameManager.GetComponent<GameManagerScript>().TotalBoxes++;
    }
}
