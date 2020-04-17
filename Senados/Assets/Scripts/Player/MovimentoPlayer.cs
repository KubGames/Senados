using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{

    public float Velocidade;

    private Rigidbody2D rb;
    private Animator anim;
    /*
    B = baixo
    C = cima
    H  = horizontal
    */
    private enum State{paradoB,paradoC,paradoH,andandoB,andandoC,andandoH}

    private void OnEnable() {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
    }

    private void Movimento(){
        float hDirection = Input.GetAxisRaw("Horizontal");
        float vDirection = Input.GetAxisRaw("Vertical");

        //Horicontal
        //Direita
        if(hDirection>0.1){
            rb.velocity = new Vector2(Velocidade,rb.velocity.y);
            transform.localScale = new Vector2(1,1);
        }
        //Esquerda
        else if(hDirection<-0.1){
            rb.velocity = new Vector2(-Velocidade,rb.velocity.y);
            transform.localScale = new Vector2(-1,1);
        }
        else{
            rb.velocity = new Vector2(0,rb.velocity.y);
        }
        //
        //Vertical
        //Cima
        if(vDirection>0.1){
            rb.velocity = new Vector2(rb.velocity.x, Velocidade);
        }
        //Baixo
        else if(vDirection<-0.1){
            rb.velocity = new Vector2(rb.velocity.x, -Velocidade);
        }
        else{
            rb.velocity = new Vector2(rb.velocity.x, 0);
            Animacao(0);
        }
        //
    }

    private void Animacao(int estado){


    }

}
