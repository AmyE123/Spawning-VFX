# FreeJam VFX Test
A test for FreeJam for the Junior VFX role
[Final Presentation Photo / Cover Photo]

## Table of Contents
1. [Additional Information](#additional-information)
2. [Project Documentation](#project-documentation)
    * [Planning Stage](#planning-stage)

    * [Creating the Shader](#creating-the-shader)
        
    * [Creating the Particle FX](#creating-the-particle-fx)

    * [Developing and Presenting the Project](#developing-and-presenting-the-project)

    * [How I Would Improve and Optimize The Current Visual FX](#how-i-would-improve-and-optimize-the-current-visual-fx)
        
    * [A Different Approach Cookie Cutout](#a-different-approach-cookie-cutout)
                        
4. [Getting Started](#getting-started)
    * [Prerequisites](#prerequisites)
    * [Installing](#installing)
5. [Built With](#built-with)

---

## Additional Information

---

## Project Documentation

### Planning Stage
To start the project, I needed to plan out how I was going to approach this test, I had a visual effect video as my first point of reference, but I needed to take a deeper look into this video and really try to *break down* what I'm making, and this is where concept art, and quick sketches come in handy!

#### Initial Planning
From just watching the video I was able to break down the main parts of the shader and particles easily! I broke this down at a high level to begin with, so my initial concept art was more of an overview of how I wanted to approach the shader for the swiping effect, with a brief look into the details of the edge glow, and into the particles, but that was all it was, a brief look, and doing this made me realise the swiping of the shader, without the edge glow is a good place to begin with the shader! It didn't take me long to sketch this out, it was just how I envisioned the result of the swiping to look, and whilst I was doing this, I had the idea to also draw in this concept the shader being able to swipe from *any* angle, not just 90 degrees, 180 degrees, etc… - Just as a note for myself to look into later!
<img src="Concept_Art/Concept_Art.png" alt="Initial Concept Art" style="width:100%" align="center"/>

#### Planning Throughout Production
All the planning done after the initial planning was done during the production, after I noticed extra finer details like how the particle cubes weren’t 3d (or were they? I could never tell!), how the particles hover from top to bottom and how the shader would glow, this is all stuff which I noticed as I worked on different areas of the VFX, as my initial planning was more of a very high-level overlook of the effect.

##### Outline Glow Planning
<img src="Concept_Art/Concept_Art_Shader_Ideas.png" alt="Shader Ideas" style="width:100%" align="center"/>
I planned this out as I was working on the outline glow on the shader, but I didn't feel custom enough! So I sketched out the top three designs to give me an idea of what I wanted to do, and the bottom two were ideas I thought looked cool!

##### Particles Planning
<img src="Concept_Art/Concept_Art_Particle_Ideas.png" alt="Particle Ideas" style="width:100%" align="center"/>
When I made this, I was at a point where I felt ready to add the particles, but it was a new day, and I hadn’t watched the VFX video for a day as I didn’t have access to the example video, so I thought it might be a good, and creative time to draw up what I remember from the particles in the video and add some of my own ideas to it! This is what I drew from my memory! – And this is also, just a concept of the particles, without the glow around the edge of the shader so I can focus on just the particles for now.
Once I was able to watch the video again, I compared the concept planning to the actual VFX video, and I was close!
From this, I will be making the small cubes around the edge 2d, as they are in the video, but it’s hard to see, also in the example video, the 3D cubes are a lot smaller, and I still can't tell from the video whether they're 2D or 3D! I'm leaning more towards 3D though as it makes the most sense!
Watching the video again, and looking really close at the glowing edge, it made me realise that the smaller cubes weren't a particle, and were actually part of the shader! I wouldn't have noticed them at all without looking closer either!

##### Particle Flow and Silhouette Planning
<img src="Concept_Art/Concept_Art_Particle_Silhouettes.png" alt="Particle Flow & Silhouette" style="width:100%" align="center"/>
Due to the very particular moving pattern during the particles lifetime, I decided another good thing to doodle quickly would be how I envision the pattern of the particles over their lifetime, as well as the overall silhouette so the VFX looks balanced.
One of the main things I noticed is the pattern which the particles are taking, its hard to describe in words, but I can see the particles in the example travelling up the mesh, spawning subtly outwards and wiggling around, some going inwards, with a noise pattern applied.

##### Different Approaches & Optimizations Demonstration
<img src="Concept_Art/Concept_Art_Different_Approaches.png" alt="Different Approaches" style="width:100%" align="center"/>
Once I had finished the VFX, I was thinking of how I could improve and optimize it, as well as other approaches I could take, and I talk about this in more detail in the [How I Would Improve and Optimize The Current Visual FX](#how-i-would-improve-and-optimize-the-current-visual-fx) section, and the [A Different Approach Cookie Cutout](#a-different-approach-cookie-cutout) section of this document, but you can see the rough ideas here!

#### Analysis

### Creating The Shader

#### Swipe Shader

#### Glow Shader

#### Refactoring

#### Analysis

### Creating The Particle FX

#### Creation Process

#### Analysis

### Developing and Presenting The Project

#### The Visual FX Controller

#### Scene Presentation

#### Use of Source Control

#### Project Management

### How I Would Improve and Optimize The Current Visual FX

#### Planning Improvements and Optimization

#### Shader Improvements and Optimization

#### Particle Improvements and Optimization

### A Different Approach Cookie Cutout

#### Planning Cookie Cutout

#### Shader Ideas For Cookie Cutout

#### Particle Ideas For Cookie Cutout

---

## Getting Started

### Prerequisites
[![Unity Version: 2021.3.0f1](https://img.shields.io/badge/Unity-2021.3.0f1-333333.svg?logo=unity)](https://unity3d.com/get-unity/download/archive)

### Installing
Here is how you can get the test running for development and testing purposes:
```
1. Download the project 
2. Launch Unity Hub
3. Press 'Add' on the top right corner of the hub
4. Navigate to the directory where the project was downloaded
5. Open with the specified Unity version
```

## Built With
* [Unity](https://unity3d.com/get-unity/download/archive) - This is the Game Engine used
   * [Arcade Racing Cars](https://assetstore.unity.com/packages/3d/vehicles/arcade-racing-cars-pickup-jeep-153218) - This is the 3D asset I used to present the shader
   * [High Definition Render Pipeline](https://unity.com/srp/High-Definition-Render-Pipeline)
   * [HDRP Shader Graphs](https://unity.com/features/shader-graph)
* [Visual Studio 2019](https://visualstudio.microsoft.com/) - This is the IDE I used
