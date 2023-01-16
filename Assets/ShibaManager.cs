using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShibaManager : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] Transform _destination;
    [SerializeField] AudioSource _audio;

    [SerializeField] Animator _anim;
    [SerializeField] Transform _player;
    bool battonIsPris;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.SetDestination(_destination.position);
    }

    // Update is called once per frame
    void Update()
    {
        
        _agent.SetDestination(_destination.position);


        if(_agent.remainingDistance <3f && _agent.remainingDistance !=0){
            
            //_agent.isStopped = true;
            _anim.SetBool("marche", true);
            _agent.speed = 1.2f;

        }else if(_agent.remainingDistance >5f && _agent.remainingDistance !=0){

             _anim.SetBool("isRunning", true);

        }
        
        if(_agent.remainingDistance <0.1f && _agent.remainingDistance !=0){
            _audio.Play();
           // _anim.SetBool("marche", false);
             _anim.SetBool("isRunning", false);
             _anim.SetBool("idle", true);
             _agent.isStopped = true;



             if(!battonIsPris){

                


             }
        }
         
        
    }

    public void toggleNodd(){
        if(_anim.GetBool("isNodd")){

           _anim.SetBool("isNodd", false);
        }else{
            _anim.SetBool("isNodd", true) ;
        }
    } 
}
