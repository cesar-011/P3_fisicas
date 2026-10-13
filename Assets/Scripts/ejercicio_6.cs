using UnityEngine;

public class ejercicio_6 : MonoBehaviour
{
  public float velocidad = 0.6f;
  public Material materialCubo;
  private GameObject cilindro;
  private Collider colliderCubo;
  private Renderer rendererCubo;
  private Collider miCollider;

  private bool tocado = false;

  void Start() {
    cilindro = GameObject.FindGameObjectWithTag("cilindro_ej6");

    GameObject cubo = GameObject.FindGameObjectWithTag("cubo_ej6");

    colliderCubo = cubo.GetComponent<Collider>();
    rendererCubo = cubo.GetComponent<Renderer>();

    miCollider = GetComponent<Collider>();
  }

  void Update() {
    Vector3 direccion = (cilindro.transform.position - transform.position).normalized;

    transform.position += direccion * velocidad * Time.deltaTime;

    if (miCollider.bounds.Intersects(colliderCubo.bounds) && !tocado) {
      rendererCubo.material = materialCubo;
      tocado = true;
    }
  }
}
