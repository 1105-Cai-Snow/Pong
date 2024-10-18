using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject panel;

    [Header("Ball")]
    public GameObject ball;

    [Header("Player One")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player Two")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;
    public GameObject player2Text;

    private int Player1Score = 0;
    private int Player2Score = 0;

    public void Player1Scored(){
        Player1Score++;
        Debug.Log("P1 score = " + Player1Score);
        player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition(-1);
    }
    
    public void Player2Scored(){
        Player2Score++;
        player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition(1);
    }
    
    private void ResetPosition(int direction){
        ball.GetComponent<Ball>().Reset(direction);
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TogglePanel();
        }
    }
    void TogglePanel()
    {
        // Toggle the active state of the panel
        panel.SetActive(!panel.activeSelf);
    }
}
