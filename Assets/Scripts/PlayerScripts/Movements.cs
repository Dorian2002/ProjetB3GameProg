using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

namespace PlayerScripts
{
    public class Movements : MonoBehaviour
    {
        [SerializeField] private int _speed;
        private int _rotateSpeed;
        private int _jumpHeight;
        private Rigidbody _rigidbody;
        [SerializeField] private Transform _cam;
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _speed = 5;
            _rotateSpeed = _speed * 70;
            _jumpHeight = 230;
        }
    
        void Update () 
        {
            if (!GameManager.GM.menuing)
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
                    transform.Translate(Vector3.left * _speed * Time.deltaTime);
                }
                if (Input.GetKey(GameManager.GM.right))
                {
                    transform.Translate(Vector3.right * _speed * Time.deltaTime);
                }
                if (Input.GetKeyDown(GameManager.GM.jump) && _rigidbody.worldCenterOfMass.y < 1.51f)
                {
                    _rigidbody.AddForce(Vector3.up * _jumpHeight);
                }
                float h =  _rotateSpeed * Time.deltaTime * Input.GetAxis("Mouse X");
                //float v =  _rotateSpeed * Time.deltaTime * Input.GetAxis("Mouse Y");
                transform.Rotate(0, h, 0);
                //_cam.Rotate(-v,0,0);
            }
        }

        public void SetSpeed(int value)
        {
            _speed = value;
        }
    }
}

