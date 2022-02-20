# CS8395-Project2
## AR book cover with Unity + Vuforia

# 📕  Overview
The purpose of this repositroy is to demonstrate the poweerful tool of Unity with Vuforia Engine. We will make the texts of a book cover poped out. Moeover, we will create a interactive book cover with the short summary of the book.

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

# have fun 😎

