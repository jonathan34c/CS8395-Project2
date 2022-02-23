# CS8395-Project2
## AR book cover with Unity + Vuforia

# 📕  Overview
The purpose of this repositroy is to demonstrate the poweerful tool of Unity with Vuforia Engine. We will make the texts of a book cover poped out. Moeover, we will create a interactive book cover with the short summary of the book.

The proejct download [link](https://vanderbilt.box.com/s/lc0hyuqoqwcteg4wh3t9iolz3d9aedqu) [link2](https://vanderbilt.box.com/s/mr054dyo9ztm323at9vqzhvsqhjm3buh) on box

# Sneak Peak of the result

- pop out book title
[![Watch the video](https://img.youtube.com/vi/auFsmwQ4TCU/maxresdefault.jpg)](https://youtu.be/auFsmwQ4TCU)

- pop out book title with interactive button 
- [![Watch the video](https://img.youtube.com/vi/CwEAOucXWHY/maxresdefault.jpg)](https://youtu.be/CwEAOucXWHY)

# 🎎 How to use the code

- Clone the code out of this repositroy.
- Download the vuforia engine SDK for unity from [this link](https://developer.vuforia.com/downloads/SDK) 
- Drag the SDK into your proejct.
- Create Vuforia database [like this](https://library.vuforia.com/articles/Solution/How-To-Work-with-Device-Databases.html)
- Swap the database with your choice
- Press play and test it out yourself 🏃🏼‍♀️
---
- To add an interactive button, add a VirtualButton to your ImageTarget
- Create a script for the button and modify it as you like.
- Here's the script for this proejct in C#
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject detail;
    public VirtualButtonBehaviour Vb;
    void Start()
    {
        Vb.RegisterOnButtonPressed(OnButtonPreesed);
        Vb.RegisterOnButtonReleased(OnButtonReleased);
        detail.SetActive(false);
    }

    public void OnButtonPreesed(VirtualButtonBehaviour vb)
    {
        detail.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        detail.SetActive(false);
    }
}

```

- it's pretty simple !

# 🔞Limitation
![bookfront](https://user-images.githubusercontent.com/8307131/154826604-59ea7564-1a54-4ba0-9c4c-5ff30c4d8f47.jpeg)
This can creat 5 stars database


![bookback](https://user-images.githubusercontent.com/8307131/154826607-dc95be55-9982-44df-a872-30f4cec5b10b.jpeg)
This can only create 2 stars database

- I tried to use the back of the book as the target image for my interactive buttom, but was limited to the quality of the image(2 stars)
- As you can see the cover of the book has much better contract and image quality compare to the back of the book
- When creating the image database by Vuforia, it would give the image a rating about the quality of the image. 
- I suggest a image quality of 4 or stars to have the optimize result.
- Therefore, it would be best for you to scan the book cover or download it from the internet to have the optimize result


# have fun 😎

