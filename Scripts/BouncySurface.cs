using UnityEngine;

public class BouncySurface : MonoBehaviour {
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D other) {
        Ball ball = other.gameObject.GetComponent<Ball>();

        if(ball == null) return;

        Vector2 normal = other.GetContact(0).normal;
        ball.AddForce(-normal * this.bounceStrength);
    }
}
