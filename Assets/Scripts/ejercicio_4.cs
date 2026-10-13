using UnityEngine;

public class ejercicio_4 : MonoBehaviour
{
  public float velocidad = 1.5f;
  private Vector3 movimiento;
  private Rigidbody rb;
  public float vida = 100f;

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

  void OnCollisionEnter(Collision colision) {
    vida-= 5.0f;
  }

  void OnTriggerEnter(Collider trigger) {
    vida+= 7.0f;
  }
}
