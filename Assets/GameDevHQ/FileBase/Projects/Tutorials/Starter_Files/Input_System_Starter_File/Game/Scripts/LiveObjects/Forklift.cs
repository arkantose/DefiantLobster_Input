using System;
using UnityEngine;
using Cinemachine;

namespace Game.Scripts.LiveObjects
{
    public class Forklift : MonoBehaviour
    {
        [SerializeField]
        private GameObject _lift, _steeringWheel, _leftWheel, _rightWheel, _rearWheels;
        [SerializeField]
        private Vector3 _liftLowerLimit, _liftUpperLimit;
        [SerializeField]
        private float _speed = 5f, _liftSpeed = 1f;
        [SerializeField]
        private CinemachineVirtualCamera _forkliftCam;
        [SerializeField]
        private GameObject _driverModel;
        private bool _inDriveMode = false;
        [SerializeField]
        private InteractableZone _interactableZone;
        private InputControls _input;
        private bool _liftUp;
        private bool _liftDown;
        private bool _exitAction;

        public static event Action onDriveModeEntered;
        public static event Action onDriveModeExited;

        private void OnEnable()
        {
            InitializeInputs();
            InteractableZone.onZoneInteractionComplete += EnterDriveMode;
        }
        void InitializeInputs()
        {
            _input = new InputControls();
            _input.Player.Disable();
            _input.ForkLift.Enable();
            _input.ForkLift.LiftUp.started += LiftUp_started;
            _input.ForkLift.LiftUp.canceled += LiftUp_canceled;
            _input.ForkLift.LiftDown.started += LiftDown_started;
            _input.ForkLift.LiftDown.canceled += LiftDown_canceled;
            _input.ForkLift.Exit.started += Exit_started;
            _input.ForkLift.Exit.canceled += Exit_canceled;
        }

        private void Exit_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _exitAction = false;
        }

        private void Exit_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _exitAction = true;
        }

        private void LiftDown_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _liftDown = false;
        }

        private void LiftDown_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _liftDown = true;
        }

        private void LiftUp_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _liftUp = false;
        }

        private void LiftUp_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _liftUp = true;
        }

        private void EnterDriveMode(InteractableZone zone)
        {
            if (_inDriveMode !=true && zone.GetZoneID() == 5) //Enter ForkLift
            {
                _inDriveMode = true;
                _forkliftCam.Priority = 11;
                onDriveModeEntered?.Invoke();
                _driverModel.SetActive(true);
                _interactableZone.CompleteTask(5);
            }
        }

        private void ExitDriveMode()
        {
            _inDriveMode = false;
            _forkliftCam.Priority = 9;            
            _driverModel.SetActive(false);
            onDriveModeExited?.Invoke();
            
        }

        private void Update()
        {
            if (_inDriveMode == true)
            {
                LiftControls();
                CalcutateMovement();
                if (_exitAction == true)
                    ExitDriveMode();
            }

        }

        private void CalcutateMovement()
        {
            var move = _input.ForkLift.Move.ReadValue<Vector2>();
            float h = move.x;
            float v = move.y;
            var direction = new Vector3(0, 0, v);
            var velocity = direction * _speed;

            transform.Translate(velocity * Time.deltaTime);

            if (Mathf.Abs(v) > 0)
            {
                var tempRot = transform.rotation.eulerAngles;
                tempRot.y += h * _speed / 2;
                transform.rotation = Quaternion.Euler(tempRot);
            }
        }

        private void LiftControls()
        {
            if (_liftUp == true)
                LiftUpRoutine();
            else if (_liftDown == true)
                LiftDownRoutine();
        }

        private void LiftUpRoutine()
        {
            if (_lift.transform.localPosition.y < _liftUpperLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y += Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y >= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftUpperLimit;
        }

        private void LiftDownRoutine()
        {
            if (_lift.transform.localPosition.y > _liftLowerLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y -= Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
            }
            else if (_lift.transform.localPosition.y <= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftLowerLimit;
        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterDriveMode;
            _input.Player.Enable();
            _input.ForkLift.Disable();
        }

    }
}