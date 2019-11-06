# VGA123_Unity_Template
 V2
 The majority of this package comes from Unity's Standard assets github, with some modifications by me, to include some simple, extendable scripts for Artists to work with - no code involved. 

You can find information about their package here, it is included in this project:
[https://github.com/victorpinto/VGA123_Unity_Template/tree/master/VGA123_UnityTemplate_V2](https://github.com/victorpinto/VGA123_Unity_Template/tree/master/VGA123_UnityTemplate_V2)

# INSTRUCTIONS 
## Scripts: 
### EventTriggers Script:
The EventTriggers script can do all sorts of things. It functions by checking to see if an object in its "Objects That Trigger" list has interacted with the game object with the EventTriggers script attached. It does this in three key ways:

 **1. **OnTriggerEnter****
When an object in the "Objects That Trigger" list **first** enters this object's Trigger Volume, run a function.   
 **2. OnTriggerStay**
When an object in the "Objects That Trigger" list **stays** inside this object's Trigger Volume, run a function.  
 **3. OnTrigger Exit**
When an object in the "Objects That Trigger" list **Exits** this object's Trigger Volume, run a function. 

**Setup**

 1. Drag the EventTriggers Script onto a Trigger Volume 
 2. Set the size of "Objects that Trigger" to how ever many objects you would like to be able to trigger these events. 
 3. Drag in the Player Character, or any other game object that you wish to trigger the events into the "Element" slot od the EventTriggers script. 

From here you have several choices..
#### *Customization* 
 ##### Press Button & Button Choice (OnTriggerStay)
 If you tick off the Press Button Checkbox, you also need to specify a button you would like to use in the **Button Choice** form. This setting will check for a button press, when a game object in the "Objects That Trigger" list, **stays** in the collider of the object with this script attached to it, you can then run a function. 
##### Reload Scene (OnTriggerEnter)
if you tick off the Reload Scene Checkbox, it will turn your trigger volume into a death trigger, that reloads the current scene. Primitive, but effective. 

#### Notes: 


 



<!--stackedit_data:
eyJoaXN0b3J5IjpbLTM3MDg5MzExMCwtMTIzMTc5NTY5MF19
-->