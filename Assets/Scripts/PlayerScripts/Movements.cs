using UnityEngine;

namespace PlayerScripts
{
    public class Movements : MonoBehaviour
    {
        private int _speed;
        private int _rotateSpeed;
        private int _jumpHeight;
        private Rigidbody _rigidbody;
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _speed = 5;
            _rotateSpeed = _speed * 25;
            _jumpHeight = 230;
        }
    
        void Update () 
        {
            if (Input.GetKey(GameManager.GM.forward))
            {
                transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            }
            if (Input.GetKey(GameManager.GM.backward))
            {
                transform.Translate(-Vector3.forward * _speed * Time.deltaTime);
            }
            if (Input.GetKey(GameManager.GM.left))
            {
                transform.Rotate(new Vector3(0,Vector3.left.x * _rotateSpeed * Time.deltaTime, 0));
            }
            if (Input.GetKey(GameManager.GM.right))
            {
                transform.Rotate(new Vector3(0,Vector3.right.x * _rotateSpeed * Time.deltaTime, 0));
            }
            if (Input.GetKeyDown(GameManager.GM.jump) && _rigidbody.worldCenterOfMass.y < 1.51f)
            {
                _rigidbody.AddForce(Vector3.up * _jumpHeight);
            }
        }
    }
}

