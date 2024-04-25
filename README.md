# Steering Behaviors

## Overview

This project demonstrates the implementation of steering behaviors in Unity. Steering behaviors are commonly used in game development to simulate autonomous and realistic movement for entities such as characters, vehicles, or creatures. They allow entities to navigate, avoid obstacles, flock together, pursue targets, evade threats, and more.

## What are Steering Behaviors?

Steering behaviors are a set of algorithms used to control the movement of entities in a simulated environment. These algorithms are inspired by the behaviors observed in nature and are widely used to create lifelike motion in computer-generated characters. Steering behaviors typically operate by computing forces that influence an entity's velocity, direction, and position over time.

Some common steering behaviors include:

- **Seek**: Directs the entity towards a specified target position.
- **Flee**: Causes the entity to move away from a threatening target.
- **Arrival**: Slows down the entity's velocity as it approaches the target position.
- **Wander**: Generates a random steering force to create unpredictable motion.
- **Avoidance**: Helps the entity avoid collisions with obstacles or other entities.
- **Pursuit**: Allows the entity to chase a moving target.
- **Evasion**: Enables the entity to evade pursuit by another entity.

## Implementation in Unity

In this Unity project, we have implemented various steering behaviors to demonstrate their applications. Each behavior is encapsulated within a separate script component attached to the entities in the scene. These scripts compute the steering forces based on the desired behavior and apply them to the entity's movement. Following the projects:

- Samples arithmetic operations on vectors 
- Enimies
- Flocking
- Hands-on using steering behaviors
- Sample example
- Space Rocket
- Zumbi NPC

The project includes examples of entities navigating through obstacles, flocking together, pursuing targets, and evading threats. Additionally, it provides adjustable parameters to fine-tune the behavior of entities and observe their interactions in real-time.

## Getting Started

To explore the project and understand the implementation of steering behaviors in Unity, follow these steps:

1. Clone or download the repository to your local machine.
2. Open the project in Unity Editor (version 2020.3.8f1 or higher).
3. Navigate to the scene files located in the `Assets/Scenes` directory.
4. Select a scene to open and observe the entities exhibiting different steering behaviors.
5. Review the scripts attached to the entities to understand how each behavior is implemented.
6. Experiment with adjusting parameters and adding new behaviors to observe their effects on entity movement.

## Resources and References

- [Unity Documentation](https://docs.unity3d.com/)
- [Steering Behaviors for Autonomous Characters](http://www.red3d.com/cwr/steer/)
- [Understanding Steering Behaviors](https://gamedevelopment.tutsplus.com/series/understanding-steering-behaviors--gamedev-12732)
- [Steering Behaviors - Craig Reynolds](https://www.red3d.com/cwr/)

For more detailed information on steering behaviors and their implementation in Unity, refer to the provided resources and documentation.

## Contributors

- [Murilo Boratto](https://github.com/muriloboratto)
- [Vinicius Santos](https://github.com/vimsos)

If you'd like to contribute to the project or have any suggestions, feel free to submit pull requests or open issues.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
