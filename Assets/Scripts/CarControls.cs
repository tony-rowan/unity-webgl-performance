using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CarControls : MonoBehaviour {

    [SerializeField] private float turnForceAmplifier;
    [SerializeField] private float forwardForceAmplifier;

    private Rigidbody rigidBody;

    private void Awake() {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            rigidBody.AddForce(transform.forward * forwardForceAmplifier);
        } else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
            rigidBody.AddForce(-transform.forward * forwardForceAmplifier);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            transform.Rotate(Vector3.up, -turnForceAmplifier);
        } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            transform.Rotate(Vector3.up, turnForceAmplifier);
        }
    }
}
