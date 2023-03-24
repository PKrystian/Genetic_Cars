# Genetic Cars

## Table of Contents
+ [About](#about)
+ [Getting Started](#getting_started)
+ [Usage](#usage)
+ [Built Using](#built_using)
## Links
+ [Download GeneticCars](https://mega.nz/file/03I0AIZS#cx4ZDJW7E4pJOXJeRG1ROTWvZQOKGGjf8nrBqH8oTKY)
+ [Unity](https://unity.com/)

## About <a name = "about"></a>
Using a genetic algorithm model, the program teaches each generation of cars that tries to drive a route created by the user in unity.

Cars start at the blue point and try to get to the red point. If they drive into a white block, their turn ends. The next generation begins after a percentage of the population has finished their turn. The next generation gets some of the genes of the best cars from the previous generation. To prevent blockages, there is a mutation factor that causes the car to run erratically. Each of the given values ​​can be changed in the file: `Assets/Code/PopulationController.cs` .

![Alt Text](https://github.com/PKrystian/Genetic_Cars/blob/51566c7de99c5adf02a92884dcfb395df7a814b7/github_files/1000_generation.gif)

## Getting Started <a name = "getting_started"></a>
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

You need to have a [Unity](https://unity.com/) installed, preferably version `2021.3.20f1` or up.

You can download files from github or from this [link](https://mega.nz/file/03I0AIZS#cx4ZDJW7E4pJOXJeRG1ROTWvZQOKGGjf8nrBqH8oTKY), remember to unzip it.

### Installing

First open Unity Hub (remeber to have a right version installed), then click `Add project from disk` option in `Open` button, choose `GeneticCars` folder that you downloaded and unziped, then open the newly created project and you're good to go.


## Usage <a name = "usage"></a>

A window with an example scene should open. Now with the `Move Tool` and `Rect Tool`, you can edit the position of all objects (remember that the spawn and target points are hidden in PopulationController layer, and are not merged with colored blocks). If you want to add new walls, copy and paste them where you want.

After setting the scene, click the `Play` button at the top of the screen and watch the cars try to find their way.
The code is in `Assets/Code/`, in order to edit variables, enter the file `PopulationController.cs` .

Below are the generation steps in an example scene.

1st Generation:

<img src="https://github.com/PKrystian/Genetic_Cars/blob/51566c7de99c5adf02a92884dcfb395df7a814b7/github_files/1_generation.gif" width="600" height="250"/>

5th Generation:

<img src="https://github.com/PKrystian/Genetic_Cars/blob/51566c7de99c5adf02a92884dcfb395df7a814b7/github_files/5_generation.gif" width="600" height="250"/>

400th Generation:

<img src="https://github.com/PKrystian/Genetic_Cars/blob/51566c7de99c5adf02a92884dcfb395df7a814b7/github_files/400_generation.gif" width="600" height="250"/>

600th Generation:

<img src="https://github.com/PKrystian/Genetic_Cars/blob/51566c7de99c5adf02a92884dcfb395df7a814b7/github_files/600_generation.gif" width="600" height="250"/>

1000th Generation:

<img src="https://github.com/PKrystian/Genetic_Cars/blob/51566c7de99c5adf02a92884dcfb395df7a814b7/github_files/1000_generation.gif" width="600" height="250"/>

## Built Using <a name = "built_using"></a>

<p align="left"> <a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="160" height="160"/> </a> <a href="https://dotnet.microsoft.com/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="160" height="160"/> </a> <a href="https://unity.com/" target="_blank" rel="noreferrer"> <img src="https://www.vectorlogo.zone/logos/unity3d/unity3d-icon.svg" alt="unity" width="160" height="160"/> </a> </p>
