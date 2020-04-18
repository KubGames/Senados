using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{

    public float Velocidade;

    private bool horizontal;
    private bool cima;
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
        Animacoes();
    }

    private void Movimento(){
        float hDirection = Input.GetAxisRaw("Horizontal");
        float vDirection = Input.GetAxisRaw("Vertical");

        //Horicontal
        
        if(hDirection>0.1 || hDirection<-0.1){
            horizontal = true;
            cima = false;
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
        }
        else{
            rb.velocity = new Vector2(0,rb.velocity.y);
        }
        //
   
   
        //Vertical
   
        if(vDirection>0.1 || vDirection<-0.1){
            horizontal = false;
            //Cima
            if(vDirection>0.1){
                cima = true;
                rb.velocity = new Vector2(rb.velocity.x, Velocidade);
            }
            //Baixo
            else if(vDirection<-0.1){
                cima = false;
                rb.velocity = new Vector2(rb.velocity.x, -Velocidade);
            }
    
        }
        else{
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }

    }

    void Animacoes(){

        if(horizontal){
            anim.SetBool("Horizontal", true);
            anim.SetBool("Cima", false);
            anim.SetBool("Baixo", false);
        }
        else if(!horizontal && cima){
            anim.SetBool("Cima", true);
            anim.SetBool("Baixo", false);
            anim.SetBool("Horizontal", false);
        }
        else if(!horizontal && !cima){
            anim.SetBool("Baixo", true);
            anim.SetBool("Horizontal", false);
            anim.SetBool("Cima", false);
        }

        if(!(rb.velocity.x == 0) || !(rb.velocity.y == 0)){
            anim.SetBool("Andando", true);
        }
        else{
            anim.SetBool("Andando", false);
        }





    }
}
