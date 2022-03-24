using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Ball ball;

    public Text textScorePlayer;
    public Text textScoreComputer;
    public Text textWin;
    public Text textDefeat;
    public Text textReset;

    private int playerScore;
    private int computerScore;

    public bool gameOver = false;

    private void Update() {
        textScorePlayer.text = playerScore.ToString();
        textScoreComputer.text = computerScore.ToString();
        if(playerScore == 3 && computerScore == 0 || playerScore == 5){
            Victory();
        }
        else if(computerScore == 3 && playerScore == 0 || computerScore == 5){
            Defeat();
        }
    }

    public void PlayerScores(){
        playerScore++;
        ball.ResetBall();
    }

    public void ComputerScores(){
        computerScore++;
        ball.ResetBall();
    }

    void Victory(){
        ball.StopBall();
        ball.SetPosition(8.7f);
        textReset.enabled = true;
        textWin.enabled = true;
        gameOver = true;
        ResetGame();
    }

    void Defeat(){
        ball.StopBall();
        ball.SetPosition(-8.7f);
        textReset.enabled = true;
        textDefeat.enabled = true;
        gameOver = true;
        ResetGame();
    }

    void ResetGame(){  
        if(Input.GetKeyDown(KeyCode.Space)){
            textDefeat.enabled = false;
            textWin.enabled = false;
            textReset.enabled = false;
            playerScore = 0;
            computerScore = 0;
            gameOver = false;
            ball.ResetBall();
        }
    }
}
