using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIiControle : MonoBehaviour
{
    public GameObject goal; // Objetivo que o AI irá seguir
    private UnityEngine.AI.NavMeshAgent agent; // Referência para o componente NavMeshAgent

    void Start() {
        // Pega a referência do NavMeshAgent
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        // Verifica se o objetivo foi atribuído
        if (goal != null) {
            // Define o destino para o objetivo
            agent.SetDestination(goal.transform.position);
        } else {
            Debug.LogError("O GameObject goal não foi atribuído.");
        }
    }

    void Update() {
        // O código de atualização pode ser adicionado aqui, caso seja necessário
    }
}
