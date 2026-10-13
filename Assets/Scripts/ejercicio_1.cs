using UnityEngine;

public class ejercicio_1 : MonoBehaviour
{
  public float velocidad = 0.5f;
  private Rigidbody rb;
  private Vector3 movimiento;

  void Start() {
    rb = GetComponent<Rigidbody>();
  }

  void Update() {
    float ejeX = Input.GetAxisRaw("Horizontal");
    float ejeZ = Input.GetAxisRaw("Vertical");

    movimiento = new Vector3(ejeX, 0, ejeZ).normalized;
  }

  void FixedUpdate() {
    Vector3 nuevaPosicion = rb.position + movimiento * velocidad * Time.fixedDeltaTime;

    rb.MovePosition(nuevaPosicion);
  }
}
