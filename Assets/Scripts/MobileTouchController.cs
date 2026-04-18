using UnityEngine;

namespace Gambrawl
{
    /// <summary>
    /// Example mobile touch controller for Gambrawl
    /// Handles basic touch input for mobile devices
    /// </summary>
    public class MobileTouchController : MonoBehaviour
    {
        [Header("Movement Settings")]
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private float rotationSpeed = 10f;
        
        [Header("Touch Settings")]
        [SerializeField] private float touchSensitivity = 0.1f;
        
        private Vector3 moveDirection;
        private Vector2 lastTouchPosition;
        private bool isTouching = false;
        
        private void Update()
        {
            HandleTouchInput();
            Move();
        }
        
        private void HandleTouchInput()
        {
            // Handle mobile touch input
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                
                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        isTouching = true;
                        lastTouchPosition = touch.position;
                        break;
                        
                    case TouchPhase.Moved:
                        if (isTouching)
                        {
                            Vector2 delta = touch.position - lastTouchPosition;
                            moveDirection = new Vector3(delta.x * touchSensitivity, 0f, delta.y * touchSensitivity);
                            lastTouchPosition = touch.position;
                        }
                        break;
                        
                    case TouchPhase.Ended:
                    case TouchPhase.Canceled:
                        isTouching = false;
                        moveDirection = Vector3.zero;
                        break;
                }
            }
            // Fallback to mouse input for testing in editor
            else if (Input.GetMouseButton(0))
            {
                Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
                moveDirection = new Vector3(mouseDelta.x, 0f, mouseDelta.y);
            }
            else
            {
                moveDirection = Vector3.Lerp(moveDirection, Vector3.zero, Time.deltaTime * 5f);
            }
        }
        
        private void Move()
        {
            if (moveDirection.magnitude > 0.1f)
            {
                // Move the object
                transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
                
                // Rotate towards movement direction
                if (moveDirection != Vector3.zero)
                {
                    Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
                    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
                }
            }
        }
    }
}
