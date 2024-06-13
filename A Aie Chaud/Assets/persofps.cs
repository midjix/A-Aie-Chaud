using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persofps : MonoBehaviour
{

    //camera
    public Camera playerCamera;

    //Composant qui permet de faire bouger le joueur
    CharacterController characterController;

    //vitesse de marche
    public float walkingspeed = 7.5f;

    //vitesse de course
    public float runningspeed = 15f;

    //vitesse de saut
    public float jumpspeed = 8f;

    //gravité
    float gravity = 20f;

    //Déplacement
    Vector3 moveDirection;

    //Marche ou court ?
    private bool isRunning = false;

    //rotation de la caméra
    float rotationX = 0;
    public float rotationSpeed = 2.0f;
    public float rotationXLimit = 45.0f;

    //start is called before the first frame update

    private void Start()
    {
        //Cache le curseur de la souris
        Cursor.visible = false;
        characterController = GetComponent<CharacterController>();
    }

    //Update is called one per frame

    private void Update()
    {
        //Calcule les directions
        //Forward = avant/arrière
        //right = droite/gauche
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        //Est-ce qu'on appuie sur le bouton de direction ?

        // Z = axe arrière/avant
        float speedZ = Input.GetAxis("Vertical");

        // X = axe gauche/droite

        float speedX = Input.GetAxis("Horizontal");

        // Y = axe haut/bas
        float speedY = moveDirection.y;

        //Est-ce qu'on appuie sur le bouton pour courir (ici : shift gauche) ?
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //En train de courir
            isRunning = true;
        }
        else
        {
            isRunning = false;
        }

        // Est-ce que l'on court ?
        if (isRunning)
        {
            //Multiplee la vitesse par la vitesse de course
            speedX = speedX * runningspeed;
            speedZ = speedZ * runningspeed;
        }
        else
        {
            //Multiplie la vitesse par la vitesse de marche
            speedX = speedX * walkingspeed;
            speedZ = speedZ * walkingspeed;
        }

        //calcul du mouvement
        //forward = axe arrière/gauche
        //right = axe gauche/droite
        moveDirection = forward * speedZ + right * speedX;

        //Est-ce qu'on appuie sur le bouton de saut (ici : Espace) ?
        if(Input.GetButton("Jump") && characterController.isGrounded)
        {
            moveDirection.y = jumpspeed;
        }
        else
        {
            moveDirection.y = speedY;
        }

        //Si le joueur ne touche pas le sol
        if(!characterController.isGrounded)
        {
            //applique la gravité * delatime
            //time.deltatime = temps écolé depuis la dernière frame
            moveDirection.y -= gravity * Time.deltaTime;
        }

        //aplique le mouvement
        characterController.Move(moveDirection * Time.deltaTime);

        //rotation de la caméra
        //Input.GetAxis("Mouse Y") = mouvement de la souris haut/bas
        //on est en 3D donc applique ("mouse Y") sur l'axe de rotation X
        rotationX += -Input.GetAxis("Mouse Y") * rotationSpeed;

        //La rotation haut/bas de la caméra est comprise entre -45 et 45
        //Math.clamp permet de limiter une valeur
        //on limite rotationX, entre -ritationXLimit et rotationXLimit (-45 et 45)
        rotationX = Mathf.Clamp(rotationX, -rotationXLimit, rotationXLimit);

        //Applique la rotation haut/bas sur la caméra
        playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);

        //Input.GetAxis("Mouse X") = mouvement de la souris gauche/droite
        //Applique la rotation gauche/droite sur le player
        transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * rotationSpeed, 0);

    }

}