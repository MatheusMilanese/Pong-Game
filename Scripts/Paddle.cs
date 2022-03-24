using UnityEngine;

public class Paddle : MonoBehaviour {
    public float speed = 10f;

    protected Rigidbody2D _rigidbody;
    [SerializeField] protected GameManager controller;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
