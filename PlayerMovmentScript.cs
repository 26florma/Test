using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMomentScript : MonoBehaviour
{
    public int stemCells;
    public int damage = 1;
    public GameObject germs;
    
    // Start is called before the first frame update
    void Start()
    {
      germs = GameObject.FindGameObjectWithTag("germ")
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition.normalized;
        transform.position = mousePos;
    }
}
