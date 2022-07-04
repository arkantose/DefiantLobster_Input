using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

namespace Game.Scripts.LiveObjects
{
    public class Laptop : MonoBehaviour
    {
        [SerializeField]
        private Slider _progressBar;
        [SerializeField]
        private int _hackTime = 5;
        private bool _hacked = false;
        [SerializeField]
        private CinemachineVirtualCamera[] _cameras;
        private int _activeCamera = 0;
        [SerializeField]
        private InteractableZone _interactableZone;
        private InputControls _input;
        private bool _actionKeyPressed = false;
        private bool _exitKeyPressed = false;
        private int _keyIsPressed = 0;

        public static event Action onHackComplete;
        public static event Action onHackEnded;

        private void OnEnable()
        {
            InteractableZone.onHoldStarted += InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded += InteractableZone_onHoldEnded;
            InitializeInputs();
        }

        private void Update()
        {
            if (_hacked == true)
            {
                if (_actionKeyPressed == true && _keyIsPressed == 0)
                {
                    _keyIsPressed = 1;
                    var previous = _activeCamera;
                    _activeCamera++;


                    if (_activeCamera >= _cameras.Length)
                        _activeCamera = 0;


                    _cameras[_activeCamera].Priority = 11;
                    _cameras[previous].Priority = 9;
                    Invoke("DelayCameraSwitch", 1f);
                }

                if (_exitKeyPressed == true)
                {
                    _hacked = false;
                    onHackEnded?.Invoke();
                    ResetCameras();
                }
            }
        }

        void DelayCameraSwitch()
        {
            _keyIsPressed = 0;
        }
        void ResetCameras()
        {
            foreach (var cam in _cameras)
            {
                cam.Priority = 9;
            }
        }

        private void InteractableZone_onHoldStarted(int zoneID)
        {
            if (zoneID == 3 && _hacked == false) //Hacking terminal
            {
                _progressBar.gameObject.SetActive(true);
                StartCoroutine(HackingRoutine());
                onHackComplete?.Invoke();
            }
        }

        private void InteractableZone_onHoldEnded(int zoneID)
        {
            if (zoneID == 3) //Hacking terminal
            {
                if (_hacked == true)
                    return;

                StopAllCoroutines();
                _progressBar.gameObject.SetActive(false);
                _progressBar.value = 0;
                onHackEnded?.Invoke();
            }
        }

        
        IEnumerator HackingRoutine()
        {
            while (_progressBar.value < 1)
            {
                _progressBar.value += Time.deltaTime / _hackTime;
                yield return new WaitForEndOfFrame();
            }

            //successfully hacked
            _hacked = true;
            _interactableZone.CompleteTask(3);

            //hide progress bar
            _progressBar.gameObject.SetActive(false);

            //enable Vcam1
            _cameras[0].Priority = 11;
        }
        
        private void OnDisable()
        {
            InteractableZone.onHoldStarted -= InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded -= InteractableZone_onHoldEnded;
        }
        void InitializeInputs()
        {
            _input = new InputControls();
            _input.Player.Enable();
            _input.Player.Action.performed += Action_performed;
            _input.Player.Action.canceled += Action_canceled;
            _input.Player.Exit.performed += Exit_performed;
            _input.Player.Exit.canceled += Exit_canceled;
        }

        private void Exit_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _exitKeyPressed = false;
        }

        private void Exit_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _exitKeyPressed = true;
        }

        private void Action_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _actionKeyPressed = false;
        }

        private void Action_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _actionKeyPressed = true;
        }
    }

}

