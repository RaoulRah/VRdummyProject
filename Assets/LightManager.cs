using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject _light;
    bool isAllume = true;
    Transform[] _transformInChildren;
    void Start()
    {
        _transformInChildren = transform.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void Lumiere(){
        

            foreach (Transform TransformChild in _transformInChildren)
            {
                if(TransformChild.gameObject.activeSelf){
                    TransformChild.gameObject.SetActive(false) ;
                }else{
                     TransformChild.gameObject.SetActive(true) ;
                }
            }


        // if(!isAllume){
        //     _light.SetActive(true);
        //     isAllume = true;
        // }else{
        //     _light.SetActive(false);
        //     isAllume = false;
        //  }

    }
}
