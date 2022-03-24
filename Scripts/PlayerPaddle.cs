using UnityEngine;

public class PlayerPaddle : Paddle {

    private Vector2 _direction;
    

    private void Update() {
        OnIput();
    }

    private void FixedUpdate() {
        if(controller.gameOver) return;
        OnMove();
    }

    void OnIput(){
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            _direction = Vector2.up;
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            _direction = Vector2.down;
        }
        else{
            _direction = Vector2.zero;
        }
    }

    void OnMove(){
        _rigidbody.AddForce(_direction * this.speed);
    }
}
