# Born Studios
## Unity Developer Test

### Overview
This is the test we ask for all Unity Developer candidates to complete 
in our hiring process. The purpose of this test is to give us a sample of 
your thinking process as a software developer specialised in building 
applications on Unity, a sample of the coding practices your currently 
follow, and some idea on how you apply programming concepts to solve problems.
We will have a follow-up discussion after you submit the test to us so 
the test itself provides the basis for us to have that discussion.

### Duration
You're free to complete the test at your own pace. It shouldn't take 
more than 2 hours of your time. If you see that it's taking longer, 
feel free to stop spending time on the implementation at that point 
and just make notes for us to go through in the follow-up interview.

### Required Tools
* Unity 2021.3.0
* C# IDE of your choice. We recommend JerBrains Rider as it will provide
you with static code analysis which will help you submit better quality code.

### Project
The provided project is conceptually for an application that controls a 
physical device with body tracking. For this test there's no real body tracking 
and no real physical controlled device of course so interfaces for these are to 
be simulated.

Body tracking is thought to be on the same computer that runs the application. This 
could be imagined as a desktop computer or a VR device. In any case for this test 
we can mimic that by dragging objects that correspond to tracked joints on Unity 
editor in play mode.

Controlled device is thought to be an external device that this application needs 
to communicate with. The communication is out of scope of this test and we can 
ignore that part. What the application is trying to accomplish is to rotate the 
controlled device to always face the user's head. The externality of the device 
is represented by having an "input" object that supplies the rotation value that 
will be imagined to be sent to the device and an "output" object that should 
reflect the rotation that's imagined to be read from the device.

The provided code is annotated with xml documentation. Please make sure to read 
through to gain an understanding on them.

There is only 1 scene, `Main`, in the application. It's already populated with some 
objects to provide you with a starting point.

There is 1 prefab, `TrackedBody` in `Prefabs` folder.

### Objectives
* Construct the mechanism that will instantiate 1 `TrackedBody` in the scene after 
  the application starts.
* Construct a way to provide an access to this `TrackedBody` to the rest of the 
  application.
* Update the class `ControlledDeviceInput` to rotate the host object towards the 
  head joint of the `TrackedBody`.
* Construct a structure that simulates communication / control of the controlled 
  device. The communication itself can be simply represented by updating rotation 
  data that resides in a class member. This value then needs to be reflected on  
  `ControlledDeviceOutput`.
* To be able to implement the above, you'll also need to construct a way of 
  providing `GameObject` or `MonoBehaviour` references within the application. 
  Please don't use `GameObject.Find`.

### Questions
For any questions or request for clarification, please feel free to reach us 
through the channel this test was sent to you.
