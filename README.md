# CompGraphicsFinalExam

**First Half:**
FlatShader: 
When creating my scene, I noticed there were empty spots on the left and right of the screen where the map doesn't line up. To cover these up, I decided to use a flat shader so it is just black bars on the 2 sides, otherwise it shows the unity backgroun,d which doesnt fit the scene. For the changes I made, I adjusted the base colour in the inspector to change it from a white colour to a black colour.
<img width="1557" height="878" alt="image" src="https://github.com/user-attachments/assets/aa06db19-b6bf-427b-b4fe-51aff0b5243f" />

ToonShader:
The next shader that I used was the Toon Shader. I used this shader on Pac-Man himself in order to get the bright yellow colour. In the code, I amplified the rim power to 3 from 1.5 in order to make the rim more powerful without it taking over the model completely. This also makes all the main things you need to look out for standout the most. I then fidgeted with the inspector to get a colour that I thought fit Pac-Man the best. After applying this shader to Pac-Man, I realized that I liked it enough to try and apply it to the ghosts. For each of the ghosts, I adjusted the colour in the inspector so they fit properly, which turned out well in the end.
<img width="631" height="252" alt="image" src="https://github.com/user-attachments/assets/ece81963-791f-41b9-9ae8-af88745a1460" />

ColourCorrection:
I was planning on adding ColourCorrection for when the player consumes one of the candies so that you can tell they are in the state of being able to eat the ghosts but didn't have time to get around to it. I did make the LUTs though which are shown below with how they would look
<img width="1078" height="883" alt="image" src="https://github.com/user-attachments/assets/35cb59d8-febb-41bd-ac2a-986de39f42e7" />


**Second Half:**
Transparency:
I used the transparency shader for the door that the ghosts leave from. For my Transparency shader to look how I wanted, I had to play around with parts of the hologram shader. I removed the lines because I didn't think they suited the door too well, I also adjusted the Transparency range to 2 so that I could make the glow stronger for the door. In the end I like how the door turned out.
<img width="207" height="133" alt="image" src="https://github.com/user-attachments/assets/c9846979-4415-4552-b4ec-5e3548c98eb7" />

Standard Specular:
For my walls, I wanted them to just be a matt colour. For this, I thought that specular looked good. I picked a dark blue so it is similair to the actual game but because my project is built in 3d I liked the way the walls turned dark due to lighting with specular. I adjusted the colour in the inspector and changed the multiplier for Smoothness to 1 which made the colour stand out even more. I left the texture slots blank because I thought the blank colour matched the project more, rather than adding some random texture just because I could.
<img width="1550" height="880" alt="image" src="https://github.com/user-attachments/assets/b4bd9714-6e25-4e6c-8ca8-303817a185f5" />


**Hologram:**
When thinking about where to apply the hologram texture, I settled on the candies in the corner, which allows the player to consume the ghosts. The hologram shader, which has a moving line and transparency, works well here because it draws the player's attention due to the movement, and it is set to a bright colour like candy. As far as adjustments go, I changed the "_Transparency" so that the range is higher to make it more customizable. I also changed the RimIntensity so that it applies more of a strong rim. In the inspector, I changed the speed at which the lines go, and  I also changed their frequency so it fits better with the speed.
![2025-12-0913-31-18-ezgif com-crop](https://github.com/user-attachments/assets/9c95bc74-f996-4f0b-b3a9-c32a59a73ed6)


**Scrolling:**

