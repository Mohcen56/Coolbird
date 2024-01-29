using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlepipe : MonoBehaviour
{
    public Logimanager logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logimanager>();
    }

    // Update is called once per frame
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
            logic.addScore(1);
        

    }
}
