public class CharacterControl : MonoBehaviour
{
    public int speed = 3;

    void Update()
    {
        transform.Translate(new Vector3((Input.GetAxis("Horizontal") * speed * Time.deltaTime), 0,
                                           (Input.GetAxis("Vertical") * speed * Time.deltaTime)));

    }
}