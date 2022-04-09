using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/*
public class Jogador : Personagem
{
    private RaycastHit hit;
    private Ray ray;
    public LayerMask camadaClicavel;

    public float danoAtaque;
    public float tempoEntreAtaques;
    public float alcanceAtaque;
    private float tempoProximoAtaque;
    public LayerMask camadaInimigo;
    private GameObject inimigo;

    protected override void Start ()
    {
        base.Start ();
        
    }


    private void Update()
    {
        Movimento ();
        Atacar ();
        AnimaJogador ();
    }

    void Movimento()
    {
        ray = Camera.main.ScreenPointToRay (Input.mousePosition);

        if (Physics.Raycast (ray, out hit, camadaClicavel) && Input.GetMouseButtonDown (1))
        {
            Debug.DrawLine (ray.origin, hit.point, Color.green);
            agent.SetDestination (hit.point);
        }
    }

    void Atacar()
    {
        ray = Camera.main.ScreenPointToRay (Input.mousePosition);

        if (Physics.Raycast (ray, out hit, camadaInimigo))
        {
            inimigo = hit.collider.gameObject;
            Debug.Log (inimigo.name);
            Debug.DrawLine (ray.origin, hit.point, Color.red);

            float distancia = Vector3.Distance (inimigo.transform.position, transform.position);
            
            if(distancia <= alcanceAtaque && Time.time >= tempoProximoAtaque && Input.GetMouseButtonDown (0))
            {
                //Faz o jogador ficar virado em direção ao inimigo
                transform.LookAt (inimigo.transform.position);
                Ataque_Corpo_A_Corpo ();
            }
        }
        
    }

    void Ataque_Corpo_A_Corpo ()
    {
        tempoProximoAtaque = Time.time + tempoEntreAtaques;
  
        
        //Ativa animacao do ataque
        anim.SetTrigger ("Atacar");

        //causa dano aos inimigos acertados
        switch (inimigo.tag)
        {
            case "Zombie":
                inimigo.GetComponent<Zombie> ().RecebeDano (danoAtaque);
                break;

            case "NighShade":

                break;
        }
        inimigo = null;
    }

    void AnimaJogador()
    {
        float velocidade = agent.velocity.normalized.magnitude;
        anim.SetFloat ("Velocidade", velocidade);
        anim.SetBool ("Morto", morto);
    }

    public override void RecebeCura (float cura)
    {
        base.RecebeCura (cura);
    }

    public override void RecebeDano (float dano)
    {
        base.RecebeDano (dano);     
    }


    
}
*/