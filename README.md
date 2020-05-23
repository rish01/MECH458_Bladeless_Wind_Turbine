# Capstone Project - Bladeless Wind Turbine GUI

The following image shows the final device. The metal cylinder is the mast which oscillates in cross-flow wind and there is coil at the bottom of the mast which generates emf when oscillated over the magnet present underneath. The emf is amplified by op-amps and the oscillation angle is captured by the potentiometer attached to the mast's pivot point. This data is captured by Arduino and the GUI fetches the data and saves/displays it in real-time. 

<img src = "https://github.com/rish01/MECH458_Bladeless_Wind_Turbine/blob/master/images/IMG_7266.JPG" height = 700>

<br/> 

In order to use the GUI, simply run the BWT_GUI.exe file located in [BWT_GUI/bin/Release](https://github.com/rish01/MECH458_Bladeless_Wind_Turbine/blob/master/BWT_GUI/bin/Release/BWT_GUI.exev) folder. The GUI serves multiple purposes:
1. Fetch amplified potentiometer analog values and compute the angular position and velocity of the mast.
2. Fetch the amplified analog values of emf and current generated in the coil by the oscillatory motion of the magnet over the coil.
3. Display the angular position and emf generated on a plot in real-time. 
4. Add bias up and down arrows to zero point calibrate the position and emf.
5. Provide user the ability to save the data to a csv file of user-defined name.

<img src = "https://github.com/rish01/MECH458_Bladeless_Wind_Turbine/blob/master/images/Bladeless_Wind_Turbine_GUI.png" width = 800>
