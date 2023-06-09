
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    
    [SerializeField]private GameObject[] scenes;
    int actualRoom = 0;
    
   

    // Start is called before the first frame update
    void Start()
    {

       foreach(GameObject scene in scenes)scene.SetActive(false);
       ActiveRoom(0);
        //Debug.Log("aparece"); 
    }

    void ActiveRoom(int index)
    {
        scenes[actualRoom].SetActive(false);
        actualRoom = index;
        scenes[actualRoom].SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void ChangeRoom()
    {
        int newIndex = (actualRoom + 1) % scenes.Length;
        ActiveRoom(newIndex);
        Debug.Log("Cambia" + newIndex);

    }
}
