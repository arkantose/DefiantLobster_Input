using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Game.Scripts.UI;

namespace Game.Scripts.LiveObjects
{
    public class Drone : MonoBehaviour
    {
        private enum Tilt
        {
            NoTilt, Forward, Back, Left, Right
        }

        [SerializeField]
        private Rigidbody _rigidbody;
        [SerializeField]
        private float _speed = 5f;
        private bool _inFlightMode = false;
        [SerializeField]
        private Animator _propAnim;
        [SerializeField]
        private CinemachineVirtualCamera _droneCam;
        [SerializeField]
        private InteractableZone _interactableZone;
        private InputControls _input;
        private bool _ascendIsPressed = false;
        private bool _descendIsPressed = false;
        private bool _escapeIsPressed = false;

        public static event Action OnEnterFlightMode;
        public static event Action onExitFlightmode;

        private void OnEnable()
        {
           
            InteractableZone.onZoneInteractionComplete += EnterFlightMode;
            InitializeInputs();
        }
 

        private void EnterFlightMode(InteractableZone zone)
        {
            if (_inFlightMode != true && zone.GetZoneID() == 4) // drone Scene
            {
                Debug.Log("hI there");
                _propAnim.SetTrigger("StartProps");
                _droneCam.Priority = 11;
                _inFlightMode = true;
                OnEnterFlightMode?.Invoke();
                UIManager.Instance.DroneView(true);
                _interactableZone.CompleteTask(4);
            }
        }

        private void ExitFlightMode()
        {            
            _droneCam.Priority = 9;
            _inFlightMode = false;
            UIManager.Instance.DroneView(false);            
        }

        private void Update()
        {
            if (_inFlightMode)
            {
                CalculateTilt();
                CalculateMovementUpdate();

                if (_escapeIsPressed == true)
                {
                    _inFlightMode = false;
                    onExitFlightmode?.Invoke();
                    ExitFlightMode();
                    _input.Drone.Disable();
                    _input.Player.Enable();
                }
            }
        }

        private void FixedUpdate()
        {
            _rigidbody.AddForce(transform.up * (9.81f), ForceMode.Acceleration);
            if (_inFlightMode)
                CalculateMovementFixedUpdate();
        }

        private void CalculateMovementUpdate()
        {
            /*if (Input.GetKey(KeyCode.LeftArrow))
            {
                var tempRot = transform.localRotation.eulerAngles;
                tempRot.y -= _speed / 3;
                transform.localRotation = Quaternion.Euler(tempRot);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                var tempRot = transform.localRotation.eulerAngles;
                tempRot.y += _speed / 3;
                transform.localRotation = Quaternion.Euler(tempRot);
            }*/

                var move = _input.Drone.FlyRot.ReadValue<Vector2>();
                var tempRot = transform.localRotation.eulerAngles;
                tempRot.y += (0.1f * 3) * move.x;
                transform.localRotation = Quaternion.Euler(tempRot);
        }

        private void CalculateMovementFixedUpdate()
        {
            
            if (_ascendIsPressed == true)
            {
                _rigidbody.AddForce(transform.up * _speed, ForceMode.Acceleration);
            }
            if (_descendIsPressed == true)
            {
                _rigidbody.AddForce(-transform.up * _speed, ForceMode.Acceleration);
            }
        }

        private void CalculateTilt()
        {

            /* if (Input.GetKey(KeyCode.A)) 
                 transform.rotation = Quaternion.Euler(00, transform.localRotation.eulerAngles.y, 30);
             else if (Input.GetKey(KeyCode.D))
                 transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, -30);
             else if (Input.GetKey(KeyCode.W))
                 transform.rotation = Quaternion.Euler(30, transform.localRotation.eulerAngles.y, 0);
             else if (Input.GetKey(KeyCode.S))
                 transform.rotation = Quaternion.Euler(-30, transform.localRotation.eulerAngles.y, 0);
             else 
                 transform.rotation = Quaternion.Euler(0, transform.localRotation.eulerAngles.y, 0);
            */
            var move = _input.Drone.FlyTilt.ReadValue<Vector2>();
            transform.rotation = Quaternion.Euler(move.y *30, transform.localRotation.eulerAngles.y, (move.x *30) *-1);

        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterFlightMode;
        }

        void InitializeInputs()
        {
            
            _input = new InputControls();
            _input.Player.Disable();
            _input.Drone.Enable();
            _input.Drone.Ascend.performed += Ascend_performed;
            _input.Drone.Descend.performed += Descend_performed;
            _input.Drone.Ascend.canceled += Ascend_canceled;
            _input.Drone.Descend.canceled += Descend_canceled;
            _input.Drone.Escape.performed += Escape_performed;
            _input.Drone.Escape.canceled += Escape_canceled;

        }

        private void Escape_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _escapeIsPressed = false;
        }

        private void Escape_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _escapeIsPressed = true;
        }

        private void Descend_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _descendIsPressed = false;
        }

        private void Ascend_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _ascendIsPressed = false;
        }

        private void Descend_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _descendIsPressed = true;
        }

        private void Ascend_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _ascendIsPressed = true;
        }
    }

}
