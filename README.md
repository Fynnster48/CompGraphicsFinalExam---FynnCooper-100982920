# CompGraphicsFinalExam

**Final Project Image**
<img width="1570" height="888" alt="image" src="https://github.com/user-attachments/assets/c82b2515-f63f-46fa-b728-5f91dd02212e" />
![2025-12-0914-28-47-ezgif com-crop](https://github.com/user-attachments/assets/da60a0b4-0111-4f91-ad2a-99cca9fa7d5f)


**First Half:**

Flat Shader: 
When creating my scene, I noticed there were empty spots on the left and right of the screen where the map doesn't line up. To cover these up, I decided to use a flat shader so it is just black bars on the 2 sides, otherwise it shows the Unity background, which doesn't fit the scene. For the changes I made, I adjusted the base colour in the inspector to change it from white to black.
<img width="1557" height="878" alt="image" src="https://github.com/user-attachments/assets/aa06db19-b6bf-427b-b4fe-51aff0b5243f" />
<img width="1385" height="832" alt="image" src="https://github.com/user-attachments/assets/7ffd5293-2b96-480d-982e-392da84af1cf" />


Toon Shader:
The next shader that I used was the Toon Shader. I used this shader on Pac-Man himself in order to get the bright yellow colour, and the ghosts so they can get their own respective colours. In the code, I amplified the rim power to 3 from 1.5 in order to make the rim more powerful without it taking over the model completely. This also makes all the main things you need to look out for standout the most. I then fidgeted with the inspector to get a colour that I thought fit Pac-Man & the ghosts the best. This Pac-Man model with the toon shader was also used for Pac-Man's lives, so they look identical to Pac-Man and people can recognize how many lives they have left.
<img width="631" height="252" alt="image" src="https://github.com/user-attachments/assets/ece81963-791f-41b9-9ae8-af88745a1460" />

ColourCorrection:
I was planning on adding ColourCorrection for when the player consumes one of the big candies, so that you can tell they are in the state of being able to eat the ghosts, but I didn't have time to finish it. I tried adding everything, but couldn't fully figure it out and didn't want to waste all my time on it. I did make the LUT, which is shown below with how it would look. My custom LUT amplifies the brightness in the scene and the contrast in the scene so that the player enters almost a sugar rush state where they can consume the ghosts. I also attached my attempt at adding ColourCorrection, which includes my code for trying it out and a photo of the inspector where you can see the camera with colour correction.
<img width="1078" height="883" alt="image" src="https://github.com/user-attachments/assets/35cb59d8-febb-41bd-ac2a-986de39f42e7" />
<img width="959" height="833" alt="image" src="https://github.com/user-attachments/assets/a73a33c4-8e4c-4e78-ac0b-ce26ba91dece" />
<img width="393" height="124" alt="image" src="https://github.com/user-attachments/assets/f49fd2bb-97da-4179-b236-46bd470be8cb" />


**Second Half:**

Transparency:
I used the transparency shader for the door that the ghosts leave from. For my Transparency shader to look how I wanted, I had to play around with parts of the hologram shader. I removed the lines because I didn't think they suited the door too well. I also adjusted the Transparency range to 2 so that I could make the glow stronger for the door. In the end, I like how the door turned out. Because the part of the shader that adds transparency, when a ghost or player walks through it, the colour of them momentarily changes. I thought this looked cool and added a little more juice to show a new ghost entering the zone. If I had time for sound effects, I would also add a sound effect here.
<img width="207" height="133" alt="image" src="https://github.com/user-attachments/assets/c9846979-4415-4552-b4ec-5e3548c98eb7" />
<img width="300" height="164" alt="image" src="https://github.com/user-attachments/assets/7650ee7d-4010-4a92-a693-1aa48b92bedc" />


Standard Specular:
For my walls, I wanted them just to be a matt colour. For this, I thought that specular looked good. I picked a dark blue so it is similar to the actual game, but because my project is built in 3d I liked the way the walls turned dark due to lighting with specular. I adjusted the colour in the inspector and changed the multiplier for Smoothness from 0.5 to 1, which made the colour stand out even more. I left the texture slots blank because I thought the blank colour matched the project more, rather than adding some random texture just because I could.
<img width="1550" height="880" alt="image" src="https://github.com/user-attachments/assets/b4bd9714-6e25-4e6c-8ca8-303817a185f5" />
<img width="679" height="135" alt="image" src="https://github.com/user-attachments/assets/709a39f0-5829-4ef7-97c5-91e079d50127" />


**Hologram:**
When thinking about where to apply the hologram texture, I settled on the big candies in the corner, which allows the player to consume the ghosts. The hologram shader, which has a moving line and transparency, works well here because it draws the player's attention due to the movement, and it is set to a bright pink which stands out even more. As far as adjustments go, I changed the "_Transparency" so that the range is higher to make it more customizable. I also changed the RimIntensity so that it applies more of a strong rim. In the inspector, I changed the speed at which the lines move, and  I also changed their frequency so it fits better with the speed.
![2025-12-0913-31-18-ezgif com-crop](https://github.com/user-attachments/assets/9c95bc74-f996-4f0b-b3a9-c32a59a73ed6)


**Scrolling:**
For my scrolling texture, I did something similar to the hologram but using the scrolling shader. Using the Scrolling shader, I found a gray line which, when adjusting the Scroll Y speed, creates a quick pulsing movement for all the small candy that the player can eat. This attracts the player towards the candy so that they can eat everything and accomplish all their goals. I set the MAIN texture to a blank orange colour, which in turn makes the lines orange instead of gray. So by playing with the speed at which the texture scrolls, I was able to accomplish this pulsing movement.
<img width="1920" height="744" alt="image" src="https://github.com/user-attachments/assets/a10f57a0-0d06-46e0-b110-dbedc9fd8b24" />
<img width="547" height="374" alt="image" src="https://github.com/user-attachments/assets/1d5423ee-39c5-458d-be8e-3c2b79c758ba" />
![2025-12-0914-06-00-ezgif com-crop](https://github.com/user-attachments/assets/639a7adb-bde2-4812-84e7-164de0075ca2)

Websites Used:
https://ezgif.com/video-to-gif  (Used to create gifs)
