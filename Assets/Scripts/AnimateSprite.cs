using UnityEngine;

public class AnimateSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;

    void Awake() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start() 
    {
        InvokeRepeating(nameof(Animate), 0.15f, 0.15f);
    }

    void Animate() 
    {
        spriteIndex++;

        if(spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }
}
