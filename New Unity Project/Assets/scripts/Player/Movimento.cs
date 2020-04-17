using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    public float Velocidade;
    private Rigidbody2D rb;
    private Animator anim;

    // Start is called before the first frame update
    
    private void OnEnable() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
    }

    void Movimentacao(){
        float hDirection = Input.GetAxisRaw("Horizontal");
        float vDirection = Input.GetAxisRaw("Vertical");
        

        //Vertical
        if(vDirection>0.1){
            AnimVertical();
            rb.velocity = new Vector2(rb.velocity.x, Velocidade);
        }
        else if(vDirection<-0.1){
            AnimVertical();
            rb.velocity = new Vector2(rb.velocity.x, -Velocidade);
        }
        else{
            anim.SetBool("Horizontal", false);
            rb.velocity = new Vector2(0,rb.velocity.y);
        }
        //Vertical

        //Horizontal
        
        if(hDirection>0.2){
            transform.localScale = new Vector2(1,1);
            AnimHorizontal();
            rb.velocity = new Vector2(Velocidade, rb.velocity.y);
        }
        else if(hDirection<-0.2){
            transform.localScale = new Vector2(-1,1);
            AnimHorizontal();
            rb.velocity = new Vector2(-Velocidade, rb.velocity.y);
        }
        else{
            anim.SetBool("Horizontal", false);
            rb.velocity = new Vector2(0,rb.velocity.y);
        }
        //Horizontal

    }



    //Animações

    private void AnimHorizontal(){
        anim.SetBool("Horizontal", true);
    }
    private void AnimVertical(){
        anim.SetBool("Vertical", true);
    }




}
