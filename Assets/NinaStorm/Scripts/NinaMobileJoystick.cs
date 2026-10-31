using UnityEngine;
using UnityEngine.EventSystems;

namespace NinaStorm
{
    /// <summary>
    /// Attach to a UI joystick background with a child knob.
    /// Connect playerController in the Inspector.
    /// </summary>
    public class NinaMobileJoystick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
    {
        public NinaPlayerController playerController;
        public RectTransform joystickArea;
        public RectTransform knob;
        [Range(0.2f, 1f)] public float handleRange = 0.65f;

        private Canvas canvas;
        private Camera uiCamera;

        private void Awake()
        {
            if (joystickArea == null) joystickArea = transform as RectTransform;
            canvas = GetComponentInParent<Canvas>();
            if (canvas != null && canvas.renderMode != RenderMode.ScreenSpaceOverlay)
                uiCamera = canvas.worldCamera;
        }

        public void OnPointerDown(PointerEventData eventData) { UpdateJoystick(eventData); }
        public void OnDrag(PointerEventData eventData) { UpdateJoystick(eventData); }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (knob != null) knob.anchoredPosition = Vector2.zero;
            if (playerController != null) playerController.SetMoveInput(Vector2.zero);
        }

        private void UpdateJoystick(PointerEventData eventData)
        {
            if (joystickArea == null || playerController == null) return;
            if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(
                joystickArea, eventData.position, uiCamera, out Vector2 localPoint)) return;

            Rect rect = joystickArea.rect;
            Vector2 normalized = new Vector2(
                rect.width > 0f ? localPoint.x / (rect.width * 0.5f) : 0f,
                rect.height > 0f ? localPoint.y / (rect.height * 0.5f) : 0f);
            normalized = Vector2.ClampMagnitude(normalized, 1f);

            if (knob != null)
                knob.anchoredPosition = new Vector2(normalized.x * rect.width * 0.5f * handleRange,
                                                    normalized.y * rect.height * 0.5f * handleRange);
            playerController.SetMoveInput(normalized);
        }
    }
}