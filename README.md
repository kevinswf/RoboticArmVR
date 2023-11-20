# RoboticArmVR
This Niryo One 6-axis robotic arm simulation envrionment in VR is built with Unity and a ROS server running in Docker.  

https://github.com/kevinswf/RoboticArmVR/assets/9206347/e248e232-edd6-41e2-a6ce-064da00e882e


(Please note the demo video is recorded in a desktop VR simulator rather than a VR HMD, so some movements may be clunky)

## Unity
The Unity scene simulates a VR environment for the robotic arm.  
The robot's joints and targets are sent to a ROS server for trajectory planning.  
The button on the table can be directly pressed or triggered by raycast, which in turn starts the robot trajectory simulation.  
The target cube can be picked up by either direct grab or raycast.  

To play on PC, the device simulator on PC can be used.
![image](https://github.com/kevinswf/RoboticArmVR/assets/9206347/85a11a33-1495-4494-b4c0-33244c539731)


## Docker
The robot's trajectory planning is run on a ROS server running in a Docker container.  
The container can be built using the dockerfile in this repo.  
```
docker build -t robotics:niryo-one -f docker/Dockerfile .  
```
Then run with
```
docker run -it --rm -p 10000:10000 robotics:niryo-one /bin/bash
```
