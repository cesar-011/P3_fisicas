using UnityEngine;

public class ejercicio_3 :MonoBehaviour
{
  public float velocidad = 0.5f;
  private Rigidbody rb;
  private Vector3 movimiento;
  private Renderer miRender;
  private Color colorOriginal;
  public float daño = 0.5f;

  void Start() {
    rb = GetComponent<Rigidbody>();

    miRender = GetComponent<Renderer>();
    // Guardamos el color inicial
    if (miRender != null) {
      colorOriginal = miRender.material.color;
    }
  }

  void Update() {
    float ejeX = Input.GetAxisRaw("Horizontal");
    float ejeZ = Input.GetAxisRaw("Vertical");

    movimiento = new Vector3(ejeX, 0 , ejeZ).normalized;
  }

  void FixedUpdate() {
    Vector3 nuevaPosicion = rb.position + movimiento * velocidad * Time.fixedDeltaTime;
    rb.MovePosition(nuevaPosicion);
  }

  void OnTriggerEnter(Collider trigger) {

    if (trigger.gameObject.CompareTag("zona_color")) {
      if (miRender != null) {
        miRender.material.color = Color.red;
      }
    } else if (trigger.gameObject.CompareTag("zona_daño")) {
        daño += 10.0f;
    }
  }

  void OnTriggerExit(Collider trigger) {
    if (miRender != null) {
      // Cambiamos el color al original
      miRender.material.color = colorOriginal;
    }
  }
}
