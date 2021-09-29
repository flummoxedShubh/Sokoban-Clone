using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public int TotalBoxes = 4;
    public Text winnerText;
    public RawImage winnerScreen;
    //public GameObject Level;
    public GameObject player;
    public GameObject Box_1;
    public GameObject Box_2;
    public GameObject Box_3;
    public GameObject Box_4;

    Vector3[] BoxPositions = new Vector3[4];
    Vector3 playerPosition;

    private void Start()
    {
        BoxPositions[0] = Box_1.transform.position;
        BoxPositions[1] = Box_2.transform.position;
        BoxPositions[2] = Box_3.transform.position;
        BoxPositions[3] = Box_4.transform.position;
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(TotalBoxes == 0)
        {
            //Debug.Log("YOU'RE A WINNER");
            winnerText.gameObject.SetActive(true);
            winnerScreen.gameObject.SetActive(true);
            
            Time.timeScale = 0.0f;
        }
    }

    public void ResetPressed()
    {
        Debug.Log("x: " + player.transform.position.x + "y: " + player.transform.position.y + "z: " + player.transform.position.z);
        player.transform.position = playerPosition;
        Box_1.transform.position = BoxPositions[0];
        Box_2.transform.position = BoxPositions[1];
        Box_3.transform.position = BoxPositions[2];
        Box_4.transform.position = BoxPositions[3];
    }
}
