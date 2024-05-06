# EDEN Game Engines Assignment Repo

Name: Amelia Finnerty

Student Number: C21341136

Class Group: TU984 Game Design Year 3

Video:
()

# Description of the project
For my EDEN project I wanted to recreate the nature found in my own garden at home. As I live out in the countryside I'm surrounded about a lot of nature from birds to foxes. I decided to focus on the birds in my garden in particular as I've always had an interest in bird watching and I thought that it would be fun to recreate in Unity. In my project you can explore a low-poly style garden where you're able to interact with the animals in the scene, as well as just watch them interact with eachother. As the main focus of the game is birds, there are a few different types throughout the game and you can switch the seasons in which you're playing to see more types and to learn all about the birds that we most commonly see in and around our gardens here in Ireland. I hope that you'll be able to identify them for yourself the next time you're out looking after playing through this project!

# Primary research videos/pictures
Link to the folder with my [primary research](https://drive.google.com/drive/folders/1U_38BIjF2x9La3iPT4CQNQc0ab5A-h9D?usp=sharing)

# Instructions for use
* W,A,S,D - to move the character around.
* Move mouse - look around and the player will move in that direction.
* Escape - will bring up the main menu, where you can edit settings and change the seasons in the game.
* E - to interact with game items, when prompted to do so.

# How it works
In this project you can move around the scene with the character controller that uses Unity's input system. While exploring the scene you can observe the birds that are there, each scene is a different season that has different birds to view. You can use the menu to change the season that you are in. The seasons buttons have a scene switch script attached to them and when they are pressed they call a public void to switch the game scene. (Code example below)

```C#
public void summerScene()
    {
        SceneManager.LoadScene("Summer scene");
    }
```

There are three types of small birds within each level that will bob up and down in their 'idle' state and I have used the UI system in Unity to display some details about each one so you know what you are looking at. There is also one big bird in each level that flies overhead. The big birds in each scene fly between two waypoints, the wings of the bird are made from the same code as the worms in the scene, so they can sometimes be a bit buggy. Some of the small birds have a state machine script that has three states, idle, flee and chase. When the bird is not near the player or a worm it is in the 'idle' state, when the player approaches the bird it will change to 'flee' and then back to 'idle' once the player has moved away. The bird will enter the 'chase' state when a worm gets close enough, in this state the bird will move towards the worm until it catches it. The state machine is still a bit buggy in the game as I didn't have enough time to fix it fully for the submission so I didn't want to apply it to all of the birds. (Code example below)

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

The worms in the scene were made from the things we learned in class and from scripts that I modified from class repos. These worms will seek out the flowers in the scene and will move towards them, once they get near enough to the flower it will be eaten and another one will spawn close by. The flowers have a script on them that causes them to jump to a random set of coordinates within a certain range when the worm gets close enough to 'eat' the previous flower. I had originally wanted to do a sript that would regrow flowers block by block using procedural animation but unfortunately I didn't have enough time to implement it. The worms had a state machine where they would flee from birds and chase the flower when the player scared the bird away but it was causing some bugs in the levels and had to be left out. (Code example below)

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

The scenes all have a table with a book on it, when the player approaches the book they can press 'E' to open it. Upon doing so, the canvas in the scene will display the book's UI, here the players can look at information and pictures of all of the different birds in the game and they can even use the buttons found in the book to play the different calls of each one of the birds so that they can learn to identify the ones they may see in their own gardens. (Code example below)

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
I have loved birds and bird watching ever since I was little and would always sit outside with my grandparents watching the birds when I was younger, so I knew when I got the brief for this project that my garden and it's birds was what I wanted to try and recreate. When conducting the primary research for my project I spent a lot of time out in my back garden just watching the birds and listening to them. I took notes of what birds I saw and what ones I wanted to add to the project too. I then went outside with my phone and camera to take some photos of the birds and to record some of their singing. I was very happy that some of the bird song I recorded was clear enough to make it into the actual project!

I tried to add in the birds that I see most often in my project so that it would be similar to real life. All of the birds in the project are regualr visitors, if not residents to my garden including a family of robins that have lived in our bushes for a few years and the different birds of prey that are often seen circling over the fields surrounding our house. Seeing a Red Kite flying over the house while leaving for college one morning gave me the idea for having a bigger bird in each leevl flying overhead and I think that it is very similar to real life.

I wanted the smaller birds to be simple models, I just built them in Unity using the basic shapes, and I tried to match their colours to the real life birds as best I could. I think that they are similar enough to real life that you could be able to tell them apart even without the UIs help, at least I hope you could! For the most part the birds I observed in my garden spend most of their time sitting around singing and fluffing their feathers, they seem very relaxed and care free, this is what gave me the idea for a state machine and to have them all start in an 'idle' state where they were just calm, not fleeing or chasing. When my dog, or something else does startle them or get too close, they will flee but will often come back to the same spot soon after. The fleeing mechainc in the project makes the bird move away when you approach but they will move back when you go away, this is quite true to what I have observed in the garden. Most of the birds, especially the sparrows, are often on the ground hunting for worms or other insects so that was why I implemented the chase mechanic but it is still very buggy in some of the levels.

Overall I think that my project, that was heavily inspired by my real-life garden, is very close in comparison to the real one. Besides the art-style, which is purposefully very cartoon like and low-poly, the animals in the scene mimic real life animals and they are made to resemble the real life ones too. I think that I did a good job with this using the basic shapes and materials in Unity.
 
# What I am most proud of in the assignment
I liked the idea of having small birds to show the state machine behaviours that we learned in class while having the bigger birds fly overhead show the different boid scripts that we learned, similar to that of the worms. I think the wings look cool on the birds, although as mentioned before sometimes they can get a bit buggy but I still think they're quite interesting to watch. It feels almost peaceful just to be able to go from looking at all of the scenenry and life of the garen, to the calmer sky where the birds are just flying back and forth. I think this reflects my actual garden really well and as the days get longer and the weather gets better I hope to be able to spend more time outside just looking at the nature that lives there.

I really like how the worms turned out, I struggled a lot at the beginning with how I wanted to implement them into the scenes. I learned a lot from the classes on boids and the different behaviours, the original class repo and it's various creatures really inpsired me. I thought they looked really cool with all of the different behaviours, it almost made them seem like they had unique personalities. When I settled on my garden and it's wildlife as the theme for this project I knew that I could try and incoporate these creatures in some way. First I though about snakes as they do look a lot like them but there aren't many snakes in my garden so I went for worms instead! I like how they turned out, however, I do wish that I would have been able to get the state machine working for submission but that's definitely something I can keep working on over the summer!

I enjoyed making the bird information book. When I thought of the idea for my EDEN project originally I wanted to try and recreate the birds in my garden exactly as I saw them when I was doing my research. I felt I was able to do that and I'm proud of how it turned out even if there are a few bugs still. When making the scenes I realised that not everyone may have a garden or space close to their house to see these birds or if they do they may not know a lot about them. As a result, instead of just showing these birds I wanted to try and teach people a bit about them too so that they can go outside to see and photograph them for themseleves! I really enjoyed making the book with the information on birds and the pictures because I was able to learn more about birds that I see and hear everyday and I learned a lot that I didn't know before. I am really proud of how it turned out, I'm especially proud of the buttons for the bird sounds as I think it was a really nice touch.

# What I learned
I learned a lot about state machines, how to use them and how to switch between the different states. I had a lot of fun with this as it's not something I use too often. Even though there were still a few bugs by submission day and I wasn't able to get everything working perfectly, I'm stil proud of what I did and what I was able to achieve from a lot of trial and error.

From our classes, from Youtube videos and looking at online posts I learned some new things about procedural generation and using boids in both Unity and Godot. I did my project in Unity as it was the engine I knew most about and the one I felt the most educated in but I still did some research into these mechanics in Godot and hope to try my hand at perhaps recreating this project in Godot over the summer!

I have used Unity's UI system in most of my projects througout my college course so far but by doing this project, especially the book of information, I learned a lot about the UI system that I didn't know before and I was able to try new things. My design for this project involved a lot of buttons and menus and this meant that I spent a lot of time trying out new things to see what looked good and what worked the best for this project. The buttons to pause and unpause as well as play and stop sounds were especially useful. Before this I was using a script to play and stop sounds, not realising you could do it straight for 'on button press' in the UI so that was helpful to learn.

I really enjoyed the learning process of this project, I feel that my skills have improved a lot both for Unity and also for Godot. I think that this project is very similar to real life and that it turned out like I had originally planned expect for some bugs with some of the animals and their behaviours. Even with these bugs I have learned a lot from things not working and I hope to be able to keep working on this in the future to improve even more. I also feel that this project has had me spending a lot more time outside in nature without technology just watching and listening, which I think most people take for granted and don't do enough of today. I hope that this project will encourage others to research their own local wildlife to see whats around and to go and take some time in nature, there's so much to see and learn!
