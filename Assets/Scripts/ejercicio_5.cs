using UnityEngine;

public class ejercicio_5 : MonoBehaviour
{
  public float fuerzaLanzamiento = 0.5f;
  private Rigidbody rb;
  private bool lanzar = false;

  void Start() {
    rb = GetComponent<Rigidbody>();
  }

  void Update() {
    if (Input.GetKey(KeyCode.X)) {
      lanzar = true;
    }
  }

  void FixedUpdate() {
    if (lanzar) {
      rb.AddForce(Vector3.forward * fuerzaLanzamiento, ForceMode.Impulse);
      lanzar = false;
    }
  }
}
