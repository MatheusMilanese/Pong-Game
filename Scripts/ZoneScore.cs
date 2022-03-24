using UnityEngine;

public class ZoneScore : MonoBehaviour {
    [SerializeField] GameManager controller;

    private void OnCollisionEnter2D(Collision2D other) {
        if(transform.position.x < 0) controller.ComputerScores();
        else controller.PlayerScores();
    }
}
