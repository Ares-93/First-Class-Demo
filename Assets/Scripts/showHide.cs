using UnityEngine;

public class showHide : MonoBehaviour
{

    public GameObject car;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void  ShowObject()
    {
        car.SetActive(true);
    }

    public void HideObject()
    {
        car.SetActive(false);
    }
}
