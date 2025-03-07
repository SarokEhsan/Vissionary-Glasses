using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCarrousel : MonoBehaviour
{
    public GameObject levelsCarousel;

    // Update is called once per frame
    void Update()
    {
        LevelsCarouselFunc();
    }

    //this method handle moving levels button in menu by mouse wheel
    void LevelsCarouselFunc()
    {
        float mouseWheelValue = Input.GetAxis("Mouse ScrollWheel");
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray))
        {
            if (Input.mousePosition.y < 200)
            {
                if (mouseWheelValue != 0)
                {
                    CarrouselMove(mouseWheelValue);
                }
            }
        }
    }

    void CarrouselMove(float mouseWheel)
    {
        float scrollSpeed = 70.0f;
        float scrollBound = 150.0f;
        levelsCarousel.transform.position += new Vector3(mouseWheel * scrollSpeed, 0, 0);
        if (levelsCarousel.transform.position.x > scrollBound)
        {
            levelsCarousel.transform.position = new Vector3(scrollBound, levelsCarousel.transform.position.y, levelsCarousel.transform.position.z);
        }
    }
}
