using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody2D _rigidbody;
    public float speed;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start() {
        ResetBall();
    }

    public void ResetBall(){
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;

        AddInitialForce();
    }

    void AddInitialForce(){
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        _rigidbody.AddForce(new Vector2(x, y) * this.speed);
    }

    public void AddForce(Vector2 force){
        _rigidbody.AddForce(force);
    }

    public void StopBall(){
        _rigidbody.velocity = Vector3.zero;
    }

    public void SetPosition(float x){
        _rigidbody.position = new Vector3(x, 0, 0);
    }
}
