# EDEN Game Engines Assignment Repo

Name: Amelia Finnerty

Student Number: C21341136

Class Group: TU984 Game Design Year 3

Video:
()

# Description of the project
For my EDEN project I wanted to recreate the nature found in my own garden. As I live out in the countryside I'm surrounded about a lot of nature from birds to foxes. I decided to focus on the birds in my garden in particular as I've always had an interest in bird watching and I thought that it would be fun to recreate in Unity. In my project you can explore a low-poly style garden where you're able to interact with the animals in the scene, as well as just watch them interact with eachother. As the main focus of the game is birds, there are a few different type throughout the game and you can switch the seasons in which you're playing to see more types and to learn all about the birds that we most commonly see in and around our gardens here in ireland, so that you'll be able to identify them for yourself the next time you're out looking!

# Primary research videos/pictures
Link to the folder with my [primary research](https://drive.google.com/drive/folders/1U_38BIjF2x9La3iPT4CQNQc0ab5A-h9D?usp=sharing)

# Instructions for use
* W,A,S,D - to move the character around.
* Move mouse - look around and the player will move in that direction.
* Escape - will bring up the main menu, where you can edit settings and change the seasons in the game.
* E - to interact with game items, when prompted to do so.

# How it works
In this project you can move around the scene with the character controller that uses Unity's input system. While exploring the scene you cna observe the birds that are there, each scene is a different seasosn that has different birds to view. You can use the menu to change the season that you are in. The seasons buttons have a scene switch sript attached to them and when they are pressed they call a public void to switch the game scene. (Code example below)

```C#
public void summerScene()
    {
        SceneManager.LoadScene("Summer scene");
    }
```

There are three types of small birds within each level that will bob up and down in their 'idle' state and I have used the UI system in Unity to display some details about each one so you know what you are looking at. There is also one big bird in each level that flies overhead. The big birds in each scene fly between two waypoints, the wings of the bird are made from the same code as the worms in the scene, so they can cometimes be a bit glitchy. Some of the small birds have a state machine script that has three states, idle, flee and chase. When the bird is not near the player or a worm it is in the 'idle' state, when the player approches the bird it will change to 'flee' and then back to 'idle' once the player has moved away. The bird will enter the 'chase' state when a worm gets close enough, in this state the bird will move towards the worm until it catches it. The state machine is still a bit buggy in the game as I didn't have enough time to fix it fully for the submission so I didn't want to apply it to all of the birds. (Code example below)

```C#
 if (Vector3.Distance(player.transform.position, bird.transform.position) > 5f)
        {
            canIdle = true;
            canFlee = false;
        }
```

```C#
  case State.Flee:

                if (canIdle == true)
                {
                    currentState = State.Idle;
                }
                else if (canFlee == true)
                {
                    birdFlee();
                }
                break;
```

The worms in the scene were made from the material we learned in class and from script that I modified from class repos. These worms will seek out the flowers in the scene and will move towards them, once they get near enough to the flower it will be eaten and another one will spawn close by. The flowers have a script on them that causes them to jump to a radom set of coordinates within a certain range when the worm gets close enough to 'eat' the previous flower. I had originally wanted to do a sript that would regrow flowers block by block using procedural animation but unfortunately I didn't have enough time to implement it. The worms had a state machine where they would flee from birds and chase the flower when the player scared the bird away but it was causing some bugs in the levels and had to be left out. (Code example below)

```C#
 void Update()
    {
        //move to new random position
        if (Vector3.Distance(worm.transform.position, flower.transform.position) < 1f)
        {
            goNewPos();
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * speed);
        }
    }

    void goNewPos()
    {
        newPos = new Vector3(Random.Range(-200.0f, 200.0f), transform.position.y ,Random.Range(-200.0f, 200.0f));
    }
```

The scenes all have a table with a book on it in them, when the player approaches the book they can press 'E' to open it. Upon doing so the canvas in the scene will display the book's UI, here the players can look at information oand pictures of all of the different birds in the game and they can even use the buttons found in the book to play the different calls of each one of the birds so that they can learn to identify the birds they may scene in their own gardens. (Code example below)

```C#
 void Update()
    {
     if(Input.GetKeyDown(KeyCode.E) && Vector3.Distance(player.transform.position, gameObject.transform.position) < 3f)
        {
            bookInfo.SetActive(true);
            birdText.SetActive(false);
        }
    }
```

# List of classes/assets in the project

| Class/asset | Source |
|-----------|-----------|
|Harmonic.cs|Script from class|
|Myboid.cs|Script modified from class|
|Movement.cs|Script from previous project|
|NoiseWand.cs|Script from class|
|SteeringBehaviour.cs|Script from class|
|boid.cs|Script from class|
|cursorController.cs|Self written|
|mouseLook.cs|Self written|
|sceenSwitch.cs|Self written|
|seek.cs|Script from class|
|spineGen.cs|Script from class|
|wingFlapping.cs|Script modified from a past class project|
|chaseBirdStateMachine.cs|Self written|
|flowerGrow.cs|Script modified from reference|
|swoop.cs|Self written|
|textController.cs|Script from class|
|wingSeek.cs|Script modified from class|
|wormStateMachine.cs|Self written|
|birdFly.cs|Script modified from class|
|birdStateMachine.cs|Self written|
|bookInteract.cs|Self written|
|Skybox|From [asset store](https://assetstore.unity.com/packages/2d/textures-materials/sky/farland-skies-cloudy-crown-60004)|
|All tree and bush assets|Self made|
|All bird assets|Self made|
|Any other assets in scenes|Self made|
|Pictures of birds|[Google Images](https://images.google.com/)|
|Background bird song in scenes|Self recorded|
|Blackbird song|Self recorded|
|Blue Tit song|From [freesound.org](https://freesound.org/people/acclivity/sounds/509707/)|
|House Sparrow song|From [freesound.org](https://freesound.org/people/soundbytez/sounds/110991/)|
|Robin song|From [freesound.org](https://freesound.org/people/Sparrer/sounds/49985/)|
|Starling song|From [freesound.org](https://freesound.org/people/PianoFarm/sounds/521799/)|
|Goldfinch song|From [freesound.org](https://freesound.org/people/TRP/sounds/616983/)|
|Chaffinch song|From [freesound.org](https://freesound.org/people/dobroide/sounds/50883/)|
|Pigeon sounds|From [freesound.org](https://freesound.org/people/squashy555/sounds/319512/)|
|Herring Gull sounds|From [freesound.org](https://freesound.org/people/se2001/sounds/510204/)|
|Crow sounds|From [freesound.org](https://freesound.org/people/mudflea2/sounds/708181/)|
|Kestrel sounds|From [freesound.org](https://freesound.org/people/dobroide/sounds/17507/)|

# References
* Facts on [Blackbirds](https://www.livingwithbirds.com/tweetapedia/21-facts-on-blackbird)
* Facts on [Blue Tits](https://www.livingwithbirds.com/tweetapedia/21-facts-on-blue-tit)
* Facts on [House Sparrows](https://www.livingwithbirds.com/tweetapedia/21-facts-on-house-sparrow)
* Facts on [Robins](https://www.livingwithbirds.com/tweetapedia/21-facts-on-robin)
* Facts on [Starlings](https://www.livingwithbirds.com/tweetapedia/21-facts-on-starling)
* Facts on [Goldfinches](https://www.livingwithbirds.com/tweetapedia/21-facts-on-goldfinch)
* Facts on [Chaffinches](https://www.livingwithbirds.com/tweetapedia/21-facts-on-chaffinch)
* Facts on [Pigeons](https://www.excelpestservices.com/11-fun-facts-about-pigeons/)
* Facts on [Herring Gulls](https://www.allaboutbirds.org/guide/Herring_Gull/overview)
* Facts on [Crows](https://www.mentalfloss.com/article/504722/12-fascinating-facts-about-crows)
* Facts on [Kestrels](https://www.livingwithbirds.com/tweetapedia/21-facts-on-kestrel)
* [Reference](https://forum.unity.com/threads/moving-object-in-random-position-in-scence-like-fly.328050/) for the flower growing script.

# My observations of real life vs the project simulation
I also felt that this project encouraged me to spend more time out in the garden or even just looking out the windows, enjoying the nature that surrounds us everyday without the need for technology.
 
# What I am most proud of in the assignment
I liked the idea of having small birds to show the state machine behaviours that we learned in class while having the bigger birds fly overhead show the different boid script taht we learned, similar to that of the worms. I think the wings look cool on the birds, although as mentioned before sometimes they can get a bit buggy but I still think they're quite interesting to watch. It feels almost peaceful just to be able to go from looking at all of the scenenry and life of the garen to the calmer sky where the birds are just flying back and forth. I think this reflects my actual garden really well and as the days get longer and the weather gets better I hope to be able to spend more time outside just looking at the nature that lives there.

I really like how the worms turned out, I struggled a lot at the beginning with how I wanted to implement them into the scenes. I learned a lot from the classes on boids and the different behaviours, the original class repo and it's various creatures really inpsired me. I thought they looked really cool with all of the different behaviours, it almost made them seem like they had unique personalities. When I settled on my garden and it's wildlife as the theme for this project I knew that I could try and incoporate these creatures in some way. First I though about snakes as they do look a lot like them but there aren't many snakes in my garden so I went for worms instead! I like how they turned out however I do wish that I would have been able to get the state machine workig for submission but that's definitely something I can keep working on over the summer!

I enjoyed making the bird info book. When I thought of the idea for my EDEN project originally I wanted to recreate the birds in my garden as I saw them when doing my research, I felt I was able to do that and I'm proud of how it turned out even if there are a few bugs still. When making the scenes I realised that noteveryone may have a garden or space close to their house to see these birds or if they do they may not now a lot about them. As a result, instead of just showing these birds I wanted to try and teach players a bit about them too so that they can go outside and see and photograph them for themsleves! I really enjoyed making the book with the information on birds and the pictures becasue I was able to learn more about birds that I see and hear everyday and I learned a lot that I didn't know before. I am really proud of how it turned out, I'm especially proud of the buttons for the bird sounds as I think it was a really nice touch.

# What I learned
A lot about state machines from a lot of trial and error.

Plan better with time.

Learned some about procedural generation.

A lot about Unity's UI system.

