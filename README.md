# Capstone Project - Bladeless Wind Turbine GUI

Following is the image of the final device. The metal cylinder is the mast which oscillates in cross-flow wind and there is a coil at the bottom of the mast which generates emf when oscillated over a permanent magnet present underneath. The emf is amplified by op-amps and the oscillation angle is determined by the potentiometer attached to the mast's pivot point. This data is captured by Arduino which the GUI connects to and fetches the data from and saves + displays it in real-time to the user. 

<img src = "https://github.com/rish01/MECH458_Bladeless_Wind_Turbine/blob/master/images/IMG_7266.JPG" height = 700>

<br/> 

In order to use the GUI, simply run the BWT_GUI.exe file located in [BWT_GUI/bin/Release](https://github.com/rish01/MECH458_Bladeless_Wind_Turbine/blob/master/BWT_GUI/bin/Release/BWT_GUI.exev) folder. The GUI serves multiple purposes:
1. Fetches amplified potentiometer analog values and computes the angular position and velocity of the mast.
2. Fetches the amplified analog values of emf and current generated in the coil by the oscillatory motion of the magnet over the coil.
3. Displays the angular position and emf generated on a plot in real-time. 
4. Adds bias up and down arrows to zero point calibrate the position and emf.
5. Provides user the ability to save the data in a csv file of user-defined name.

<img src = "https://github.com/rish01/MECH458_Bladeless_Wind_Turbine/blob/master/images/Bladeless_Wind_Turbine_GUI.png" width = 800>
