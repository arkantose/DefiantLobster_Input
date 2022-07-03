using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Scripts.UI;


namespace Game.Scripts.LiveObjects
{
    public class InteractableZone : MonoBehaviour
    {
        private enum ZoneType
        {
            Collectable,
            Action,
            HoldAction
        }

        private enum KeyState
        {
            Press,
            PressHold
        }

        [SerializeField]
        private ZoneType _zoneType;
        [SerializeField]
        private int _zoneID;
        [SerializeField]
        private int _requiredID;
        [SerializeField]
        [Tooltip("Press the (---) Key to .....")]
        private string _displayMessage;
        [SerializeField]
        private GameObject[] _zoneItems;
        private bool _inZone = false;
        private bool _itemsCollected = false;
        private bool _actionPerformed = false;
        [SerializeField]
        private Sprite _inventoryIcon;
        [SerializeField]
        private string _zoneKeyInput;
        [SerializeField]
        private KeyState _keyState;
        [SerializeField]
        private GameObject _marker;
        //Input controlls 
        private InputControls _input;
        private bool _keyIsPressed = false;
        private bool _actionIsPerformed = false;
        private bool _holdIsPerformed = false;
        private bool _collectingIsPerformed = false;

        private bool _inHoldState = false;

        private static int _currentZoneID = 0;
        public static int CurrentZoneID
        { 
            get 
            { 
               return _currentZoneID; 
            }
            set
            {
                _currentZoneID = value; 
                         
            }
        }


        public static event Action<InteractableZone> onZoneInteractionComplete;
        public static event Action<int> onHoldStarted;
        public static event Action<int> onHoldEnded;

        private void OnEnable()
        {
            InitializeInputs();
            InteractableZone.onZoneInteractionComplete += SetMarker;

        }
        void InitializeInputs()
        {
            _input = new InputControls();
            _input.Player.Enable();
            _input.Player.Pickup.performed += Pickup_performed;
            _input.Player.Pickup.canceled += Pickup_canceled;
            _input.Player.Action.performed += Action_performed;
            _input.Player.Action.canceled += Action_canceled;
            _input.Player.HoldKey.performed += HoldKey_performed;
            _input.Player.HoldKey.canceled += HoldKey_canceled;
        }

        private void HoldKey_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _holdIsPerformed = false;
            _keyIsPressed = false;
        }

        private void HoldKey_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _holdIsPerformed = true;
            _keyIsPressed = true;
        }

        private void Action_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _actionIsPerformed = false;
            _keyIsPressed = false;
        }

        private void Action_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _actionIsPerformed = true;
            _keyIsPressed = true;
        }

        private void Pickup_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _collectingIsPerformed = false;
            _keyIsPressed = false;
        }

        private void Pickup_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _collectingIsPerformed = true;
            _keyIsPressed = true;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player") && _currentZoneID > _requiredID)
            {
                switch (_zoneType)
                {
                    case ZoneType.Collectable:
                        if (_itemsCollected == false)
                        {
                            _inZone = true;
                            if (_displayMessage != null)
                            {
                                string message = $"Press the {_zoneKeyInput.ToString()} key to {_displayMessage}.";
                                UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                            }
                            else
                                UIManager.Instance.DisplayInteractableZoneMessage(true, $"Press the {_zoneKeyInput.ToString()} key to collect");
                        }
                        break;

                    case ZoneType.Action:
                        if (_actionPerformed == false)
                        {
                            _inZone = true;
                            if (_displayMessage != null)
                            {
                                string message = $"Press the {_zoneKeyInput.ToString()} key to {_displayMessage}.";
                                UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                            }
                            else
                                UIManager.Instance.DisplayInteractableZoneMessage(true, $"Press the {_zoneKeyInput.ToString()} key to perform action");
                        }
                        break;

                    case ZoneType.HoldAction:
                        _inZone = true;
                        if (_displayMessage != null)
                        {
                            string message = $"Press the {_zoneKeyInput.ToString()} key to {_displayMessage}.";
                            UIManager.Instance.DisplayInteractableZoneMessage(true, message);
                        }
                        else
                            UIManager.Instance.DisplayInteractableZoneMessage(true, $"Hold the {_zoneKeyInput.ToString()} key to perform action");
                        break;
                }
            }
        }

        private void Update()
        {
            
            if (_inZone == true)
            {
                //(Input.GetKeyDown(_zoneKeyInput)
                if (_keyIsPressed == true && _keyState != KeyState.PressHold)
                {
                    //press
                    switch (_zoneType)
                    {
                        case ZoneType.Collectable:
                            if (_itemsCollected == false && _collectingIsPerformed == true)
                            {
                                CollectItems();
                                _itemsCollected = true;
                                UIManager.Instance.DisplayInteractableZoneMessage(false);
                            }
                            break;

                        case ZoneType.Action:
                            if (_actionPerformed == false && _actionIsPerformed == true)
                            {
                                PerformAction();
                                _actionPerformed = true;
                                UIManager.Instance.DisplayInteractableZoneMessage(false);
                            }
                            break;
                    }
                }
                //(Input.GetKeyDown(_zoneKeyInput)
                else if (_keyIsPressed == true && _keyState == KeyState.PressHold && _inHoldState == false && _holdIsPerformed == true)
                {
                    _inHoldState = true;

                   

                    switch (_zoneType)
                    {                      
                        case ZoneType.HoldAction:
                            PerformHoldAction();
                            break;           
                    }
                }
                //Input.GetKeyUp(_zoneKeyInput)
                if (_keyIsPressed == false && _keyState == KeyState.PressHold && _holdIsPerformed == false)
                {
                    _inHoldState = false;
                    onHoldEnded?.Invoke(_zoneID);
                }

               
            }
        }
       
        private void CollectItems()
        {
            foreach (var item in _zoneItems)
            {
                item.SetActive(false);
            }

            UIManager.Instance.UpdateInventoryDisplay(_inventoryIcon);

            CompleteTask(_zoneID);

            onZoneInteractionComplete?.Invoke(this);

        }

        private void PerformAction()
        {
            foreach (var item in _zoneItems)
            {
                item.SetActive(true);
            }

            if (_inventoryIcon != null)
                UIManager.Instance.UpdateInventoryDisplay(_inventoryIcon);

            onZoneInteractionComplete?.Invoke(this);
        }

        private void PerformHoldAction()
        {
            UIManager.Instance.DisplayInteractableZoneMessage(false);
            onHoldStarted?.Invoke(_zoneID);
        }

        public GameObject[] GetItems()
        {
            return _zoneItems;
        }

        public int GetZoneID()
        {
            return _zoneID;
        }

        public void CompleteTask(int zoneID)
        {
            if (zoneID == _zoneID)
            {
                _currentZoneID++;
                onZoneInteractionComplete?.Invoke(this);
            }
        }

        public void ResetAction(int zoneID)
        {
            if (zoneID == _zoneID)
                _actionPerformed = false;
        }

        public void SetMarker(InteractableZone zone)
        {
            if (_zoneID == _currentZoneID)
                _marker.SetActive(true);
            else
                _marker.SetActive(false);
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                _inZone = false;
                UIManager.Instance.DisplayInteractableZoneMessage(false);
            }
        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= SetMarker;
        }       
        
    }
}


