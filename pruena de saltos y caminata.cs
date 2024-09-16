if (Input.GetKey("d")) //si estoy pulsando la letra d
        {
            rb2d.velocity = new Vector2(5, rb2d.velocity.y); // mueve a la derecha
            if (isGrounded) // si está en el piso la animación es caminar
                animator.Play("player_walk");
            spriteRenderer.flipX = false;
        }
       else if (Input.GetKey("a")) //si estoy pulsando a
        {
            rb2d.velocity = new Vector2(-5, rb2d.velocity.y); //mueve a la izquierda
            if (isGrounded)
                animator.Play("player_walk"); 
            spriteRenderer.flipX = true; //invierto el sprite para que parezca que el Player giró
        }
        else //si no pulso nada el personaje esta quieto
        {
            if (isGrounded)
                animator.Play("player_idle");
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        if (Input.GetKey("space") && isGrounded) // si pulso la tecja espacio
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 8); //muevo el personaje hacia arriba
            animator.Play("player_jump"); // y hacemos que la animación cambie a brincar
        }