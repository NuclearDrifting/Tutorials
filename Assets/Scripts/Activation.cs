using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActivation : MonoBehaviour
{

    public Text newText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {  
            newText.text = "Hi, my name is what!";
        }

        if (Input.GetKey("escape"))
        {
            Application.quit();    
        }
    }
}
