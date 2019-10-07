using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CollisionTracker : MonoBehaviour
{

    private float Health;
    Material material;
    private float G = 1f;
    private float B = 1f;
    public Text Damage;

    // Start is called before the first frame update
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        material = renderer.material;
        SetDamageText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacles"))
        {
            Debug.Log(Health);
            if (Health < 100)
            {
                Health += 1;
                SetDamageText();
                G -= 0.01f;
                B -= 0.01f;
                material.color = new Color(1f, G, B, 1f);
            }
             
            //Debug.Log("hello");
        }
    }

    void SetDamageText()
    {
        Damage.text = "Damage: " + Health.ToString() + "%";
    }
}
