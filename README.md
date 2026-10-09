# Game-Engine-Midterm



The gameplay part is kinda there, as the player is able to move and jump, and can barely shoot bubbles, as that was implemented right at the very end. They do kill enemies if they hit them though. It does somewhat resemble the game at least.



I did some object oriented programming such as encapsulation with the player with getters and setters, and if I had time I could have made a powerup that changes them, as well as inheritance with the enemies inheriting from the Enemy class. I could have made the turn around timer in the base class and had the children override it for polymorphism, but I didn't think of that at the moment as I still had so much to do.



I did make a working singleton that was supposed to keep track of how many enemies are alive and how many enemies to spawn each level and reset the scene when there are no enemies left, but that part didn't work out, even though I copied it from my GDW solo project where I did the same thing to find all the enemies. The important part of a singleton, in which there is only 1 at a time and it carries over from scene to scene does work, but I had to replace the checking for enemies part with a simple timer that is set to a low number because I was already running out of time.



The factories fully broke. I took them directly from week 3 in class activity where I made a base for it to work on later, but for some reason one script just had so many errors that I had no clue how to fix and even if I did there was not enough time to do so. If you look at my in class activity 3 you can see that exact script working perfectly so i have no clue what happened.

Even if I did implement them the assignment still hasn't been graded so i dont know if they are fully correct or not, and I just have to assume it is.

My plan for the factory was to have it spawn the 2 different enemy types at certain spots upon loading the scene, and the amount it would have spawned would have been based on the singleton, which increases the amount of enemies to spawn each time the level is cleared.



There was absolutely no cleanup, as I never even came close to finishing in the amount of time given. I managed to build it, upload the repo, upload the build to the repo, and spent around 30 seconds testing everything and what I had did seem to work.





Personal notes

Making us use singletons/factories in ways we haven't used before is an awful idea. It makes it so we were unable to study how to do it a certain way and we were needed to come up with it on the fly. Excluding all of the big ones (for example, we couldn't use a singleton for game managers, audio managers, input manager, resource manager, localization manager, UI manager, event system, time manager, save manager, and those are only the ones in the slides, as i don't even remember which ones were brought up in the lectures/labs) was a terrible idea as we are supposed to be getting prepared to enter the industry, and we should be learning how to do it in these ways has that is the industry standard.

Not knowing what game wasn't bad itself, but with the other expectations it sucked. With how we were expected to make new singleton/factory ideas that we haven't done before, if we at least had some kind of idea of what kind of game we were making we could have studied new and different ways to make them that would work. The choice of game could also be better, as im guessing a good chunk of the class don't even know what bubble bobble is, as in a lab some students were learning things about The Legend Of Zelda: Ocarina Of Time, and if they don't know much about what is considered one of the greatest games of all time, i doubt they even know bubble bobble exists, and since they don't know anything about it that just gives them an extra challenge of figuring out what it is and what it's like.



Overall this sucked

There was nowhere near the amount of time needed to do everything needed for this

Marcus said that this was made easier than what it was, i am never taking an Alvaro course just for my mental health because it may actually kill me

