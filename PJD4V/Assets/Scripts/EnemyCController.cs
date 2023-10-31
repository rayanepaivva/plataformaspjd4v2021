using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCController : MonoBehaviour
{
    [SerializeField] private float changeDirectionTime;
    
    private Vector2 walkDirection;
    
    private float _currentChangeTime;
    
    private Animator enemyAI;


    // Start is called before the first frame update
    void Start()
    {
        enemyAI = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveDirection();
        CountTime();
    }

    public void SetWalkDirection(Vector2 direction)
    {
        walkDirection = direction;
    }

    public void MoveDirection()
    {
        transform.Translate(walkDirection * Time.deltaTime);
    }

    public void CountTime()
    {
        if (_currentChangeTime <= changeDirectionTime)
        {
            _currentChangeTime += Time.deltaTime;
        }
        else
        {
            _currentChangeTime = 0; // mudar a direção de andar 
            enemyAI.SetTrigger("ChangeDirection");
        }
    }
}
