using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
     private Rigidbody2D _playerRigidbody2D;
     private Animator _playerAnimator;
     public float _playerSpeed;
     private Vector2 _playerDirection;

     //Start is called before the first frame update
     void Start()
     {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
        _playerAnimator = GetComponent<Animator>();
     }
     // Update is called once per frame
     void Update() {
      _playerDirection = new Vector2(Input.GetAxisRaw("Horizontal") , Input.GetAxisRaw("Vertical"));

     //animacao
      if(_playerDirection.sqrMagnitude > 0)
      {
        _playerAnimator.SetInteger("Andandin", 1);
      }
      else
      {
        _playerAnimator.SetInteger("Andandin", 0);
      }
     }

     void FixedUpdate()
     {
      _playerRigidbody2D.MovePosition(_playerRigidbody2D.position + _playerDirection * _playerSpeed * Time.fixedDeltaTime);
     }

}
