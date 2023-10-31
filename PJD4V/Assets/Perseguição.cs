using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perseguição : StateMachineBehaviour
{
    private Transform player; // Referência ao jogador
    public float velocidadeMovimento = 5f; // Velocidade de movimento do inimigo
    private Animator animator; // Referência ao Animator do inimigo

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform; // Encontre o jogador pela tag
        animator.gameObject.GetComponent<Animator>(); // Obtenha o componente Animator do inimigo
    }

    private void Update()
    {
        Vector3 direcao = player.position - transform.position;
        float distancia = direcao.magnitude;

        // Verifique se a distância é maior que um valor para iniciar ou parar a perseguição
        if (distancia > 1.0f)
        {
            direcao.Normalize();
            transform.Translate(direcao * velocidadeMovimento * Time.deltaTime);
            animator.SetBool("Perseguindo", true); // Defina o parâmetro "Perseguindo" como verdadeiro
        }
        else
        {
            animator.SetBool("Perseguindo", false); // Defina o parâmetro "Perseguindo" como falso
        }
    }
}


    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
