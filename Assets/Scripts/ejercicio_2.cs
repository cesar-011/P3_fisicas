using UnityEngine;

public class ejercicio_2 : MonoBehaviour
{
    void OnCollisionEnter(Collision colision)
    {
      Debug.Log("He chocado con: " + colision.gameObject.name);

        Renderer renderObjetoGolpeado = colision.gameObject.GetComponent<Renderer>();
        
        if (renderObjetoGolpeado != null)
        {
          renderObjetoGolpeado.material.color = Random.ColorHSV();
        }
    }
}
