
using UnityEngine;



public class Puerta : MonoBehaviour
{

    Animator anim;


    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0)){
            //ChangeRoom();
            anim.SetTrigger("Cerrar");    
        }

    }
}
