using UnityEngine;

public class mainMenuCamera : MonoBehaviour
{
    
    [SerializeField] private GameObject[] Locations;
    [SerializeField] private float moveDuration = 1.5f;

    private int currentLocationIndex = 0;
    
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float moveTime = 0f;
    private bool isMoving = false;

    void Start()
    {
        GoToLocation(0);
    }

    void Update()
    {
        if (!isMoving) return;

        moveTime += Time.deltaTime;
        float t = moveTime / moveDuration;

        t = 1 - Mathf.Pow(1 - t, 3);

        transform.position = Vector3.Lerp(startPosition, targetPosition, t);

        if (moveTime >= moveDuration)
        {
            transform.position = targetPosition;
            isMoving = false;
        }
    }

    public void GoToLocation(int index)
    {
        if (index < 0 || index >= Locations.Length) return;

        currentLocationIndex = index;

        startPosition = transform.position;
        targetPosition = Locations[index].transform.position;

        moveTime = 0f;
        isMoving = true;
    }

}
